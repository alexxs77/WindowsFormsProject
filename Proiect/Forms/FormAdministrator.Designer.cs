namespace Proiect
{
    partial class FormAdministrator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnModifica = new Button();
            btnSterge = new Button();
            panelUtilizatori = new Panel();
            btnAdauga = new Button();
            dgvUtilizatori = new DataGridView();
            panelServicii = new Panel();
            label2 = new Label();
            btnReset = new Button();
            btnCautare = new Button();
            label3 = new Label();
            cmbFiltruCautare = new ComboBox();
            txtCautare = new TextBox();
            cmbSortare = new ComboBox();
            label1 = new Label();
            btnStergeServicii = new Button();
            btnModificaServicii = new Button();
            btnAdaugaServicii = new Button();
            dgvServicii = new DataGridView();
            btnGesUtilizatori = new Button();
            btnIesire = new Button();
            btnGesServicii = new Button();
            grpboxfunctionalitati = new GroupBox();
            btnStatistica = new Button();
            btnContulMeu = new Button();
            btnGesProgramari = new Button();
            btnGesPlati = new Button();
            panelPlati = new Panel();
            label4 = new Label();
            btnResetPlati = new Button();
            btnCautarePlati = new Button();
            label5 = new Label();
            cmbFiltruPlati = new ComboBox();
            txtDenumirePlati = new TextBox();
            cmbSortarePlati = new ComboBox();
            label6 = new Label();
            btnStergePlati = new Button();
            btnModificaPlati = new Button();
            dgvPlati = new DataGridView();
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
            panelProgramari = new Panel();
            label7 = new Label();
            btnResetProg = new Button();
            btnCautareProg = new Button();
            label8 = new Label();
            cmbfiltruprog = new ComboBox();
            txtdenumireprog = new TextBox();
            cmbsortareprog = new ComboBox();
            label9 = new Label();
            btnStergeProgramari = new Button();
            btnAdaugaProgramari = new Button();
            btnModificaProgramari = new Button();
            dgvProgramari = new DataGridView();
            panelStatistica = new Panel();
            listBoxLoggari = new ListBox();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUtilizatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilizatori).BeginInit();
            panelServicii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicii).BeginInit();
            grpboxfunctionalitati.SuspendLayout();
            panelPlati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlati).BeginInit();
            panelCont.SuspendLayout();
            panelEmail.SuspendLayout();
            panelContParola.SuspendLayout();
            panelContUsername.SuspendLayout();
            groupBox1.SuspendLayout();
            panelProgramari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProgramari).BeginInit();
            panelStatistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(384, 827);
            btnModifica.Margin = new Padding(4, 5, 4, 5);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(246, 62);
            btnModifica.TabIndex = 3;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnSterge
            // 
            btnSterge.Location = new Point(719, 827);
            btnSterge.Margin = new Padding(4, 5, 4, 5);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(246, 62);
            btnSterge.TabIndex = 4;
            btnSterge.Text = "Sterge";
            btnSterge.UseVisualStyleBackColor = true;
            btnSterge.Click += btnSterge_Click;
            // 
            // panelUtilizatori
            // 
            panelUtilizatori.Controls.Add(btnSterge);
            panelUtilizatori.Controls.Add(btnModifica);
            panelUtilizatori.Controls.Add(btnAdauga);
            panelUtilizatori.Controls.Add(dgvUtilizatori);
            panelUtilizatori.Dock = DockStyle.Right;
            panelUtilizatori.Location = new Point(430, 0);
            panelUtilizatori.Margin = new Padding(4, 5, 4, 5);
            panelUtilizatori.Name = "panelUtilizatori";
            panelUtilizatori.Size = new Size(1053, 988);
            panelUtilizatori.TabIndex = 1;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(40, 827);
            btnAdauga.Margin = new Padding(4, 5, 4, 5);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(246, 62);
            btnAdauga.TabIndex = 2;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // dgvUtilizatori
            // 
            dgvUtilizatori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilizatori.Location = new Point(4, 0);
            dgvUtilizatori.Margin = new Padding(4, 5, 4, 5);
            dgvUtilizatori.Name = "dgvUtilizatori";
            dgvUtilizatori.RowHeadersWidth = 62;
            dgvUtilizatori.Size = new Size(1074, 765);
            dgvUtilizatori.TabIndex = 0;
            // 
            // panelServicii
            // 
            panelServicii.BorderStyle = BorderStyle.FixedSingle;
            panelServicii.Controls.Add(label2);
            panelServicii.Controls.Add(btnReset);
            panelServicii.Controls.Add(btnCautare);
            panelServicii.Controls.Add(label3);
            panelServicii.Controls.Add(cmbFiltruCautare);
            panelServicii.Controls.Add(txtCautare);
            panelServicii.Controls.Add(cmbSortare);
            panelServicii.Controls.Add(label1);
            panelServicii.Controls.Add(btnStergeServicii);
            panelServicii.Controls.Add(btnModificaServicii);
            panelServicii.Controls.Add(btnAdaugaServicii);
            panelServicii.Controls.Add(dgvServicii);
            panelServicii.Location = new Point(426, 3);
            panelServicii.Name = "panelServicii";
            panelServicii.Size = new Size(1054, 985);
            panelServicii.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 605);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 14;
            label2.Text = "Denumire:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(363, 697);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(87, 38);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCautare
            // 
            btnCautare.Location = new Point(206, 697);
            btnCautare.Margin = new Padding(4, 5, 4, 5);
            btnCautare.Name = "btnCautare";
            btnCautare.Size = new Size(87, 38);
            btnCautare.TabIndex = 12;
            btnCautare.Text = "Cautare";
            btnCautare.UseVisualStyleBackColor = true;
            btnCautare.Click += btnCautare_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 653);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 11;
            label3.Text = "Filtru de cautare:";
            // 
            // cmbFiltruCautare
            // 
            cmbFiltruCautare.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltruCautare.FormattingEnabled = true;
            cmbFiltruCautare.Items.AddRange(new object[] { "Denumire", "Descriere", "Pret" });
            cmbFiltruCautare.Location = new Point(206, 648);
            cmbFiltruCautare.Margin = new Padding(4, 5, 4, 5);
            cmbFiltruCautare.Name = "cmbFiltruCautare";
            cmbFiltruCautare.Size = new Size(243, 33);
            cmbFiltruCautare.TabIndex = 10;
            // 
            // txtCautare
            // 
            txtCautare.Location = new Point(206, 600);
            txtCautare.Margin = new Padding(4, 5, 4, 5);
            txtCautare.Name = "txtCautare";
            txtCautare.Size = new Size(243, 31);
            txtCautare.TabIndex = 8;
            // 
            // cmbSortare
            // 
            cmbSortare.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortare.FormattingEnabled = true;
            cmbSortare.Location = new Point(677, 600);
            cmbSortare.Margin = new Padding(4, 5, 4, 5);
            cmbSortare.Name = "cmbSortare";
            cmbSortare.Size = new Size(343, 33);
            cmbSortare.TabIndex = 7;
            cmbSortare.SelectedIndexChanged += cmbSortare_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 605);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 6;
            label1.Text = "Sortare:";
            // 
            // btnStergeServicii
            // 
            btnStergeServicii.Location = new Point(750, 827);
            btnStergeServicii.Margin = new Padding(4, 5, 4, 5);
            btnStergeServicii.Name = "btnStergeServicii";
            btnStergeServicii.Size = new Size(246, 62);
            btnStergeServicii.TabIndex = 5;
            btnStergeServicii.Text = "Sterge";
            btnStergeServicii.UseVisualStyleBackColor = true;
            btnStergeServicii.Click += btnStergeServicii_Click;
            // 
            // btnModificaServicii
            // 
            btnModificaServicii.Location = new Point(406, 827);
            btnModificaServicii.Margin = new Padding(4, 5, 4, 5);
            btnModificaServicii.Name = "btnModificaServicii";
            btnModificaServicii.Size = new Size(246, 62);
            btnModificaServicii.TabIndex = 4;
            btnModificaServicii.Text = "Modifica";
            btnModificaServicii.UseVisualStyleBackColor = true;
            btnModificaServicii.Click += btnModificaServicii_Click;
            // 
            // btnAdaugaServicii
            // 
            btnAdaugaServicii.Location = new Point(51, 827);
            btnAdaugaServicii.Margin = new Padding(4, 5, 4, 5);
            btnAdaugaServicii.Name = "btnAdaugaServicii";
            btnAdaugaServicii.Size = new Size(246, 62);
            btnAdaugaServicii.TabIndex = 3;
            btnAdaugaServicii.Text = "Adauga";
            btnAdaugaServicii.UseVisualStyleBackColor = true;
            btnAdaugaServicii.Click += btnAdaugaServicii_Click;
            // 
            // dgvServicii
            // 
            dgvServicii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicii.Location = new Point(9, 15);
            dgvServicii.Name = "dgvServicii";
            dgvServicii.RowHeadersWidth = 62;
            dgvServicii.Size = new Size(1033, 552);
            dgvServicii.TabIndex = 0;
            // 
            // btnGesUtilizatori
            // 
            btnGesUtilizatori.FlatStyle = FlatStyle.Flat;
            btnGesUtilizatori.Location = new Point(0, 37);
            btnGesUtilizatori.Margin = new Padding(4, 5, 4, 5);
            btnGesUtilizatori.Name = "btnGesUtilizatori";
            btnGesUtilizatori.Size = new Size(397, 62);
            btnGesUtilizatori.TabIndex = 1;
            btnGesUtilizatori.Text = "Gestiune Utilizatori";
            btnGesUtilizatori.UseVisualStyleBackColor = true;
            btnGesUtilizatori.Click += btnGesUtilizatori_Click;
            // 
            // btnIesire
            // 
            btnIesire.BackColor = Color.Red;
            btnIesire.Location = new Point(0, 928);
            btnIesire.Margin = new Padding(4, 5, 4, 5);
            btnIesire.Name = "btnIesire";
            btnIesire.Size = new Size(397, 53);
            btnIesire.TabIndex = 2;
            btnIesire.Text = "Logout";
            btnIesire.UseVisualStyleBackColor = false;
            btnIesire.Click += btnIesire_Click;
            // 
            // btnGesServicii
            // 
            btnGesServicii.FlatStyle = FlatStyle.Flat;
            btnGesServicii.Location = new Point(0, 93);
            btnGesServicii.Margin = new Padding(4, 5, 4, 5);
            btnGesServicii.Name = "btnGesServicii";
            btnGesServicii.Size = new Size(397, 62);
            btnGesServicii.TabIndex = 3;
            btnGesServicii.Text = "Gestiune Servicii";
            btnGesServicii.UseVisualStyleBackColor = true;
            btnGesServicii.Click += btnGesServicii_Click_1;
            // 
            // grpboxfunctionalitati
            // 
            grpboxfunctionalitati.Controls.Add(btnStatistica);
            grpboxfunctionalitati.Controls.Add(btnContulMeu);
            grpboxfunctionalitati.Controls.Add(btnGesProgramari);
            grpboxfunctionalitati.Controls.Add(btnGesPlati);
            grpboxfunctionalitati.Controls.Add(btnGesServicii);
            grpboxfunctionalitati.Controls.Add(btnIesire);
            grpboxfunctionalitati.Controls.Add(btnGesUtilizatori);
            grpboxfunctionalitati.Location = new Point(0, 2);
            grpboxfunctionalitati.Margin = new Padding(4, 5, 4, 5);
            grpboxfunctionalitati.Name = "grpboxfunctionalitati";
            grpboxfunctionalitati.Padding = new Padding(4, 5, 4, 5);
            grpboxfunctionalitati.Size = new Size(397, 983);
            grpboxfunctionalitati.TabIndex = 0;
            grpboxfunctionalitati.TabStop = false;
            grpboxfunctionalitati.Text = "Functionalitati";
            // 
            // btnStatistica
            // 
            btnStatistica.FlatStyle = FlatStyle.Flat;
            btnStatistica.Location = new Point(0, 270);
            btnStatistica.Margin = new Padding(4, 5, 4, 5);
            btnStatistica.Name = "btnStatistica";
            btnStatistica.Size = new Size(397, 62);
            btnStatistica.TabIndex = 7;
            btnStatistica.Text = "Statistica";
            btnStatistica.UseVisualStyleBackColor = true;
            btnStatistica.Click += btnStatistica_Click;
            // 
            // btnContulMeu
            // 
            btnContulMeu.FlatStyle = FlatStyle.Flat;
            btnContulMeu.Location = new Point(0, 872);
            btnContulMeu.Margin = new Padding(4, 5, 4, 5);
            btnContulMeu.Name = "btnContulMeu";
            btnContulMeu.Size = new Size(397, 62);
            btnContulMeu.TabIndex = 6;
            btnContulMeu.Text = "Contul meu";
            btnContulMeu.UseVisualStyleBackColor = true;
            btnContulMeu.Click += btnContulMeu_Click;
            // 
            // btnGesProgramari
            // 
            btnGesProgramari.FlatStyle = FlatStyle.Flat;
            btnGesProgramari.Location = new Point(0, 209);
            btnGesProgramari.Margin = new Padding(4, 5, 4, 5);
            btnGesProgramari.Name = "btnGesProgramari";
            btnGesProgramari.Size = new Size(397, 62);
            btnGesProgramari.TabIndex = 5;
            btnGesProgramari.Text = "Gestiune Programari";
            btnGesProgramari.UseVisualStyleBackColor = true;
            btnGesProgramari.Click += btnGesProgramari_Click;
            // 
            // btnGesPlati
            // 
            btnGesPlati.FlatStyle = FlatStyle.Flat;
            btnGesPlati.Location = new Point(0, 150);
            btnGesPlati.Margin = new Padding(4, 5, 4, 5);
            btnGesPlati.Name = "btnGesPlati";
            btnGesPlati.Size = new Size(397, 62);
            btnGesPlati.TabIndex = 4;
            btnGesPlati.Text = "Gestiune Plati";
            btnGesPlati.UseVisualStyleBackColor = true;
            btnGesPlati.Click += btnGesPlati_Click;
            // 
            // panelPlati
            // 
            panelPlati.Controls.Add(label4);
            panelPlati.Controls.Add(btnResetPlati);
            panelPlati.Controls.Add(btnCautarePlati);
            panelPlati.Controls.Add(label5);
            panelPlati.Controls.Add(cmbFiltruPlati);
            panelPlati.Controls.Add(txtDenumirePlati);
            panelPlati.Controls.Add(cmbSortarePlati);
            panelPlati.Controls.Add(label6);
            panelPlati.Controls.Add(btnStergePlati);
            panelPlati.Controls.Add(btnModificaPlati);
            panelPlati.Controls.Add(dgvPlati);
            panelPlati.Location = new Point(426, 0);
            panelPlati.Margin = new Padding(4, 5, 4, 5);
            panelPlati.Name = "panelPlati";
            panelPlati.Size = new Size(1077, 987);
            panelPlati.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 583);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 22;
            label4.Text = "Denumire:";
            // 
            // btnResetPlati
            // 
            btnResetPlati.Location = new Point(340, 675);
            btnResetPlati.Margin = new Padding(4, 5, 4, 5);
            btnResetPlati.Name = "btnResetPlati";
            btnResetPlati.Size = new Size(87, 38);
            btnResetPlati.TabIndex = 21;
            btnResetPlati.Text = "Reset";
            btnResetPlati.UseVisualStyleBackColor = true;
            btnResetPlati.Click += btnResetPlati_Click;
            // 
            // btnCautarePlati
            // 
            btnCautarePlati.Location = new Point(183, 675);
            btnCautarePlati.Margin = new Padding(4, 5, 4, 5);
            btnCautarePlati.Name = "btnCautarePlati";
            btnCautarePlati.Size = new Size(87, 38);
            btnCautarePlati.TabIndex = 20;
            btnCautarePlati.Text = "Cautare";
            btnCautarePlati.UseVisualStyleBackColor = true;
            btnCautarePlati.Click += btnCautarePlati_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 632);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 19;
            label5.Text = "Filtru de cautare:";
            // 
            // cmbFiltruPlati
            // 
            cmbFiltruPlati.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltruPlati.FormattingEnabled = true;
            cmbFiltruPlati.Items.AddRange(new object[] { "Suma", "DataPlata", "MetodaPlata", "StatusPlata" });
            cmbFiltruPlati.Location = new Point(183, 627);
            cmbFiltruPlati.Margin = new Padding(4, 5, 4, 5);
            cmbFiltruPlati.Name = "cmbFiltruPlati";
            cmbFiltruPlati.Size = new Size(243, 33);
            cmbFiltruPlati.TabIndex = 18;
            // 
            // txtDenumirePlati
            // 
            txtDenumirePlati.Location = new Point(183, 578);
            txtDenumirePlati.Margin = new Padding(4, 5, 4, 5);
            txtDenumirePlati.Name = "txtDenumirePlati";
            txtDenumirePlati.Size = new Size(243, 31);
            txtDenumirePlati.TabIndex = 17;
            // 
            // cmbSortarePlati
            // 
            cmbSortarePlati.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortarePlati.FormattingEnabled = true;
            cmbSortarePlati.Location = new Point(654, 578);
            cmbSortarePlati.Margin = new Padding(4, 5, 4, 5);
            cmbSortarePlati.Name = "cmbSortarePlati";
            cmbSortarePlati.Size = new Size(343, 33);
            cmbSortarePlati.TabIndex = 16;
            cmbSortarePlati.SelectedIndexChanged += cmbSortarePlati_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 583);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 15;
            label6.Text = "Sortare:";
            // 
            // btnStergePlati
            // 
            btnStergePlati.Location = new Point(677, 823);
            btnStergePlati.Margin = new Padding(4, 5, 4, 5);
            btnStergePlati.Name = "btnStergePlati";
            btnStergePlati.Size = new Size(241, 65);
            btnStergePlati.TabIndex = 3;
            btnStergePlati.Text = "Sterge";
            btnStergePlati.UseVisualStyleBackColor = true;
            btnStergePlati.Click += btnStergePlati_Click;
            // 
            // btnModificaPlati
            // 
            btnModificaPlati.Location = new Point(183, 823);
            btnModificaPlati.Margin = new Padding(4, 5, 4, 5);
            btnModificaPlati.Name = "btnModificaPlati";
            btnModificaPlati.Size = new Size(241, 65);
            btnModificaPlati.TabIndex = 2;
            btnModificaPlati.Text = "Modifica";
            btnModificaPlati.UseVisualStyleBackColor = true;
            btnModificaPlati.Click += btnModificaPlati_Click;
            // 
            // dgvPlati
            // 
            dgvPlati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlati.Location = new Point(9, 17);
            dgvPlati.Margin = new Padding(4, 5, 4, 5);
            dgvPlati.Name = "dgvPlati";
            dgvPlati.RowHeadersWidth = 62;
            dgvPlati.Size = new Size(1033, 498);
            dgvPlati.TabIndex = 0;
            // 
            // panelCont
            // 
            panelCont.Controls.Add(label20);
            panelCont.Controls.Add(panelEmail);
            panelCont.Controls.Add(panelContParola);
            panelCont.Controls.Add(panelContUsername);
            panelCont.Controls.Add(groupBox1);
            panelCont.Location = new Point(426, 3);
            panelCont.Name = "panelCont";
            panelCont.Size = new Size(1409, 1007);
            panelCont.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(590, 75);
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
            panelEmail.Location = new Point(126, 449);
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
            panelContParola.Location = new Point(137, 446);
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
            panelContUsername.Location = new Point(148, 446);
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
            // panelProgramari
            // 
            panelProgramari.Controls.Add(label7);
            panelProgramari.Controls.Add(btnResetProg);
            panelProgramari.Controls.Add(btnCautareProg);
            panelProgramari.Controls.Add(label8);
            panelProgramari.Controls.Add(cmbfiltruprog);
            panelProgramari.Controls.Add(txtdenumireprog);
            panelProgramari.Controls.Add(cmbsortareprog);
            panelProgramari.Controls.Add(label9);
            panelProgramari.Controls.Add(btnStergeProgramari);
            panelProgramari.Controls.Add(btnAdaugaProgramari);
            panelProgramari.Controls.Add(btnModificaProgramari);
            panelProgramari.Controls.Add(dgvProgramari);
            panelProgramari.Location = new Point(426, 2);
            panelProgramari.Name = "panelProgramari";
            panelProgramari.Size = new Size(1141, 981);
            panelProgramari.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 572);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 30;
            label7.Text = "Denumire:";
            // 
            // btnResetProg
            // 
            btnResetProg.Location = new Point(363, 664);
            btnResetProg.Margin = new Padding(4, 5, 4, 5);
            btnResetProg.Name = "btnResetProg";
            btnResetProg.Size = new Size(87, 38);
            btnResetProg.TabIndex = 29;
            btnResetProg.Text = "Reset";
            btnResetProg.UseVisualStyleBackColor = true;
            btnResetProg.Click += btnResetProg_Click;
            // 
            // btnCautareProg
            // 
            btnCautareProg.Location = new Point(206, 664);
            btnCautareProg.Margin = new Padding(4, 5, 4, 5);
            btnCautareProg.Name = "btnCautareProg";
            btnCautareProg.Size = new Size(87, 38);
            btnCautareProg.TabIndex = 28;
            btnCautareProg.Text = "Cautare";
            btnCautareProg.UseVisualStyleBackColor = true;
            btnCautareProg.Click += btnCautareProg_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 621);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(142, 25);
            label8.TabIndex = 27;
            label8.Text = "Filtru de cautare:";
            // 
            // cmbfiltruprog
            // 
            cmbfiltruprog.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfiltruprog.FormattingEnabled = true;
            cmbfiltruprog.Items.AddRange(new object[] { "Pacient", "Serviciu", "Pret", "Status" });
            cmbfiltruprog.Location = new Point(206, 616);
            cmbfiltruprog.Margin = new Padding(4, 5, 4, 5);
            cmbfiltruprog.Name = "cmbfiltruprog";
            cmbfiltruprog.Size = new Size(243, 33);
            cmbfiltruprog.TabIndex = 26;
            // 
            // txtdenumireprog
            // 
            txtdenumireprog.Location = new Point(206, 567);
            txtdenumireprog.Margin = new Padding(4, 5, 4, 5);
            txtdenumireprog.Name = "txtdenumireprog";
            txtdenumireprog.Size = new Size(243, 31);
            txtdenumireprog.TabIndex = 25;
            // 
            // cmbsortareprog
            // 
            cmbsortareprog.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbsortareprog.FormattingEnabled = true;
            cmbsortareprog.Items.AddRange(new object[] { "PacientCrescator", "PacientDescrescator", "DataProgramareCrescator", "DataProgramareDescrescator", "PretCrescator", "PretDescrescator" });
            cmbsortareprog.Location = new Point(677, 567);
            cmbsortareprog.Margin = new Padding(4, 5, 4, 5);
            cmbsortareprog.Name = "cmbsortareprog";
            cmbsortareprog.Size = new Size(343, 33);
            cmbsortareprog.TabIndex = 24;
            cmbsortareprog.SelectedIndexChanged += cmbsortareprog_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(602, 572);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 25);
            label9.TabIndex = 23;
            label9.Text = "Sortare:";
            // 
            // btnStergeProgramari
            // 
            btnStergeProgramari.Location = new Point(750, 786);
            btnStergeProgramari.Margin = new Padding(4, 5, 4, 5);
            btnStergeProgramari.Name = "btnStergeProgramari";
            btnStergeProgramari.Size = new Size(241, 65);
            btnStergeProgramari.TabIndex = 5;
            btnStergeProgramari.Text = "Sterge";
            btnStergeProgramari.UseVisualStyleBackColor = true;
            btnStergeProgramari.Click += btnStergeProgramari_Click;
            // 
            // btnAdaugaProgramari
            // 
            btnAdaugaProgramari.Location = new Point(49, 786);
            btnAdaugaProgramari.Margin = new Padding(4, 5, 4, 5);
            btnAdaugaProgramari.Name = "btnAdaugaProgramari";
            btnAdaugaProgramari.Size = new Size(241, 65);
            btnAdaugaProgramari.TabIndex = 4;
            btnAdaugaProgramari.Text = "Adauga";
            btnAdaugaProgramari.UseVisualStyleBackColor = true;
            btnAdaugaProgramari.Click += btnAdaugaProgramari_Click;
            // 
            // btnModificaProgramari
            // 
            btnModificaProgramari.Location = new Point(411, 786);
            btnModificaProgramari.Margin = new Padding(4, 5, 4, 5);
            btnModificaProgramari.Name = "btnModificaProgramari";
            btnModificaProgramari.Size = new Size(241, 65);
            btnModificaProgramari.TabIndex = 3;
            btnModificaProgramari.Text = "Modifica";
            btnModificaProgramari.UseVisualStyleBackColor = true;
            btnModificaProgramari.Click += btnModificaProgramari_Click;
            // 
            // dgvProgramari
            // 
            dgvProgramari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProgramari.Location = new Point(15, 7);
            dgvProgramari.Name = "dgvProgramari";
            dgvProgramari.RowHeadersWidth = 62;
            dgvProgramari.Size = new Size(1036, 496);
            dgvProgramari.TabIndex = 0;
            // 
            // panelStatistica
            // 
            panelStatistica.BackColor = Color.DimGray;
            panelStatistica.Controls.Add(listBoxLoggari);
            panelStatistica.Controls.Add(chart2);
            panelStatistica.Controls.Add(chart1);
            panelStatistica.Location = new Point(414, 0);
            panelStatistica.Name = "panelStatistica";
            panelStatistica.Size = new Size(1514, 1005);
            panelStatistica.TabIndex = 9;
            // 
            // listBoxLoggari
            // 
            listBoxLoggari.BackColor = Color.Gray;
            listBoxLoggari.FormattingEnabled = true;
            listBoxLoggari.Location = new Point(36, 484);
            listBoxLoggari.Name = "listBoxLoggari";
            listBoxLoggari.ScrollAlwaysVisible = true;
            listBoxLoggari.Size = new Size(1015, 479);
            listBoxLoggari.TabIndex = 2;
            // 
            // chart2
            // 
            chart2.BackColor = Color.Gray;
            chart2.BorderlineColor = Color.DimGray;
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(565, 37);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(491, 356);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // chart1
            // 
            chart1.BackColor = Color.Gray;
            chart1.BorderlineColor = Color.DimGray;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(32, 37);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(494, 356);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // FormAdministrator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1483, 988);
            Controls.Add(panelStatistica);
            Controls.Add(panelCont);
            Controls.Add(panelProgramari);
            Controls.Add(panelPlati);
            Controls.Add(panelServicii);
            Controls.Add(panelUtilizatori);
            Controls.Add(grpboxfunctionalitati);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAdministrator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdministrator";
            Load += FormAdministrator_Load;
            panelUtilizatori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUtilizatori).EndInit();
            panelServicii.ResumeLayout(false);
            panelServicii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicii).EndInit();
            grpboxfunctionalitati.ResumeLayout(false);
            panelPlati.ResumeLayout(false);
            panelPlati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlati).EndInit();
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
            panelProgramari.ResumeLayout(false);
            panelProgramari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProgramari).EndInit();
            panelStatistica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnModifica;
        private Button btnSterge;
        private Panel panelUtilizatori;
        private Button btnGesUtilizatori;
        private Button btnIesire;
        private Button btnGesServicii;
        private GroupBox grpboxfunctionalitati;
        private Panel panelServicii;
        private ComboBox cmbSortare;
        private Label label1;
        private Button btnStergeServicii;
        private Button btnModificaServicii;
        private Button btnAdaugaServicii;
        private DataGridView dgvServicii;
        private Button btnAdauga;
        private DataGridView dgvUtilizatori;
        private TextBox txtCautare;
        private Label label3;
        private ComboBox cmbFiltruCautare;
        private Button btnCautare;
        private Label label2;
        private Button btnReset;
        private Button btnGesPlati;
        private Panel panelPlati;
        private DataGridView dgvPlati;
        private Button btnStergePlati;
        private Button btnModificaPlati;
        private Label label4;
        private Button btnResetPlati;
        private Button btnCautarePlati;
        private Label label5;
        private ComboBox cmbFiltruPlati;
        private TextBox txtDenumirePlati;
        private ComboBox cmbSortarePlati;
        private Label label6;
        private Button btnGesProgramari;
        private Panel panelProgramari;
        private Label label7;
        private Button btnResetProg;
        private Button btnCautareProg;
        private Label label8;
        private ComboBox cmbfiltruprog;
        private TextBox txtdenumireprog;
        private ComboBox cmbsortareprog;
        private Label label9;
        private Button btnStergeProgramari;
        private Button btnAdaugaProgramari;
        private Button btnModificaProgramari;
        private DataGridView dgvProgramari;
        private Button btnContulMeu;
        private Panel panelCont;
        private GroupBox groupBox1;
        private TextBox txtDetaliiEmail;
        private TextBox txtDetaliiParola;
        private TextBox txtDetaliiUsername;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtDetaliiNume;
        private Label label10;
        private Panel panelContUsername;
        private Button btnModificaUsername;
        private TextBox txtContUsernameNou;
        private TextBox txtContUsernameVechi;
        private Label label16;
        private Label label17;
        private Panel panelContParola;
        private Button btnModificaParola;
        private TextBox txtParolaNoua;
        private TextBox txtParolaVeche;
        private Label label18;
        private Label label19;
        private Panel panelEmail;
        private Button btnModificaEmail;
        private TextBox txtEmailNou;
        private TextBox txtEmailVechi;
        private Label label14;
        private Label label15;
        private Label label20;
        private Button btnStatistica;
        private Panel panelStatistica;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ListBox listBoxLoggari;
    }
}