namespace Proiect.Forms.FormAdministratorLogic
{
    partial class Form_Gestiune_modificare
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
            txtNume = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            txtParola = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbRol = new ComboBox();
            btnModifica = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtNume
            // 
            txtNume.Location = new Point(3, 107);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(218, 23);
            txtNume.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 89);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nume";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(3, 44);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(217, 44);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(208, 23);
            txtParola.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 26);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 26);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Parola";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(227, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 23);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 89);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 188);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 8;
            label5.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(135, 185);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(182, 23);
            cmbRol.TabIndex = 9;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(29, 292);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(142, 44);
            btnModifica.TabIndex = 10;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
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
            // Form_Gestiune_modificare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(432, 368);
            Controls.Add(btnCancel);
            Controls.Add(btnModifica);
            Controls.Add(cmbRol);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtParola);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtNume);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Gestiune_modificare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Gestiune_modificare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNume;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtParola;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private ComboBox cmbRol;
        private Button btnModifica;
        private Button btnCancel;
    }
}