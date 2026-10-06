namespace Proiect.Forms.FormAdministratorLogic
{
    partial class Form_Gestiune_servicii_adaugare
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
            txtDescriere = new TextBox();
            label1 = new Label();
            txtDenumire = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnAdauga = new Button();
            btnCancel = new Button();
            numericUpDownPret = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPret).BeginInit();
            SuspendLayout();
            // 
            // txtDescriere
            // 
            txtDescriere.Location = new Point(12, 107);
            txtDescriere.Multiline = true;
            txtDescriere.Name = "txtDescriere";
            txtDescriere.Size = new Size(408, 146);
            txtDescriere.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 89);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Descriere";
            // 
            // txtDenumire
            // 
            txtDenumire.Location = new Point(3, 44);
            txtDenumire.Name = "txtDenumire";
            txtDenumire.Size = new Size(266, 23);
            txtDenumire.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 26);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Denumire";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 26);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "Pret";
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(29, 292);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(142, 44);
            btnAdauga.TabIndex = 10;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(244, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 44);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numericUpDownPret
            // 
            numericUpDownPret.Location = new Point(296, 44);
            numericUpDownPret.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDownPret.Name = "numericUpDownPret";
            numericUpDownPret.Size = new Size(124, 23);
            numericUpDownPret.TabIndex = 12;
            // 
            // Form_Gestiune_servicii_adaugare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(432, 368);
            Controls.Add(numericUpDownPret);
            Controls.Add(btnCancel);
            Controls.Add(btnAdauga);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtDenumire);
            Controls.Add(label1);
            Controls.Add(txtDescriere);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Gestiune_servicii_adaugare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Gestiune_servicii_adaugare";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescriere;
        private Label label1;
        private TextBox txtDenumire;
        private Label label2;
        private Label label4;
        private Button btnAdauga;
        private Button btnCancel;
        private NumericUpDown numericUpDownPret;
    }
}