namespace Proiect.Forms.FormAdministratorLogic
{
    partial class Form_Gestiune_programari_adaugare
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
            btnAdauga = new Button();
            btnCancel = new Button();
            cmbServiciu = new ComboBox();
            label3 = new Label();
            numericUpDownPret = new NumericUpDown();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPret).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 4;
            label2.Text = "Serviciu";
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
            // cmbServiciu
            // 
            cmbServiciu.FormattingEnabled = true;
            cmbServiciu.Location = new Point(13, 175);
            cmbServiciu.Margin = new Padding(4, 5, 4, 5);
            cmbServiciu.Name = "cmbServiciu";
            cmbServiciu.Size = new Size(264, 33);
            cmbServiciu.TabIndex = 13;
            cmbServiciu.SelectedIndexChanged += cmbServiciu_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 17;
            label3.Text = "Pret";
            // 
            // numericUpDownPret
            // 
            numericUpDownPret.Location = new Point(318, 177);
            numericUpDownPret.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDownPret.Name = "numericUpDownPret";
            numericUpDownPret.Size = new Size(249, 31);
            numericUpDownPret.TabIndex = 18;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(151, 342);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(298, 31);
            dateTimePicker.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 305);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 20;
            label1.Text = "Data Programare";
            // 
            // Form_Gestiune_programari_adaugare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(617, 613);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(numericUpDownPret);
            Controls.Add(label3);
            Controls.Add(cmbServiciu);
            Controls.Add(btnCancel);
            Controls.Add(btnAdauga);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Gestiune_programari_adaugare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Gestiune_programari_adaugare";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnAdauga;
        private Button btnCancel;
        private ComboBox cmbServiciu;
        private Label label3;
        private NumericUpDown numericUpDownPret;
        private DateTimePicker dateTimePicker;
        private Label label1;
    }
}