namespace Proiect.Forms.FormClientLogic
{
    partial class FormIstoricProgramari
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
            dgvProgramari = new DataGridView();
            btnModifica = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnSterge = new Button();
            cmbFiltru = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProgramari).BeginInit();
            SuspendLayout();
            // 
            // dgvProgramari
            // 
            dgvProgramari.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProgramari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProgramari.Location = new Point(-3, -2);
            dgvProgramari.Name = "dgvProgramari";
            dgvProgramari.RowHeadersWidth = 62;
            dgvProgramari.Size = new Size(1320, 406);
            dgvProgramari.TabIndex = 0;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(64, 561);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(275, 78);
            btnModifica.TabIndex = 1;
            btnModifica.Text = "Modifica Programare";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnSterge
            // 
            btnSterge.Location = new Point(406, 561);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(275, 78);
            btnSterge.TabIndex = 2;
            btnSterge.Text = "Sterge";
            btnSterge.UseVisualStyleBackColor = true;
            btnSterge.Click += btnSterge_Click;
            // 
            // cmbFiltru
            // 
            cmbFiltru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltru.FormattingEnabled = true;
            cmbFiltru.Items.AddRange(new object[] { "DataCrescator", "DataDescrescator" });
            cmbFiltru.Location = new Point(1038, 454);
            cmbFiltru.Name = "cmbFiltru";
            cmbFiltru.Size = new Size(243, 33);
            cmbFiltru.TabIndex = 3;
            cmbFiltru.SelectedIndexChanged += cmbFiltru_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(945, 457);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 4;
            label1.Text = "Filtreaza:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(1006, 561);
            button1.Name = "button1";
            button1.Size = new Size(275, 78);
            button1.TabIndex = 5;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormIstoricProgramari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1313, 689);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cmbFiltru);
            Controls.Add(btnSterge);
            Controls.Add(btnModifica);
            Controls.Add(dgvProgramari);
            Name = "FormIstoricProgramari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIstoricProgramari";
            Load += FormIstoricProgramari_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProgramari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProgramari;
        private Button btnModifica;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnSterge;
        private ComboBox cmbFiltru;
        private Label label1;
        private Button button1;
    }
}