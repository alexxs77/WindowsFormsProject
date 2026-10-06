namespace Proiect.Forms.FormAdministratorLogic
{
    partial class Form_Gestiune_plati_modificare
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
            label2 = new Label();
            label4 = new Label();
            btnAdauga = new Button();
            btnCancel = new Button();
            numericUpDownSuma = new NumericUpDown();
            cmbMetodaPlata = new ComboBox();
            cmbStatusPlata = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuma).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 223);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 4;
            label2.Text = "Metoda Plata";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 7;
            label4.Text = "Suma";
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(41, 487);
            btnAdauga.Margin = new Padding(4, 5, 4, 5);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(203, 73);
            btnAdauga.TabIndex = 10;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(349, 487);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(203, 73);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numericUpDownSuma
            // 
            numericUpDownSuma.Location = new Point(223, 100);
            numericUpDownSuma.Margin = new Padding(4, 5, 4, 5);
            numericUpDownSuma.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDownSuma.Name = "numericUpDownSuma";
            numericUpDownSuma.Size = new Size(177, 31);
            numericUpDownSuma.TabIndex = 12;
            // 
            // cmbMetodaPlata
            // 
            cmbMetodaPlata.FormattingEnabled = true;
            cmbMetodaPlata.Items.AddRange(new object[] { "Card", "Cash" });
            cmbMetodaPlata.Location = new Point(17, 253);
            cmbMetodaPlata.Margin = new Padding(4, 5, 4, 5);
            cmbMetodaPlata.Name = "cmbMetodaPlata";
            cmbMetodaPlata.Size = new Size(264, 33);
            cmbMetodaPlata.TabIndex = 13;
            // 
            // cmbStatusPlata
            // 
            cmbStatusPlata.FormattingEnabled = true;
            cmbStatusPlata.Items.AddRange(new object[] { "Neplatit", "Platit" });
            cmbStatusPlata.Location = new Point(301, 253);
            cmbStatusPlata.Margin = new Padding(4, 5, 4, 5);
            cmbStatusPlata.Name = "cmbStatusPlata";
            cmbStatusPlata.Size = new Size(277, 33);
            cmbStatusPlata.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 223);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 17;
            label3.Text = "Status Plata";
            // 
            // Form_Gestiune_plati_modificare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(617, 613);
            Controls.Add(label3);
            Controls.Add(cmbStatusPlata);
            Controls.Add(cmbMetodaPlata);
            Controls.Add(numericUpDownSuma);
            Controls.Add(btnCancel);
            Controls.Add(btnAdauga);
            Controls.Add(label4);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Gestiune_plati_modificare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Gestiune_plati_modificare";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSuma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Button btnAdauga;
        private Button btnCancel;
        private NumericUpDown numericUpDownSuma;
        private ComboBox cmbMetodaPlata;
        private ComboBox cmbStatusPlata;
        private Label label3;
    }
}