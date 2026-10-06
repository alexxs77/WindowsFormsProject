namespace Proiect.Forms.FormAdministratorLogic
{
    partial class Form_Gestiune_plati_adaugare
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
            cmbMetodaPlata = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 4;
            label2.Text = "Metoda Plata";
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
            // cmbMetodaPlata
            // 
            cmbMetodaPlata.FormattingEnabled = true;
            cmbMetodaPlata.Items.AddRange(new object[] { "Card", "Cash" });
            cmbMetodaPlata.Location = new Point(149, 225);
            cmbMetodaPlata.Margin = new Padding(4, 5, 4, 5);
            cmbMetodaPlata.Name = "cmbMetodaPlata";
            cmbMetodaPlata.Size = new Size(264, 33);
            cmbMetodaPlata.TabIndex = 13;
            // 
            // Form_Gestiune_plati_adaugare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(617, 613);
            Controls.Add(cmbMetodaPlata);
            Controls.Add(btnCancel);
            Controls.Add(btnAdauga);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Gestiune_plati_adaugare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Gestiune_plati_adaugare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnAdauga;
        private Button btnCancel;
        private ComboBox cmbMetodaPlata;
    }
}