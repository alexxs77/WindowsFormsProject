namespace Proiect
{
    partial class FormClient
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
            label1 = new Label();
            btnAdaugaProgramare = new Button();
            btnIstoric = new Button();
            btnDetaliiCont = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(566, 38);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdaugaProgramare
            // 
            btnAdaugaProgramare.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdaugaProgramare.BackColor = Color.Gray;
            btnAdaugaProgramare.Location = new Point(147, 142);
            btnAdaugaProgramare.Name = "btnAdaugaProgramare";
            btnAdaugaProgramare.Size = new Size(252, 76);
            btnAdaugaProgramare.TabIndex = 2;
            btnAdaugaProgramare.Text = "Adauga programare";
            btnAdaugaProgramare.UseVisualStyleBackColor = false;
            btnAdaugaProgramare.Click += btnAdaugaProgramare_Click;
            // 
            // btnIstoric
            // 
            btnIstoric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIstoric.BackColor = Color.Gray;
            btnIstoric.Location = new Point(147, 224);
            btnIstoric.Name = "btnIstoric";
            btnIstoric.Size = new Size(252, 76);
            btnIstoric.TabIndex = 3;
            btnIstoric.Text = "Istoric";
            btnIstoric.UseVisualStyleBackColor = false;
            btnIstoric.Click += btnIstoric_Click;
            // 
            // btnDetaliiCont
            // 
            btnDetaliiCont.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDetaliiCont.BackColor = Color.Gray;
            btnDetaliiCont.Location = new Point(147, 306);
            btnDetaliiCont.Name = "btnDetaliiCont";
            btnDetaliiCont.Size = new Size(252, 76);
            btnDetaliiCont.TabIndex = 4;
            btnDetaliiCont.Text = "Detalii cont";
            btnDetaliiCont.UseVisualStyleBackColor = false;
            btnDetaliiCont.Click += btnDetaliiCont_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(147, 597);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(252, 76);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(564, 685);
            Controls.Add(btnExit);
            Controls.Add(btnDetaliiCont);
            Controls.Add(btnIstoric);
            Controls.Add(btnAdaugaProgramare);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClient";
            Load += FormClient_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnAdaugaProgramare;
        private Button btnIstoric;
        private Button btnDetaliiCont;
        private Button btnExit;
    }
}