namespace Proiect.Forms.FormClientLogic
{
    partial class FormClientCont
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
            panelCont = new Panel();
            btnIesire = new Button();
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
            panelCont.SuspendLayout();
            panelEmail.SuspendLayout();
            panelContParola.SuspendLayout();
            panelContUsername.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCont
            // 
            panelCont.Controls.Add(btnIesire);
            panelCont.Controls.Add(label20);
            panelCont.Controls.Add(panelEmail);
            panelCont.Controls.Add(panelContParola);
            panelCont.Controls.Add(panelContUsername);
            panelCont.Controls.Add(groupBox1);
            panelCont.Location = new Point(12, 12);
            panelCont.Name = "panelCont";
            panelCont.Size = new Size(1409, 895);
            panelCont.TabIndex = 10;
            // 
            // btnIesire
            // 
            btnIesire.BackColor = Color.Red;
            btnIesire.Location = new Point(1066, 704);
            btnIesire.Name = "btnIesire";
            btnIesire.Size = new Size(277, 75);
            btnIesire.TabIndex = 12;
            btnIesire.Text = "Exit";
            btnIesire.UseVisualStyleBackColor = false;
            btnIesire.Click += btnIesire_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(625, 75);
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
            // FormClientCont
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1493, 919);
            Controls.Add(panelCont);
            Name = "FormClientCont";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientCont";
            Load += FormClientCont_Load;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCont;
        private Label label20;
        private Panel panelEmail;
        private Button btnModificaEmail;
        private TextBox txtEmailNou;
        private TextBox txtEmailVechi;
        private Label label14;
        private Label label15;
        private Panel panelContParola;
        private Button btnModificaParola;
        private TextBox txtParolaNoua;
        private TextBox txtParolaVeche;
        private Label label18;
        private Label label19;
        private Panel panelContUsername;
        private Button btnModificaUsername;
        private TextBox txtContUsernameNou;
        private TextBox txtContUsernameVechi;
        private Label label16;
        private Label label17;
        private GroupBox groupBox1;
        private TextBox txtDetaliiEmail;
        private TextBox txtDetaliiParola;
        private TextBox txtDetaliiUsername;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtDetaliiNume;
        private Label label10;
        private Button btnIesire;
    }
}