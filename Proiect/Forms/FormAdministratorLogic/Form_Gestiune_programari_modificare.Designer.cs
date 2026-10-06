namespace Proiect.Forms.FormAdministratorLogic
{
    partial class Form_Gestiune_programari_modificare
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
            btnModifica = new Button();
            btnCancel = new Button();
            cmbStatus = new ComboBox();
            dateTimePickerDataProgramare = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 4;
            label2.Text = "Status";
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(41, 487);
            btnModifica.Margin = new Padding(4, 5, 4, 5);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(203, 73);
            btnModifica.TabIndex = 10;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
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
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "In asteptare", "Finalizat" });
            cmbStatus.Location = new Point(164, 138);
            cmbStatus.Margin = new Padding(4, 5, 4, 5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(264, 33);
            cmbStatus.TabIndex = 13;
            // 
            // dateTimePickerDataProgramare
            // 
            dateTimePickerDataProgramare.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerDataProgramare.Format = DateTimePickerFormat.Custom;
            dateTimePickerDataProgramare.Location = new Point(164, 292);
            dateTimePickerDataProgramare.Name = "dateTimePickerDataProgramare";
            dateTimePickerDataProgramare.Size = new Size(264, 31);
            dateTimePickerDataProgramare.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 253);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 20;
            label1.Text = "Data Programare";
            // 
            // Form_Gestiune_programari_modificare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(617, 613);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDataProgramare);
            Controls.Add(cmbStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnModifica);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Gestiune_programari_modificare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Gestiune_programari_modificare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnModifica;
        private Button btnCancel;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimePickerDataProgramare;
        private Label label1;
    }
}