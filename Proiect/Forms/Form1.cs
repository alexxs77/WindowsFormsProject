using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
namespace Proiect
{
    public partial class Form1 : Form
    {
        String? connString;
        SqlConnection? connection;
        SqlDataAdapter? adapter;
        SqlCommandBuilder? commandBuilder;
        DataTable table = new DataTable("Utilizatori");
        private bool CancelNow = false;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            progressBarAutentificare.Visible = false;
            this.Opacity = 1;
            timer1.Interval = 100;
            timer2.Interval = 100;
            this.Text = "Logare";
            connString = ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
            connection = new SqlConnection(connString);
            adapter = new SqlDataAdapter("SELECT Id, Username, Parola, Nume, Email, Rol FROM dbo.Utilizatori", connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            LoadData();
            Verificare_utilizatori();

        }
        private void LoadData()
        {
            if (adapter == null)
                return;
            try
            {
                table.Clear();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }

        private void Verificare_utilizatori()
        {
            if (table.Rows.Count == 0)
            {
                DataRow row = table.NewRow();
                row["Username"] = "admin";
                row["Parola"] = "admin";
                row["Nume"] = "Alexandru";
                row["Email"] = "alexandru@gmail.com";
                row["Rol"] = "Administrator";
                table.Rows.Add(row);
                try
                {
                    adapter!.Update(table);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la crearea utilizatorului administrator: " + ex.Message);
                }
            }
        }



        private void Verificare_rol()
        {
            LoadData();
            bool utilizatorGasit = false;
            string pattern = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com)$";
            if (!Regex.IsMatch(txtUtilizator.Text, pattern))
            {
                MessageBox.Show("Adresa de email trebuie sa fie valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.Clear();
                errorProvider2.Clear();
                timer1.Stop();
                progressBarAutentificare.Value = 0;
                progressBarAutentificare.Visible = false;
                return;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Email"].ToString() == txtUtilizator.Text && table.Rows[i]["Parola"].ToString() == txtParola.Text)
                {
                    utilizatorGasit = true;
                    if (table.Rows[i]["Rol"].ToString() == "Administrator")
                    {
                        FormAdministrator formAdmin = new FormAdministrator();
                        formAdmin.Username = table.Rows[i]["Username"].ToString();
                        formAdmin.Parola = table.Rows[i]["Parola"].ToString();
                        formAdmin.Email = table.Rows[i]["Email"].ToString();
                        formAdmin.Nume = table.Rows[i]["Nume"].ToString();
                        this.Hide();
                        formAdmin.ShowDialog();
                        if (formAdmin.DialogResult == DialogResult.Cancel)
                        {
                            this.Show();
                            txtUtilizator.Clear();
                            txtParola.Clear();
                        }


                    }
                    else
                        if (table.Rows[i]["Rol"].ToString() == "Angajat")
                        {
                            FormAngajat formAngajat = new FormAngajat();
                            formAngajat.Username = table.Rows[i]["Username"].ToString();
                            formAngajat.Parola = table.Rows[i]["Parola"].ToString();
                            formAngajat.Email = table.Rows[i]["Email"].ToString();
                            formAngajat.Nume = table.Rows[i]["Nume"].ToString();
                            this.Hide();
                            formAngajat.ShowDialog();
                            if (formAngajat.DialogResult == DialogResult.Cancel)
                            {
                                this.Show();
                                txtUtilizator.Clear();
                                txtParola.Clear();
                            }
                        }
                        else
                            if (table.Rows[i]["Rol"].ToString() == "Pacient")
                            {
                                FormClient formClient = new FormClient();
                                formClient.Id = Convert.ToInt32(table.Rows[i]["Id"]);
                                formClient.Username = table.Rows[i]["Username"].ToString();
                                formClient.Parola = table.Rows[i]["Parola"].ToString();
                                formClient.Email = table.Rows[i]["Email"].ToString();
                                formClient.Nume = table.Rows[i]["Nume"].ToString();
                                this.Hide();
                                formClient.ShowDialog();
                                if (formClient.DialogResult == DialogResult.Cancel)
                                {
                                    this.Show();
                                    txtUtilizator.Clear();
                                    txtParola.Clear();
                                }
                            }
                }

            }
            if (!utilizatorGasit)
            {
                errorProvider1.SetError(txtUtilizator, "Utilizator sau parolă greșită!");
                errorProvider2.SetError(txtParola, "Utilizator sau parolă greșită!");
                timer1.Stop();
                progressBarAutentificare.Value = 0;
                progressBarAutentificare.Visible = false;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                timer1.Stop();
                progressBarAutentificare.Value = 0;
                progressBarAutentificare.Visible = false;
            }
        }






        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBarAutentificare.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int pas = 2;
            if (progressBarAutentificare.Value < progressBarAutentificare.Maximum)
            {
                progressBarAutentificare.Value += pas;
                progressBarAutentificare.Value -= pas;
                progressBarAutentificare.Value += pas;
                if (progressBarAutentificare.Value >= progressBarAutentificare.Maximum / 2)
                {
                    pas = 3;
                    while (progressBarAutentificare.Value < progressBarAutentificare.Maximum && progressBarAutentificare.Value + pas <= progressBarAutentificare.Maximum)
                    {
                        progressBarAutentificare.Value += pas;
                        progressBarAutentificare.Value -= pas;
                        progressBarAutentificare.Value += pas;
                    }
                    pas = 2;
                }
            }
            else
            {
                timer1.Stop();
                Verificare_rol();


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timer2.Stop();
                CancelNow = true;
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!CancelNow)
            {
                e.Cancel = true;
                timer2.Start();
            }
        }

        private void txtUtilizator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtParola.Focus();
            }
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAutentificare.PerformClick();
            }
        }
    }
}
