using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_allenamenti;
using MySql.Data.MySqlClient;

namespace app_allenamenti_.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadExercises();
            ConfigureListView();
            LoadSchede();
            LoadComboBoxes();
            LoadData();
            LoadExerciseHistory();

        }
        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la chiusura della connessione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            Application.Exit();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void registrabtn_Click(object sender, EventArgs e)
        {
            LogExercise();
            LoadData();
            LoadExerciseHistory();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void createschedabtn_Click(object sender, EventArgs e)
        {
           CreateScheda();
           LoadSchede();
        }
        private void Addexercixes_Click(object sender, EventArgs e)
        {
            AddExercise();
            LoadExercises();
        }

        //funzioni backend
        private void ClearFields()
        {
            schedatitle.Clear();
            descritionscheda.Clear();
            foreach (ListViewItem item in newschedaesercizi.Items)
            {

                item.Checked = false;
            }
        }
        private void LoadExercises()
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT id_esercizio, nome FROM esercizo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            newschedaesercizi.Items.Clear(); 

                            while (reader.Read())
                            {
                                int exerciseId = reader.GetInt32("id_esercizio"); 
                                string exerciseName = reader.GetString("nome");  

                                
                                ListViewItem item = new ListViewItem(exerciseName)
                                {
                                    Tag = exerciseId 
                                };

                                newschedaesercizi.Items.Add(item); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento degli esercizi: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logout()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            Program.CurrentUserId = -1;
            Login_register loginForm = new Login_register();
            loginForm.Show();
            this.Close();
        }


        private List<int> GetSelectedExercises()
        {
            List<int> selectedExercises = new List<int>();

            foreach (ListViewItem item in newschedaesercizi.SelectedItems)
            {
                
                int exerciseId = Convert.ToInt32(item.Tag);
                selectedExercises.Add(exerciseId);
            }

            return selectedExercises;
        }
        private void LoadSchede()
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // Query per recuperare le schede dell'utente
                    string querySchede = "SELECT id_scheda, titolo, descrizione FROM scheda WHERE id_utente = @userId";
                    using (MySqlCommand cmdSchede = new MySqlCommand(querySchede, conn))
                    {
                        cmdSchede.Parameters.AddWithValue("@userId", Program.CurrentUserId);

                        using (MySqlDataReader readerSchede = cmdSchede.ExecuteReader())
                        {
                            listviewschede.Items.Clear(); // Pulisce la ListView

                            while (readerSchede.Read())
                            {
                                int schedaId = readerSchede.GetInt32("id_scheda");
                                string titolo = readerSchede.GetString("titolo");
                                string descrizione = readerSchede.GetString("descrizione");

                                // Aggiunge un elemento per ogni scheda
                                ListViewItem item = new ListViewItem(titolo);
                                item.SubItems.Add(descrizione);

                                // Recupera gli esercizi associati alla scheda
                                item.SubItems.Add(GetExercisesForScheda(schedaId));
                                item.Tag = schedaId; // Salva l'ID scheda nel Tag per eventuali operazioni future

                                listviewschede.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento delle schede: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetExercisesForScheda(int schedaId)
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string queryEsercizi = @"
                        SELECT e.nome, c.carico_iniziale 
                        FROM carico c
                        JOIN esercizo e ON c.id_esercizio = e.id_esercizio
                        WHERE c.id_scheda = @schedaId";

                    using (MySqlCommand cmdEsercizi = new MySqlCommand(queryEsercizi, conn))
                    {
                        cmdEsercizi.Parameters.AddWithValue("@schedaId", schedaId);

                        using (MySqlDataReader readerEsercizi = cmdEsercizi.ExecuteReader())
                        {
                            List<string> exercises = new List<string>();

                            while (readerEsercizi.Read())
                            {
                                string nome = readerEsercizi.GetString("nome");
                                double caricoIniziale = readerEsercizi.GetDouble("carico_iniziale");
                                exercises.Add($"{nome} ({caricoIniziale} kg)");
                            }

                            return string.Join(", ", exercises); // Combina gli esercizi in una stringa
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento degli esercizi: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Errore";
            }
        }
        private void ConfigureListView()
        {
            listviewschede.View = View.Details;
            listviewschede.FullRowSelect = true;
            listviewschede.Columns.Add("Titolo", 150, HorizontalAlignment.Left);
            listviewschede.Columns.Add("Descrizione", 250, HorizontalAlignment.Left);
            listviewschede.Columns.Add("Esercizi", 300, HorizontalAlignment.Left);
            listViewHistory.View = View.Details;
            listViewHistory.FullRowSelect = true;
            listViewHistory.Columns.Add("Date", 100, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Scheda", 150, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Exercise", 150, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Weight Used (kg)", 120, HorizontalAlignment.Right);
            listViewHistory.Columns.Add("Reps Completed", 120, HorizontalAlignment.Right);
        }

        
        private void LoadComboBoxes()
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                   
                    string queryTipo = "SELECT id_tipo, nome_tipo FROM tipo_esercizio";
                    using (MySqlCommand cmdTipo = new MySqlCommand(queryTipo, conn))
                    {
                        using (MySqlDataReader reader = cmdTipo.ExecuteReader())
                        {
                            typecombo.Items.Clear();
                            while (reader.Read())
                            {
                                typecombo.Items.Add(new ComboBoxItem
                                {
                                    Text = reader.GetString("nome_tipo"),
                                    Value = reader.GetInt32("id_tipo")
                                });
                            }
                        }
                    }

                   
                    string queryDescrizione = "SELECT id_descrizione, nome_esercizio FROM esercizi_descrizione";
                    using (MySqlCommand cmdDescrizione = new MySqlCommand(queryDescrizione, conn))
                    {
                        using (MySqlDataReader reader = cmdDescrizione.ExecuteReader())
                        {
                            descriptioncombo.Items.Clear();
                            descriptioncombo.Items.Add(new ComboBoxItem
                            {
                                Text = "-- Add New Description --",
                                Value = null
                            });

                            while (reader.Read())
                            {
                                descriptioncombo.Items.Add(new ComboBoxItem
                                {
                                    Text = reader.GetString("nome_esercizio"),
                                    Value = reader.GetInt32("id_descrizione")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dei dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void AddExercise()
        {
            string exerciseName = nametext.Text.Trim();
            string description = textdescription.Text.Trim();
            int series = (int)upseries.Value;
            int repetitions = (int)uprepetitions.Value;
            var selectedType = (ComboBoxItem)typecombo.SelectedItem;
            var selectedDescription = (ComboBoxItem)descriptioncombo.SelectedItem;
            string newDescription = newdescriptionexercixes.Text.Trim();

            if (string.IsNullOrWhiteSpace(exerciseName) || string.IsNullOrWhiteSpace(description) || selectedType == null)
            {
                MessageBox.Show("Tutti i campi obbligatori devono essere compilati!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            int descriptionId = selectedDescription?.Value != null ? (int)selectedDescription.Value : -1;

                           
                            if (!string.IsNullOrWhiteSpace(newDescription))
                            {
                                string queryNewDescription = "INSERT INTO esercizi_descrizione (nome_esercizio, descrizione_esecuzione) VALUES (@name, @description)";
                                using (MySqlCommand cmd = new MySqlCommand(queryNewDescription, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@name", exerciseName);
                                    cmd.Parameters.AddWithValue("@description", newDescription);
                                    cmd.ExecuteNonQuery();
                                    descriptionId = (int)cmd.LastInsertedId;
                                }
                            }

                           
                            string queryNewExercise = @"
                                INSERT INTO esercizo (nome, descrizione, serie_predefinite, ripetizioni_predefinite, id_tipo, id_descrizionee) 
                                VALUES (@name, @description, @series, @repetitions, @typeId, @descriptionId)";
                            using (MySqlCommand cmd = new MySqlCommand(queryNewExercise, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@name", exerciseName);
                                cmd.Parameters.AddWithValue("@description", description);
                                cmd.Parameters.AddWithValue("@series", series);
                                cmd.Parameters.AddWithValue("@repetitions", repetitions);
                                cmd.Parameters.AddWithValue("@typeId", selectedType.Value);
                                cmd.Parameters.AddWithValue("@descriptionId", descriptionId != -1 ? (object)descriptionId : DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Esercizio aggiunto con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFieldsnewexercixes();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'aggiunta dell'esercizio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFieldsnewexercixes()
        {
            nametext.Clear();
            textdescription.Clear();
            upseries.Value = 1;
            uprepetitions.Value = 1;
            typecombo.SelectedIndex = -1;
            descriptioncombo.SelectedIndex = -1;
            newdescriptionexercixes.Clear();
        }

       

        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                   
                    string querySchede = "SELECT id_scheda, titolo FROM scheda WHERE id_utente = @userId";
                    using (MySqlCommand cmdSchede = new MySqlCommand(querySchede, conn))
                    {
                        cmdSchede.Parameters.AddWithValue("@userId", Program.CurrentUserId);

                        using (MySqlDataReader reader = cmdSchede.ExecuteReader())
                        {
                            comboBoxSchede.Items.Clear();
                            while (reader.Read())
                            {
                                comboBoxSchede.Items.Add(new ComboBoxItem
                                {
                                    Text = reader.GetString("titolo"),
                                    Value = reader.GetInt32("id_scheda")
                                });
                            }
                        }
                    }

                    
                    string queryEsercizi = "SELECT id_esercizio, nome FROM esercizo";
                    using (MySqlCommand cmdEsercizi = new MySqlCommand(queryEsercizi, conn))
                    {
                        using (MySqlDataReader reader = cmdEsercizi.ExecuteReader())
                        {
                            comboBoxEsercizi.Items.Clear();
                            while (reader.Read())
                            {
                                comboBoxEsercizi.Items.Add(new ComboBoxItem
                                {
                                    Text = reader.GetString("nome"),
                                    Value = reader.GetInt32("id_esercizio")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dei dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void LogExercise()
        {
            if (comboBoxSchede.SelectedItem == null || comboBoxEsercizi.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxWeightUsed.Text) ||
                string.IsNullOrWhiteSpace(textBoxRepCompleted.Text) ||
                !dateTimePickerExecutionDate.Value.Date.ToString().Any())
            {
                MessageBox.Show("Tutti i campi sono obbligatori!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedScheda = (ComboBoxItem)comboBoxSchede.SelectedItem;
            var selectedEsercizio = (ComboBoxItem)comboBoxEsercizi.SelectedItem;

            int schedaId = (int)selectedScheda.Value;
            int esercizioId = (int)selectedEsercizio.Value;
            DateTime executionDate = dateTimePickerExecutionDate.Value.Date;
            double weightUsed = double.Parse(textBoxWeightUsed.Text);
            int repsCompleted = int.Parse(textBoxRepCompleted.Text);

            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO storico_esercizi (id_utente, id_scheda, id_esercizio, data_esecuzione, carico_utilizzato, ripetizioni_eseguite)
                        VALUES (@userId, @schedaId, @esercizioId, @executionDate, @weightUsed, @repsCompleted)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", Program.CurrentUserId);
                        cmd.Parameters.AddWithValue("@schedaId", schedaId);
                        cmd.Parameters.AddWithValue("@esercizioId", esercizioId);
                        cmd.Parameters.AddWithValue("@executionDate", executionDate);
                        cmd.Parameters.AddWithValue("@weightUsed", weightUsed);
                        cmd.Parameters.AddWithValue("@repsCompleted", repsCompleted);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Esercizio registrato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFieldsLog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la registrazione dell'esercizio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFieldsLog()
        {
            comboBoxSchede.SelectedIndex = -1;
            comboBoxEsercizi.SelectedIndex = -1;
            textBoxWeightUsed.Clear();
            textBoxRepCompleted.Clear();
            dateTimePickerExecutionDate.Value = DateTime.Now;
        }

       
        private void LoadExerciseHistory()
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    
                    string query = @"
                    SELECT s.titolo AS scheda, e.nome AS esercizio, se.data_esecuzione, se.carico_utilizzato, se.ripetizioni_eseguite 
                    FROM storico_esercizi se
                    JOIN scheda s ON se.id_scheda = s.id_scheda
                    JOIN esercizo e ON se.id_esercizio = e.id_esercizio
                    WHERE se.id_utente = @userId
                    ORDER BY se.data_esecuzione DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", Program.CurrentUserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            listViewHistory.Items.Clear(); 

                            while (reader.Read())
                            {
                                
                                string date = reader.GetDateTime("data_esecuzione").ToString("yyyy-MM-dd");
                                string scheda = reader.GetString("scheda");
                                string esercizio = reader.GetString("esercizio");
                                double weightUsed = reader.GetDouble("carico_utilizzato");
                                int repsCompleted = reader.GetInt32("ripetizioni_eseguite");

                                
                                ListViewItem item = new ListViewItem(date);
                                item.SubItems.Add(scheda);
                                item.SubItems.Add(esercizio);
                                item.SubItems.Add(weightUsed.ToString("F1")); 
                                item.SubItems.Add(repsCompleted.ToString());

                                listViewHistory.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dello storico: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateScheda()
        {
            string title = schedatitle.Text.Trim();
            string description = descritionscheda.Text.Trim();
            List<int> selectedExercises = GetSelectedExercises();
            int userId = Program.CurrentUserId;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) || selectedExercises.Count == 0)
            {
                MessageBox.Show("Tutti i campi sono obbligatori!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {

                            string insertSchedaQuery = "INSERT INTO scheda (id_utente, titolo, descrizione) VALUES (@idUtente, @titolo, @descrizione)";
                            long schedaId;

                            using (MySqlCommand cmd = new MySqlCommand(insertSchedaQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@idUtente", userId);
                                cmd.Parameters.AddWithValue("@titolo", title);
                                cmd.Parameters.AddWithValue("@descrizione", description);
                                cmd.ExecuteNonQuery();
                                schedaId = cmd.LastInsertedId;
                            }


                            string insertCaricoQuery = "INSERT INTO carico (id_scheda, id_esercizio, carico_iniziale) VALUES (@idScheda, @idEsercizio, @caricoIniziale)";

                            using (MySqlCommand cmd = new MySqlCommand(insertCaricoQuery, conn, transaction))
                            {
                                cmd.Parameters.Add("@idScheda", MySqlDbType.Int64);
                                cmd.Parameters.Add("@idEsercizio", MySqlDbType.Int32);
                                cmd.Parameters.Add("@caricoIniziale", MySqlDbType.Double);

                                foreach (int exerciseId in selectedExercises)
                                {
                                    cmd.Parameters["@idScheda"].Value = schedaId;
                                    cmd.Parameters["@idEsercizio"].Value = exerciseId;
                                    cmd.Parameters["@caricoIniziale"].Value = 0.0;
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Scheda salvata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Errore durante la transazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
