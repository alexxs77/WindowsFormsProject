namespace Proiect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAutentificare = new Button();
            Nume = new Label();
            label1 = new Label();
            progressBarAutentificare = new ProgressBar();
            txtUtilizator = new TextBox();
            txtParola = new TextBox();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // btnAutentificare
            // 
            btnAutentificare.BackColor = Color.LimeGreen;
            btnAutentificare.Location = new Point(71, 337);
            btnAutentificare.Name = "btnAutentificare";
            btnAutentificare.Size = new Size(203, 62);
            btnAutentificare.TabIndex = 0;
            btnAutentificare.Text = "Autentificare";
            btnAutentificare.UseVisualStyleBackColor = false;
            btnAutentificare.Click += btnAutentificare_Click;
            // 
            // Nume
            // 
            Nume.AutoSize = true;
            Nume.Location = new Point(199, 90);
            Nume.Name = "Nume";
            Nume.Size = new Size(54, 25);
            Nume.TabIndex = 1;
            Nume.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 137);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 2;
            label1.Text = "Parola";
            // 
            // progressBarAutentificare
            // 
            progressBarAutentificare.Location = new Point(71, 273);
            progressBarAutentificare.Name = "progressBarAutentificare";
            progressBarAutentificare.Size = new Size(621, 32);
            progressBarAutentificare.TabIndex = 3;
            // 
            // txtUtilizator
            // 
            txtUtilizator.Location = new Point(281, 90);
            txtUtilizator.Name = "txtUtilizator";
            txtUtilizator.Size = new Size(418, 31);
            txtUtilizator.TabIndex = 4;
            txtUtilizator.KeyDown += txtUtilizator_KeyDown;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(281, 137);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(418, 31);
            txtParola.TabIndex = 5;
            txtParola.KeyDown += txtParola_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.padlock;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(21, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 142);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Location = new Point(491, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(203, 62);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox1);
            Controls.Add(txtParola);
            Controls.Add(txtUtilizator);
            Controls.Add(progressBarAutentificare);
            Controls.Add(label1);
            Controls.Add(Nume);
            Controls.Add(btnAutentificare);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAutentificare;
        private Label Nume;
        private Label label1;
        private ProgressBar progressBarAutentificare;
        private TextBox txtUtilizator;
        private TextBox txtParola;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}
