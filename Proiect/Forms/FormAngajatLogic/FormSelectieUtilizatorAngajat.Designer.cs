namespace Proiect.Forms.FormAngajatLogic
{
    partial class FormSelectieUtilizatorAngajat
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
            btnCancelSelectie = new Button();
            btnOKSelectie = new Button();
            dgvUtilizatori = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUtilizatori).BeginInit();
            SuspendLayout();
            // 
            // btnCancelSelectie
            // 
            btnCancelSelectie.Location = new Point(695, 417);
            btnCancelSelectie.Name = "btnCancelSelectie";
            btnCancelSelectie.Size = new Size(271, 67);
            btnCancelSelectie.TabIndex = 5;
            btnCancelSelectie.Text = "Cancel";
            btnCancelSelectie.UseVisualStyleBackColor = true;
            btnCancelSelectie.Click += btnCancelSelectie_Click;
            // 
            // btnOKSelectie
            // 
            btnOKSelectie.Location = new Point(141, 417);
            btnOKSelectie.Name = "btnOKSelectie";
            btnOKSelectie.Size = new Size(271, 67);
            btnOKSelectie.TabIndex = 4;
            btnOKSelectie.Text = "OK";
            btnOKSelectie.UseVisualStyleBackColor = true;
            btnOKSelectie.Click += btnOKSelectie_Click;
            // 
            // dgvUtilizatori
            // 
            dgvUtilizatori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilizatori.Location = new Point(43, 27);
            dgvUtilizatori.Name = "dgvUtilizatori";
            dgvUtilizatori.RowHeadersWidth = 62;
            dgvUtilizatori.Size = new Size(1132, 297);
            dgvUtilizatori.TabIndex = 3;
            // 
            // FormSelectieUtilizatorAngajat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1330, 682);
            Controls.Add(btnCancelSelectie);
            Controls.Add(btnOKSelectie);
            Controls.Add(dgvUtilizatori);
            Name = "FormSelectieUtilizatorAngajat";
            Text = "FormSelectieUtilizatorAngajat";
            ((System.ComponentModel.ISupportInitialize)dgvUtilizatori).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelSelectie;
        private Button btnOKSelectie;
        private DataGridView dgvUtilizatori;
    }
}