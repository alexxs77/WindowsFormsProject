namespace Proiect
{
    partial class FormAngajat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grpboxfunctionalitati = new GroupBox();
            btnStatistica = new Button();
            btnIesire = new Button();
            btnContulMeu = new Button();
            btnGesProgramari = new Button();
            btnGesUtilizatori = new Button();
            panelCont = new Panel();
            label20 = new Label();
            panelEmail = new Panel();
            btnModificaEmail = new Button();
            txtEmailNou = new TextBox();
            txtEmailVechi = new TextBox();
            label14 = new Label();
            label15 = new Label();
            panelContParola = new Panel();
            btnModificaParola = new Button();
            txtParolaNoua = new TextBox();
            txtParolaVeche = new TextBox();
            label18 = new Label();
            label19 = new Label();
            panelContUsername = new Panel();
            btnModificaUsername = new Button();
            txtContUsernameNou = new TextBox();
            txtContUsernameVechi = new TextBox();
            label16 = new Label();
            label17 = new Label();
            groupBox1 = new GroupBox();
            txtDetaliiEmail = new TextBox();
            txtDetaliiParola = new TextBox();
            txtDetaliiUsername = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtDetaliiNume = new TextBox();
            label10 = new Label();
            panelPacienti = new Panel();
            label2 = new Label();
            btnStergerePacienti = new Button();
            dgvUtilizatori = new DataGridView();
            panelProgramari = new Panel();
            label5 = new Label();
            cmbsortareprog = new ComboBox();
            btnResetProg = new Button();
            btnCautareProg = new Button();
            cmbfiltruprog = new ComboBox();
            txtdenumireprog = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            Programari = new Label();
            btnAdaugaProgramare = new Button();
            btnModificaProgramare = new Button();
            btnStergeProgramare = new Button();
            dgvPlati = new DataGridView();
            dgvProgramari = new DataGridView();
            panelStatistica = new Panel();
            listBoxLoggari = new ListBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grpboxfunctionalitati.SuspendLayout();
            panelCont.SuspendLayout();
            panelEmail.SuspendLayout();
            panelContParola.SuspendLayout();
            panelContUsername.SuspendLayout();
            groupBox1.SuspendLayout();
            panelPacienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilizatori).BeginInit();
            panelProgramari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProgramari).BeginInit();
            panelStatistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // grpboxfunctionalitati
            // 
            grpboxfunctionalitati.Controls.Add(btnStatistica);
            grpboxfunctionalitati.Controls.Add(btnIesire);
            grpboxfunctionalitati.Controls.Add(btnContulMeu);
            grpboxfunctionalitati.Controls.Add(btnGesProgramari);
            grpboxfunctionalitati.Controls.Add(btnGesUtilizatori);
            grpboxfunctionalitati.Location = new Point(2, -1);
            grpboxfunctionalitati.Margin = new Padding(4, 5, 4, 5);
            grpboxfunctionalitati.Name = "grpboxfunctionalitati";
            grpboxfunctionalitati.Padding = new Padding(4, 5, 4, 5);
            grpboxfunctionalitati.Size = new Size(1573, 99);
            grpboxfunctionalitati.TabIndex = 1;
            grpboxfunctionalitati.TabStop = false;
            grpboxfunctionalitati.Text = "Functionalitati";
            // 
            // btnStatistica
            // 
            btnStatistica.FlatStyle = FlatStyle.Flat;
            btnStatistica.Location = new Point(439, 32);
            btnStatistica.Margin = new Padding(4, 5, 4, 5);
            btnStatistica.Name = "btnStatistica";
            btnStatistica.Size = new Size(243, 62);
            btnStatistica.TabIndex = 7;
            btnStatistica.Text = "Statistica";
            btnStatistica.UseVisualStyleBackColor = true;
            btnStatistica.Click += btnStatistica_Click;
            // 
            // btnIesire
            // 
            btnIesire.BackColor = Color.Red;
            btnIesire.Location = new Point(1339, 32);
            btnIesire.Margin = new Padding(4, 5, 4, 5);
            btnIesire.Name = "btnIesire";
            btnIesire.Size = new Size(234, 62);
            btnIesire.TabIndex = 2;
            btnIesire.Text = "Logout";
            btnIesire.UseVisualStyleBackColor = false;
            btnIesire.Click += btnIesire_Click;
            // 
            // btnContulMeu
            // 
            btnContulMeu.FlatStyle = FlatStyle.Flat;
            btnContulMeu.Location = new Point(1120, 32);
            btnContulMeu.Margin = new Padding(4, 5, 4, 5);
            btnContulMeu.Name = "btnContulMeu";
            btnContulMeu.Size = new Size(219, 62);
            btnContulMeu.TabIndex = 6;
            btnContulMeu.Text = "Contul meu";
            btnContulMeu.UseVisualStyleBackColor = true;
            btnContulMeu.Click += btnContulMeu_Click;
            // 
            // btnGesProgramari
            // 
            btnGesProgramari.FlatStyle = FlatStyle.Flat;
            btnGesProgramari.Location = new Point(206, 32);
            btnGesProgramari.Margin = new Padding(4, 5, 4, 5);
            btnGesProgramari.Name = "btnGesProgramari";
            btnGesProgramari.Size = new Size(232, 62);
            btnGesProgramari.TabIndex = 5;
            btnGesProgramari.Text = "Gestiune Programari";
            btnGesProgramari.UseVisualStyleBackColor = true;
            btnGesProgramari.Click += btnGesProgramari_Click;
            // 
            // btnGesUtilizatori
            // 
            btnGesUtilizatori.FlatStyle = FlatStyle.Flat;
            btnGesUtilizatori.Location = new Point(0, 32);
            btnGesUtilizatori.Margin = new Padding(4, 5, 4, 5);
            btnGesUtilizatori.Name = "btnGesUtilizatori";
            btnGesUtilizatori.Size = new Size(210, 62);
            btnGesUtilizatori.TabIndex = 1;
            btnGesUtilizatori.Text = "Gestiune Pacienti";
            btnGesUtilizatori.UseVisualStyleBackColor = true;
            btnGesUtilizatori.Click += btnGesUtilizatori_Click;
            // 
            // panelCont
            // 
            panelCont.Controls.Add(label20);
            panelCont.Controls.Add(panelEmail);
            panelCont.Controls.Add(panelContParola);
            panelCont.Controls.Add(panelContUsername);
            panelCont.Controls.Add(groupBox1);
            panelCont.Location = new Point(51, 124);
            panelCont.Name = "panelCont";
            panelCont.Size = new Size(1409, 1007);
            panelCont.TabIndex = 9;
            panelCont.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(710, 105);
            label20.Name = "label20";
            label20.Size = new Size(450, 64);
            label20.TabIndex = 11;
            label20.Text = "*Nota: Pentru a schimba anumite date\r\n apasa pe casuta dorita";
            // 
            // panelEmail
            // 
            panelEmail.Controls.Add(btnModificaEmail);
            panelEmail.Controls.Add(txtEmailNou);
            panelEmail.Controls.Add(txtEmailVechi);
            panelEmail.Controls.Add(label14);
            panelEmail.Controls.Add(label15);
            panelEmail.Location = new Point(109, 372);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(792, 343);
            panelEmail.TabIndex = 10;
            panelEmail.Visible = false;
            // 
            // btnModificaEmail
            // 
            btnModificaEmail.Location = new Point(219, 224);
            btnModificaEmail.Name = "btnModificaEmail";
            btnModificaEmail.Size = new Size(231, 62);
            btnModificaEmail.TabIndex = 9;
            btnModificaEmail.Text = "Modifica";
            btnModificaEmail.UseVisualStyleBackColor = true;
            btnModificaEmail.Click += btnModificaEmail_Click;
            // 
            // txtEmailNou
            // 
            txtEmailNou.Location = new Point(210, 144);
            txtEmailNou.Name = "txtEmailNou";
            txtEmailNou.Size = new Size(287, 31);
            txtEmailNou.TabIndex = 8;
            // 
            // txtEmailVechi
            // 
            txtEmailVechi.Location = new Point(210, 76);
            txtEmailVechi.Name = "txtEmailVechi";
            txtEmailVechi.Size = new Size(287, 31);
            txtEmailVechi.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(68, 142);
            label14.Name = "label14";
            label14.Size = new Size(90, 25);
            label14.TabIndex = 6;
            label14.Text = "Email nou";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(68, 76);
            label15.Name = "label15";
            label15.Size = new Size(99, 25);
            label15.TabIndex = 5;
            label15.Text = "Email vechi";
            // 
            // panelContParola
            // 
            panelContParola.Controls.Add(btnModificaParola);
            panelContParola.Controls.Add(txtParolaNoua);
            panelContParola.Controls.Add(txtParolaVeche);
            panelContParola.Controls.Add(label18);
            panelContParola.Controls.Add(label19);
            panelContParola.Location = new Point(123, 369);
            panelContParola.Name = "panelContParola";
            panelContParola.Size = new Size(754, 343);
            panelContParola.TabIndex = 3;
            panelContParola.Visible = false;
            // 
            // btnModificaParola
            // 
            btnModificaParola.Location = new Point(219, 224);
            btnModificaParola.Name = "btnModificaParola";
            btnModificaParola.Size = new Size(231, 62);
            btnModificaParola.TabIndex = 9;
            btnModificaParola.Text = "Modifica";
            btnModificaParola.UseVisualStyleBackColor = true;
            btnModificaParola.Click += btnModificaParola_Click;
            // 
            // txtParolaNoua
            // 
            txtParolaNoua.Location = new Point(210, 144);
            txtParolaNoua.Name = "txtParolaNoua";
            txtParolaNoua.Size = new Size(287, 31);
            txtParolaNoua.TabIndex = 8;
            // 
            // txtParolaVeche
            // 
            txtParolaVeche.Location = new Point(210, 76);
            txtParolaVeche.Name = "txtParolaVeche";
            txtParolaVeche.Size = new Size(287, 31);
            txtParolaVeche.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(68, 142);
            label18.Name = "label18";
            label18.Size = new Size(105, 25);
            label18.TabIndex = 6;
            label18.Text = "Parola noua";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(68, 76);
            label19.Name = "label19";
            label19.Size = new Size(110, 25);
            label19.TabIndex = 5;
            label19.Text = "Parola veche";
            // 
            // panelContUsername
            // 
            panelContUsername.Controls.Add(btnModificaUsername);
            panelContUsername.Controls.Add(txtContUsernameNou);
            panelContUsername.Controls.Add(txtContUsernameVechi);
            panelContUsername.Controls.Add(label16);
            panelContUsername.Controls.Add(label17);
            panelContUsername.Location = new Point(136, 369);
            panelContUsername.Name = "panelContUsername";
            panelContUsername.Size = new Size(732, 343);
            panelContUsername.TabIndex = 2;
            panelContUsername.Visible = false;
            // 
            // btnModificaUsername
            // 
            btnModificaUsername.Location = new Point(219, 224);
            btnModificaUsername.Name = "btnModificaUsername";
            btnModificaUsername.Size = new Size(231, 62);
            btnModificaUsername.TabIndex = 9;
            btnModificaUsername.Text = "Modifica";
            btnModificaUsername.UseVisualStyleBackColor = true;
            btnModificaUsername.Click += btnModificaUsername_Click;
            // 
            // txtContUsernameNou
            // 
            txtContUsernameNou.Location = new Point(210, 144);
            txtContUsernameNou.Name = "txtContUsernameNou";
            txtContUsernameNou.Size = new Size(287, 31);
            txtContUsernameNou.TabIndex = 8;
            // 
            // txtContUsernameVechi
            // 
            txtContUsernameVechi.Location = new Point(210, 76);
            txtContUsernameVechi.Name = "txtContUsernameVechi";
            txtContUsernameVechi.Size = new Size(287, 31);
            txtContUsernameVechi.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(68, 142);
            label16.Name = "label16";
            label16.Size = new Size(130, 25);
            label16.TabIndex = 6;
            label16.Text = "Username Nou";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(68, 76);
            label17.Name = "label17";
            label17.Size = new Size(136, 25);
            label17.TabIndex = 5;
            label17.Text = "Username vechi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDetaliiEmail);
            groupBox1.Controls.Add(txtDetaliiParola);
            groupBox1.Controls.Add(txtDetaliiUsername);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDetaliiNume);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(15, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 326);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalii Cont";
            // 
            // txtDetaliiEmail
            // 
            txtDetaliiEmail.Location = new Point(133, 179);
            txtDetaliiEmail.Name = "txtDetaliiEmail";
            txtDetaliiEmail.PasswordChar = '*';
            txtDetaliiEmail.ReadOnly = true;
            txtDetaliiEmail.Size = new Size(287, 31);
            txtDetaliiEmail.TabIndex = 7;
            txtDetaliiEmail.Click += txtDetaliiEmail_Click;
            txtDetaliiEmail.MouseEnter += txtDetaliiEmail_MouseEnter;
            txtDetaliiEmail.MouseLeave += txtDetaliiEmail_MouseLeave;
            // 
            // txtDetaliiParola
            // 
            txtDetaliiParola.Location = new Point(133, 133);
            txtDetaliiParola.Name = "txtDetaliiParola";
            txtDetaliiParola.PasswordChar = '*';
            txtDetaliiParola.ReadOnly = true;
            txtDetaliiParola.Size = new Size(287, 31);
            txtDetaliiParola.TabIndex = 6;
            txtDetaliiParola.Click += txtDetaliiParola_Click;
            // 
            // txtDetaliiUsername
            // 
            txtDetaliiUsername.Location = new Point(133, 92);
            txtDetaliiUsername.Name = "txtDetaliiUsername";
            txtDetaliiUsername.ReadOnly = true;
            txtDetaliiUsername.Size = new Size(287, 31);
            txtDetaliiUsername.TabIndex = 5;
            txtDetaliiUsername.Click += txtDetaliiUsername_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(47, 48);
            label13.Name = "label13";
            label13.Size = new Size(60, 25);
            label13.TabIndex = 4;
            label13.Text = "Nume";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 179);
            label12.Name = "label12";
            label12.Size = new Size(54, 25);
            label12.TabIndex = 3;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 136);
            label11.Name = "label11";
            label11.Size = new Size(60, 25);
            label11.TabIndex = 2;
            label11.Text = "Parola";
            // 
            // txtDetaliiNume
            // 
            txtDetaliiNume.Location = new Point(133, 48);
            txtDetaliiNume.Name = "txtDetaliiNume";
            txtDetaliiNume.ReadOnly = true;
            txtDetaliiNume.Size = new Size(287, 31);
            txtDetaliiNume.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 95);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 0;
            label10.Text = "Username";
            // 
            // panelPacienti
            // 
            panelPacienti.Controls.Add(label2);
            panelPacienti.Controls.Add(btnStergerePacienti);
            panelPacienti.Controls.Add(dgvUtilizatori);
            panelPacienti.Location = new Point(44, 124);
            panelPacienti.Name = "panelPacienti";
            panelPacienti.Size = new Size(1524, 739);
            panelPacienti.TabIndex = 10;
            panelPacienti.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 13);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 12;
            label2.Text = "Date Pacienti";
            // 
            // btnStergerePacienti
            // 
            btnStergerePacienti.Location = new Point(1090, 559);
            btnStergerePacienti.Name = "btnStergerePacienti";
            btnStergerePacienti.Size = new Size(337, 69);
            btnStergerePacienti.TabIndex = 1;
            btnStergerePacienti.Text = "Sterge";
            btnStergerePacienti.UseVisualStyleBackColor = true;
            btnStergerePacienti.Click += btnStergerePacienti_Click;
            // 
            // dgvUtilizatori
            // 
            dgvUtilizatori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilizatori.Location = new Point(21, 59);
            dgvUtilizatori.Name = "dgvUtilizatori";
            dgvUtilizatori.RowHeadersWidth = 62;
            dgvUtilizatori.Size = new Size(1474, 368);
            dgvUtilizatori.TabIndex = 0;
            // 
            // panelProgramari
            // 
            panelProgramari.Controls.Add(label5);
            panelProgramari.Controls.Add(cmbsortareprog);
            panelProgramari.Controls.Add(btnResetProg);
            panelProgramari.Controls.Add(btnCautareProg);
            panelProgramari.Controls.Add(cmbfiltruprog);
            panelProgramari.Controls.Add(txtdenumireprog);
            panelProgramari.Controls.Add(label4);
            panelProgramari.Controls.Add(label3);
            panelProgramari.Controls.Add(label1);
            panelProgramari.Controls.Add(Programari);
            panelProgramari.Controls.Add(btnAdaugaProgramare);
            panelProgramari.Controls.Add(btnModificaProgramare);
            panelProgramari.Controls.Add(btnStergeProgramare);
            panelProgramari.Controls.Add(dgvPlati);
            panelProgramari.Controls.Add(dgvProgramari);
            panelProgramari.Location = new Point(29, 124);
            panelProgramari.Name = "panelProgramari";
            panelProgramari.Size = new Size(1826, 751);
            panelProgramari.TabIndex = 11;
            panelProgramari.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 397);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 14;
            label5.Text = "Sortare:";
            // 
            // cmbsortareprog
            // 
            cmbsortareprog.FormattingEnabled = true;
            cmbsortareprog.Items.AddRange(new object[] { "DataProgramareCrescator", "DataProgramareDescrescator", "PacientCrescator", "PacientDescrescator", "PretCrescator", "PretDescrescator" });
            cmbsortareprog.Location = new Point(576, 394);
            cmbsortareprog.Name = "cmbsortareprog";
            cmbsortareprog.Size = new Size(314, 33);
            cmbsortareprog.TabIndex = 13;
            cmbsortareprog.SelectedIndexChanged += cmbsortareprog_SelectedIndexChanged;
            // 
            // btnResetProg
            // 
            btnResetProg.Location = new Point(274, 473);
            btnResetProg.Name = "btnResetProg";
            btnResetProg.Size = new Size(114, 34);
            btnResetProg.TabIndex = 12;
            btnResetProg.Text = "Reset";
            btnResetProg.UseVisualStyleBackColor = true;
            btnResetProg.Click += btnResetProg_Click;
            // 
            // btnCautareProg
            // 
            btnCautareProg.Location = new Point(131, 474);
            btnCautareProg.Name = "btnCautareProg";
            btnCautareProg.Size = new Size(111, 34);
            btnCautareProg.TabIndex = 11;
            btnCautareProg.Text = "Cautare";
            btnCautareProg.UseVisualStyleBackColor = true;
            btnCautareProg.Click += btnCautareProg_Click;
            // 
            // cmbfiltruprog
            // 
            cmbfiltruprog.FormattingEnabled = true;
            cmbfiltruprog.Items.AddRange(new object[] { "Pacient", "Serviciu", "Status", "Pret" });
            cmbfiltruprog.Location = new Point(131, 406);
            cmbfiltruprog.Name = "cmbfiltruprog";
            cmbfiltruprog.Size = new Size(257, 33);
            cmbfiltruprog.TabIndex = 10;
            // 
            // txtdenumireprog
            // 
            txtdenumireprog.Location = new Point(131, 357);
            txtdenumireprog.Name = "txtdenumireprog";
            txtdenumireprog.Size = new Size(257, 31);
            txtdenumireprog.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 417);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 8;
            label4.Text = "Filtru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 363);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 7;
            label3.Text = "Denumire:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(957, 16);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 6;
            label1.Text = "Date Plata";
            // 
            // Programari
            // 
            Programari.AutoSize = true;
            Programari.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Programari.Location = new Point(39, 17);
            Programari.Name = "Programari";
            Programari.Size = new Size(204, 32);
            Programari.TabIndex = 5;
            Programari.Text = "Date Programari";
            // 
            // btnAdaugaProgramare
            // 
            btnAdaugaProgramare.Location = new Point(15, 657);
            btnAdaugaProgramare.Name = "btnAdaugaProgramare";
            btnAdaugaProgramare.Size = new Size(228, 52);
            btnAdaugaProgramare.TabIndex = 4;
            btnAdaugaProgramare.Text = "Adauga";
            btnAdaugaProgramare.UseVisualStyleBackColor = true;
            btnAdaugaProgramare.Click += btnAdaugaProgramare_Click;
            // 
            // btnModificaProgramare
            // 
            btnModificaProgramare.Location = new Point(330, 660);
            btnModificaProgramare.Name = "btnModificaProgramare";
            btnModificaProgramare.Size = new Size(228, 52);
            btnModificaProgramare.TabIndex = 3;
            btnModificaProgramare.Text = "Modifica";
            btnModificaProgramare.UseVisualStyleBackColor = true;
            btnModificaProgramare.Click += btnModificaProgramare_Click;
            // 
            // btnStergeProgramare
            // 
            btnStergeProgramare.Location = new Point(651, 657);
            btnStergeProgramare.Name = "btnStergeProgramare";
            btnStergeProgramare.Size = new Size(228, 52);
            btnStergeProgramare.TabIndex = 2;
            btnStergeProgramare.Text = "Sterge";
            btnStergeProgramare.UseVisualStyleBackColor = true;
            btnStergeProgramare.Click += btnStergeProgramare_Click;
            // 
            // dgvPlati
            // 
            dgvPlati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlati.Location = new Point(957, 65);
            dgvPlati.Name = "dgvPlati";
            dgvPlati.RowHeadersWidth = 62;
            dgvPlati.Size = new Size(578, 265);
            dgvPlati.TabIndex = 1;
            // 
            // dgvProgramari
            // 
            dgvProgramari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProgramari.Location = new Point(24, 65);
            dgvProgramari.Name = "dgvProgramari";
            dgvProgramari.RowHeadersWidth = 62;
            dgvProgramari.Size = new Size(913, 265);
            dgvProgramari.TabIndex = 0;
            dgvProgramari.SelectionChanged += dgvProgramari_SelectionChanged;
            // 
            // panelStatistica
            // 
            panelStatistica.Controls.Add(listBoxLoggari);
            panelStatistica.Controls.Add(chart1);
            panelStatistica.Location = new Point(2, 106);
            panelStatistica.Name = "panelStatistica";
            panelStatistica.Size = new Size(1939, 1005);
            panelStatistica.TabIndex = 12;
            panelStatistica.Visible = false;
            // 
            // listBoxLoggari
            // 
            listBoxLoggari.BackColor = Color.Gray;
            listBoxLoggari.FormattingEnabled = true;
            listBoxLoggari.Location = new Point(35, 415);
            listBoxLoggari.Name = "listBoxLoggari";
            listBoxLoggari.ScrollAlwaysVisible = true;
            listBoxLoggari.Size = new Size(1281, 329);
            listBoxLoggari.TabIndex = 2;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Gray;
            chart1.BorderlineColor = Color.DimGray;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(377, 18);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(560, 381);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // FormAngajat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1574, 870);
            Controls.Add(panelStatistica);
            Controls.Add(panelProgramari);
            Controls.Add(panelPacienti);
            Controls.Add(panelCont);
            Controls.Add(grpboxfunctionalitati);
            Name = "FormAngajat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAngajat";
            Load += FormAngajat_Load;
            grpboxfunctionalitati.ResumeLayout(false);
            panelCont.ResumeLayout(false);
            panelCont.PerformLayout();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            panelContParola.ResumeLayout(false);
            panelContParola.PerformLayout();
            panelContUsername.ResumeLayout(false);
            panelContUsername.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelPacienti.ResumeLayout(false);
            panelPacienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilizatori).EndInit();
            panelProgramari.ResumeLayout(false);
            panelProgramari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlati).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProgramari).EndInit();
            panelStatistica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxfunctionalitati;
        private Button btnStatistica;
        private Button btnContulMeu;
        private Button btnGesProgramari;
        private Button btnGesUtilizatori;
        private Button btnIesire;
        private Panel panelCont;
        private Label label20;
        private Panel panelEmail;
        private Button btnModificaEmail;
        private TextBox txtEmailNou;
        private TextBox txtEmailVechi;
        private Label label14;
        private Label label15;
        private Panel panelContParola;
        private Button btnModificaParola;
        private TextBox txtParolaNoua;
        private TextBox txtParolaVeche;
        private Label label18;
        private Label label19;
        private Panel panelContUsername;
        private Button btnModificaUsername;
        private TextBox txtContUsernameNou;
        private TextBox txtContUsernameVechi;
        private Label label16;
        private Label label17;
        private GroupBox groupBox1;
        private TextBox txtDetaliiEmail;
        private TextBox txtDetaliiParola;
        private TextBox txtDetaliiUsername;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtDetaliiNume;
        private Label label10;
        private Panel panelPacienti;
        private DataGridView dgvUtilizatori;
        private Button btnStergerePacienti;
        private Panel panelProgramari;
        private DataGridView dgvPlati;
        private DataGridView dgvProgramari;
        private Button btnStergeProgramare;
        private Button btnAdaugaProgramare;
        private Button btnModificaProgramare;
        private Label label1;
        private Label Programari;
        private Label label2;
        private Label label3;
        private TextBox txtdenumireprog;
        private Label label4;
        private ComboBox cmbsortareprog;
        private Button btnResetProg;
        private Button btnCautareProg;
        private ComboBox cmbfiltruprog;
        private Label label5;
        private Panel panelStatistica;
        private ListBox listBoxLoggari;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}