namespace app_allenamenti_.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.schedatitle = new System.Windows.Forms.TextBox();
            this.descritionscheda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newschedaesercizi = new System.Windows.Forms.ListView();
            this.createschedabtn = new System.Windows.Forms.Button();
            this.listviewschede = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.textdescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.typecombo = new System.Windows.Forms.ComboBox();
            this.newdescriptionexercixes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.descriptioncombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.upseries = new System.Windows.Forms.NumericUpDown();
            this.uprepetitions = new System.Windows.Forms.NumericUpDown();
            this.Addexercixes = new System.Windows.Forms.Button();
            this.comboBoxSchede = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxEsercizi = new System.Windows.Forms.ComboBox();
            this.dateTimePickerExecutionDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxWeightUsed = new System.Windows.Forms.TextBox();
            this.textBoxRepCompleted = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.registrabtn = new System.Windows.Forms.Button();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upseries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprepetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Le tue schede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1094, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1898, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.registrabtn);
            this.tabPage3.Controls.Add(this.textBoxRepCompleted);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.textBoxWeightUsed);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.dateTimePickerExecutionDate);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.comboBoxEsercizi);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.comboBoxSchede);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(998, 841);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registra esercizio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Addexercixes);
            this.tabPage2.Controls.Add(this.uprepetitions);
            this.tabPage2.Controls.Add(this.upseries);
            this.tabPage2.Controls.Add(this.descriptioncombo);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.newdescriptionexercixes);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.typecombo);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textdescription);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.nametext);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 841);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aggiungi esercizio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(37, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 880);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createschedabtn);
            this.tabPage1.Controls.Add(this.newschedaesercizi);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.descritionscheda);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.schedatitle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 841);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuova scheda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(1069, 132);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(817, 880);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listviewschede);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(809, 841);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Lista schede";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listViewHistory);
            this.tabPage5.Location = new System.Drawing.Point(4, 35);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(809, 841);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Storico";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(1696, 46);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(185, 54);
            this.Logoutbtn.TabIndex = 9;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Titolo della scheda:";
            // 
            // schedatitle
            // 
            this.schedatitle.Location = new System.Drawing.Point(61, 78);
            this.schedatitle.Name = "schedatitle";
            this.schedatitle.Size = new System.Drawing.Size(614, 32);
            this.schedatitle.TabIndex = 1;
            // 
            // descritionscheda
            // 
            this.descritionscheda.Location = new System.Drawing.Point(61, 178);
            this.descritionscheda.Multiline = true;
            this.descritionscheda.Name = "descritionscheda";
            this.descritionscheda.Size = new System.Drawing.Size(614, 242);
            this.descritionscheda.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrizione:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selezione esercizi:";
            // 
            // newschedaesercizi
            // 
            this.newschedaesercizi.HideSelection = false;
            this.newschedaesercizi.Location = new System.Drawing.Point(61, 517);
            this.newschedaesercizi.Name = "newschedaesercizi";
            this.newschedaesercizi.Size = new System.Drawing.Size(614, 300);
            this.newschedaesercizi.TabIndex = 5;
            this.newschedaesercizi.UseCompatibleStateImageBehavior = false;
            this.newschedaesercizi.View = System.Windows.Forms.View.List;
            // 
            // createschedabtn
            // 
            this.createschedabtn.Location = new System.Drawing.Point(707, 517);
            this.createschedabtn.Name = "createschedabtn";
            this.createschedabtn.Size = new System.Drawing.Size(271, 300);
            this.createschedabtn.TabIndex = 6;
            this.createschedabtn.Text = "Crea scheda";
            this.createschedabtn.UseVisualStyleBackColor = true;
            this.createschedabtn.Click += new System.EventHandler(this.createschedabtn_Click);
            // 
            // listviewschede
            // 
            this.listviewschede.HideSelection = false;
            this.listviewschede.Location = new System.Drawing.Point(4, 4);
            this.listviewschede.Name = "listviewschede";
            this.listviewschede.Size = new System.Drawing.Size(799, 831);
            this.listviewschede.TabIndex = 0;
            this.listviewschede.UseCompatibleStateImageBehavior = false;
            this.listviewschede.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome esercizio:";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(220, 41);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(271, 32);
            this.nametext.TabIndex = 1;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // textdescription
            // 
            this.textdescription.Location = new System.Drawing.Point(220, 104);
            this.textdescription.Multiline = true;
            this.textdescription.Name = "textdescription";
            this.textdescription.Size = new System.Drawing.Size(706, 204);
            this.textdescription.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descrizione:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Serie predefinite:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ripetizioni predefinite:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tipo di esercizio:";
            // 
            // typecombo
            // 
            this.typecombo.FormattingEnabled = true;
            this.typecombo.Location = new System.Drawing.Point(277, 479);
            this.typecombo.Name = "typecombo";
            this.typecombo.Size = new System.Drawing.Size(271, 34);
            this.typecombo.TabIndex = 10;
            // 
            // newdescriptionexercixes
            // 
            this.newdescriptionexercixes.Location = new System.Drawing.Point(50, 594);
            this.newdescriptionexercixes.Multiline = true;
            this.newdescriptionexercixes.Name = "newdescriptionexercixes";
            this.newdescriptionexercixes.Size = new System.Drawing.Size(523, 204);
            this.newdescriptionexercixes.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descrizione dettagliata:";
            // 
            // descriptioncombo
            // 
            this.descriptioncombo.FormattingEnabled = true;
            this.descriptioncombo.Location = new System.Drawing.Point(655, 542);
            this.descriptioncombo.Name = "descriptioncombo";
            this.descriptioncombo.Size = new System.Drawing.Size(271, 34);
            this.descriptioncombo.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 26);
            this.label12.TabIndex = 13;
            this.label12.Text = "Descrizione:";
            // 
            // upseries
            // 
            this.upseries.Location = new System.Drawing.Point(277, 356);
            this.upseries.Name = "upseries";
            this.upseries.Size = new System.Drawing.Size(271, 32);
            this.upseries.TabIndex = 15;
            // 
            // uprepetitions
            // 
            this.uprepetitions.Location = new System.Drawing.Point(277, 415);
            this.uprepetitions.Name = "uprepetitions";
            this.uprepetitions.Size = new System.Drawing.Size(271, 32);
            this.uprepetitions.TabIndex = 16;
            // 
            // Addexercixes
            // 
            this.Addexercixes.Location = new System.Drawing.Point(655, 599);
            this.Addexercixes.Name = "Addexercixes";
            this.Addexercixes.Size = new System.Drawing.Size(271, 211);
            this.Addexercixes.TabIndex = 17;
            this.Addexercixes.Text = "Aggiungi";
            this.Addexercixes.UseVisualStyleBackColor = true;
            this.Addexercixes.Click += new System.EventHandler(this.Addexercixes_Click);
            // 
            // comboBoxSchede
            // 
            this.comboBoxSchede.FormattingEnabled = true;
            this.comboBoxSchede.Location = new System.Drawing.Point(222, 17);
            this.comboBoxSchede.Name = "comboBoxSchede";
            this.comboBoxSchede.Size = new System.Drawing.Size(437, 34);
            this.comboBoxSchede.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "Seleziona scheda:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 26);
            this.label14.TabIndex = 14;
            this.label14.Text = "Seleziona esercizio:";
            // 
            // comboBoxEsercizi
            // 
            this.comboBoxEsercizi.FormattingEnabled = true;
            this.comboBoxEsercizi.Location = new System.Drawing.Point(222, 86);
            this.comboBoxEsercizi.Name = "comboBoxEsercizi";
            this.comboBoxEsercizi.Size = new System.Drawing.Size(437, 34);
            this.comboBoxEsercizi.TabIndex = 13;
            // 
            // dateTimePickerExecutionDate
            // 
            this.dateTimePickerExecutionDate.Location = new System.Drawing.Point(222, 161);
            this.dateTimePickerExecutionDate.Name = "dateTimePickerExecutionDate";
            this.dateTimePickerExecutionDate.Size = new System.Drawing.Size(437, 32);
            this.dateTimePickerExecutionDate.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 26);
            this.label15.TabIndex = 16;
            this.label15.Text = "Data esecuzione:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 26);
            this.label16.TabIndex = 17;
            this.label16.Text = "Peso usato:";
            // 
            // textBoxWeightUsed
            // 
            this.textBoxWeightUsed.Location = new System.Drawing.Point(222, 264);
            this.textBoxWeightUsed.Name = "textBoxWeightUsed";
            this.textBoxWeightUsed.Size = new System.Drawing.Size(437, 32);
            this.textBoxWeightUsed.TabIndex = 18;
            // 
            // textBoxRepCompleted
            // 
            this.textBoxRepCompleted.Location = new System.Drawing.Point(222, 339);
            this.textBoxRepCompleted.Name = "textBoxRepCompleted";
            this.textBoxRepCompleted.Size = new System.Drawing.Size(437, 32);
            this.textBoxRepCompleted.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 26);
            this.label17.TabIndex = 19;
            this.label17.Text = "Ripetizioni eseguite:";
            // 
            // registrabtn
            // 
            this.registrabtn.Location = new System.Drawing.Point(222, 447);
            this.registrabtn.Name = "registrabtn";
            this.registrabtn.Size = new System.Drawing.Size(437, 115);
            this.registrabtn.TabIndex = 21;
            this.registrabtn.Text = "Registra esercizi";
            this.registrabtn.UseVisualStyleBackColor = true;
            this.registrabtn.Click += new System.EventHandler(this.registrabtn_Click);
            // 
            // listViewHistory
            // 
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(0, 0);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(813, 841);
            this.listViewHistory.TabIndex = 0;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.List;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upseries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprepetitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.TextBox descritionscheda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox schedatitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView newschedaesercizi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createschedabtn;
        private System.Windows.Forms.ListView listviewschede;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textdescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label label6;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox typecombo;
        private System.Windows.Forms.ComboBox descriptioncombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox newdescriptionexercixes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown uprepetitions;
        private System.Windows.Forms.NumericUpDown upseries;
        private System.Windows.Forms.Button Addexercixes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxEsercizi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxSchede;
        private System.Windows.Forms.Button registrabtn;
        private System.Windows.Forms.TextBox textBoxRepCompleted;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxWeightUsed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerExecutionDate;
        private System.Windows.Forms.ListView listViewHistory;
    }
}