using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Generators;
using app_allenamenti;
using MySql.Data.MySqlClient;


namespace app_allenamenti_.Forms
{
    public partial class Login_register : Form
    {
        public Login_register()
        {
            InitializeComponent();
            comboBox1.Items.Add("Standard");
            comboBox1.Items.Add("Premium");
            comboBox1.SelectedIndex = 0;   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordreg_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Register handler
        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = Usernamereg.Text.Trim();
            string password = passwordreg.Text.Trim();
            bool isPremium = comboBox1.SelectedItem.ToString() == "Premium";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Compila tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                    
                    string query = "INSERT INTO utente (username, password, premium) VALUES (@username, @password, @premium)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@premium", isPremium ? 1 : 0);

                       
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registrazione completata!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Errore durante la registrazione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la registrazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            Usernamereg.Clear();
            passwordreg.Clear();
            comboBox1.SelectedIndex = 0;
        }


        //Login handler
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernamelogin.Text.Trim();
            string password = passwordlogin.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Inserisci username e password!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    
                    string query = "SELECT id_utente, password FROM utente WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                int userId = reader.GetInt32("id_utente");
                                string hashedPassword = reader.GetString("password");

                                
                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    MessageBox.Show("Login effettuato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    
                                    Program.CurrentUserId = userId;
                                    var dashboard = new DashboardForm();
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username o password non validi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username o password non validi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il login: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}




