using Proiect.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proiect.Forms.FormClientLogic
{
    public partial class FormClientCont : Form
    {
        DataBaseConnection connection = new DataBaseConnection();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Parola { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nume { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Email { get; set; }
        public FormClientCont()
        {
            InitializeComponent();

            panelContParola.Visible = false;
            panelEmail.Visible = false;
            panelContUsername.Visible = false;
        }
        private void LoadData_utilizatori()
        {
            if (connection.adapter_utilizatori == null)
                return;
            try
            {
                connection.table_utilizatori.Clear();
                connection.adapter_utilizatori.Fill(connection.table_utilizatori);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }

        }

        private void txtDetaliiEmail_MouseEnter(object sender, EventArgs e)
        {
            txtDetaliiEmail.PasswordChar = '\0';
        }

        private void txtDetaliiEmail_MouseLeave(object sender, EventArgs e)
        {
            txtDetaliiEmail.PasswordChar = '*';
        }

        private void txtDetaliiUsername_Click(object sender, EventArgs e)
        {
            panelContUsername.Visible = true;
            panelEmail.Visible = false;
            panelContParola.Visible = false;
        }

        private void btnModificaUsername_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContUsernameNou.Text) && !string.IsNullOrEmpty(txtContUsernameVechi.Text) && txtContUsernameVechi.Text == Username)
            {
                foreach (DataRow row in connection.table_utilizatori.Rows)
                {
                    if (row["Username"].ToString() == Username)
                    {
                        row["Username"] = txtContUsernameNou.Text;
                        break;
                    }
                }
                connection.adapter_utilizatori!.Update(connection.table_utilizatori);
                LoadData_utilizatori();
                MessageBox.Show("Username modificat cu succes!", "Succes", MessageBoxButtons.OK);
                Username = txtContUsernameNou.Text;
                txtDetaliiUsername.Text = Username;
                this.Text = $"Panou Administrator - {Username}";
                txtContUsernameNou.Clear();
                txtContUsernameVechi.Clear();
                panelContUsername.Visible = false;
            }
            else
            {
                MessageBox.Show("Vă rugăm să completați corect câmpurile pentru modificare/username vechi invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDetaliiParola_Click(object sender, EventArgs e)
        {
            panelContUsername.Visible = false;
            panelEmail.Visible = false;
            panelContParola.Visible = true;
        }

        private void btnModificaParola_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtParolaNoua.Text) && !string.IsNullOrEmpty(txtParolaVeche.Text) && txtParolaVeche.Text == Parola)
            {
                foreach (DataRow row in connection.table_utilizatori.Rows)
                {
                    if (row["Username"].ToString() == Username)
                    {
                        row["Parola"] = txtParolaNoua.Text;
                        break;
                    }
                }
                connection.adapter_utilizatori!.Update(connection.table_utilizatori);
                LoadData_utilizatori();
                MessageBox.Show("Parola modificata cu succes!", "Succes", MessageBoxButtons.OK);
                Parola = txtParolaNoua.Text;
                txtDetaliiParola.Text = Parola;
                txtParolaNoua.Clear();
                txtParolaVeche.Clear();
                panelContParola.Visible = false;
            }
            else
            {
                MessageBox.Show("Vă rugăm să completați corect câmpurile pentru modificare/parola veche invalida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDetaliiEmail_Click(object sender, EventArgs e)
        {
            panelContUsername.Visible = false;
            panelEmail.Visible = true;
            panelContParola.Visible = false;
        }

        private void btnModificaEmail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmailNou.Text) && !string.IsNullOrEmpty(txtEmailVechi.Text) && txtEmailVechi.Text == Email)
            {
                string pattern = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com)$";
                if (!Regex.IsMatch(txtEmailNou.Text, pattern))
                {
                    MessageBox.Show("Adresa de email trebuie sa fie valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataRow row in connection.table_utilizatori.Rows)
                {
                    if (row["Username"].ToString() == Username)
                    {
                        row["Email"] = txtEmailNou.Text;
                        break;
                    }
                }
                try
                {
                    connection.adapter_utilizatori!.Update(connection.table_utilizatori);
                    LoadData_utilizatori();
                    MessageBox.Show("Email modificat cu succes!", "Succes", MessageBoxButtons.OK);
                    Email = txtEmailNou.Text;
                    txtDetaliiEmail.Text = Email;
                    txtEmailNou.Clear();
                    txtEmailVechi.Clear();
                    panelEmail.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la actualizare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Vă rugăm să completați corect câmpurile pentru modificare/email vechi invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            LoadData_utilizatori();
            this.Close();
        }

        private void FormClientCont_Load(object sender, EventArgs e)
        {
            LoadData_utilizatori();
            txtDetaliiNume.Text = Nume;
            txtDetaliiEmail.Text = Email;
            txtDetaliiUsername.Text = Username;
            txtDetaliiParola.Text = Parola;
            txtDetaliiNume.SelectionStart = txtDetaliiNume.Text.Length;
            txtDetaliiNume.SelectionLength = 0;
        }
    }
}
