using Microsoft.Data.SqlClient;
using Proiect.Classes;
using Proiect.Forms.FormAdministratorLogic;
using Proiect.Forms.FormAngajatLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormAngajat : Form
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

        private void InitializareComponente()
        {
            dgvPlati.AutoGenerateColumns = true;
            dgvPlati.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlati.MultiSelect = false;
            dgvPlati.ReadOnly = true;
            dgvPlati.AllowUserToAddRows = false;
            dgvPlati.AllowUserToDeleteRows = false;
            dgvPlati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvProgramari.AutoGenerateColumns = true;
            dgvProgramari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProgramari.MultiSelect = false;
            dgvProgramari.ReadOnly = true;
            dgvProgramari.AllowUserToAddRows = false;
            dgvProgramari.AllowUserToDeleteRows = false;
            dgvProgramari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvUtilizatori.AutoGenerateColumns = true;
            dgvUtilizatori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtilizatori.MultiSelect = false;
            dgvUtilizatori.ReadOnly = true;
            dgvUtilizatori.AllowUserToAddRows = false;
            dgvUtilizatori.AllowUserToDeleteRows = false;
            dgvUtilizatori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public FormAngajat()
        {
            InitializeComponent();
            InitializareComponente();
            if (connection.adapter_utilizatori != null)
                connection.adapter_utilizatori.RowUpdated += new SqlRowUpdatedEventHandler(InregistrareLog_RowUpdated);

            if (connection.adapter_programari != null)
                connection.adapter_programari.RowUpdated += new SqlRowUpdatedEventHandler(InregistrareLog_RowUpdated);

            if(connection.adapter_plati != null)
                connection.adapter_plati.RowUpdated += new SqlRowUpdatedEventHandler(InregistrareLog_RowUpdated);

            LoadData_plati();
            LoadData_utilizatori();
            LoadData_programari();
        }
        private void FormAngajat_Load(object sender, EventArgs e)
        {
            this.Text = $"Panou Angajat - {Username}";
        }

        #region Load_data
        private void LoadData_utilizatori()
        {
            if (connection.adapter_utilizatori == null)
                return;
            try
            {
                connection.table_utilizatori.Clear();
                connection.adapter_utilizatori.Fill(connection.table_utilizatori);
                var table = connection.table_utilizatori;
                table.DefaultView.RowFilter = "Rol = 'Pacient'";
                dgvUtilizatori.DataSource = table;
                if (dgvUtilizatori.Columns["Parola"] != null && dgvUtilizatori.Columns["Id"] != null)
                {
                    dgvUtilizatori.Columns["Parola"].Visible = false;
                    dgvUtilizatori.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }

        }

        private void LoadData_programari()
        {
            if (connection.adapter_programari == null)
                return;
            try
            {
                connection.table_programari.Clear();
                connection.adapter_programari.Fill(connection.table_programari);
                dgvProgramari.DataSource = connection.table_programari;
                if (dgvProgramari.Columns["Id"] != null)
                {
                    dgvProgramari.Columns["IdUtilizator"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }
        private void LoadData_plati()
        {
            if (connection.adapter_plati == null)
                return;
            try
            {
                connection.table_plati.Clear();
                connection.adapter_plati.Fill(connection.table_plati);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }
        #endregion

        #region Evenimente_butoane_cont
        private void btnContulMeu_Click(object sender, EventArgs e)
        {
            panelCont.Visible = true;
            panelPacienti.Visible = false;
            panelStatistica.Visible = false;
            panelProgramari.Visible = false;
            btnStatistica.BackColor = this.BackColor;
            btnGesProgramari.BackColor = this.BackColor;
            btnContulMeu.BackColor = Color.LightGray;
            btnGesUtilizatori.BackColor = this.BackColor;
            txtDetaliiUsername.Text = Username;
            txtDetaliiNume.Text = Nume;
            txtDetaliiParola.Text = Parola;
            txtDetaliiEmail.Text = Email;
            LoadData_utilizatori();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
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
            panelEmail.Visible = true;
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

        #endregion

        #region Evenimente_butoane_Pacienti

        private void btnGesUtilizatori_Click(object sender, EventArgs e)
        {
            panelCont.Visible = false;
            panelStatistica.Visible = false;
            panelProgramari.Visible = false;
            panelPacienti.Visible = true;
            btnStatistica.BackColor = this.BackColor;
            btnGesProgramari.BackColor = this.BackColor;
            btnContulMeu.BackColor = this.BackColor;
            btnGesUtilizatori.BackColor = Color.LightGray;
            LoadData_utilizatori();
        }

        private void btnStergerePacienti_Click(object sender, EventArgs e)
        {
            if (dgvUtilizatori.CurrentRow == null)
            {
                MessageBox.Show("Selectați un pacient pentru a șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvUtilizatori.CurrentRow.DataBoundItem as DataRowView;
            if (MessageBox.Show("Sigur doriti sa stergeti acest pacient?", "Confirmare stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                viewRow.Delete();
                connection.adapter_utilizatori!.Update(connection.table_utilizatori);
                LoadData_utilizatori();
            }
        }
        #endregion

        #region Evenimente_butoane_Programari
        private void btnGesProgramari_Click(object sender, EventArgs e)
        {
            panelProgramari.Visible = true;
            panelPacienti.Visible = false;
            panelCont.Visible = false;
            panelStatistica.Visible = false;
            btnGesProgramari.BackColor = Color.LightGray;
            btnStatistica.BackColor = this.BackColor;
            btnContulMeu.BackColor = this.BackColor;
            btnGesUtilizatori.BackColor = this.BackColor;
            LoadData_plati();
            LoadData_programari();
            dgvProgramari.ClearSelection();
            dgvPlati.DataSource = null;
        }

        private void dgvProgramari_SelectionChanged(object sender, EventArgs e)
        {
            dgvPlati.DataSource = null;
            var table = connection.table_plati;
            if (dgvProgramari.SelectedRows.Count == 0)
            {
                dgvPlati.DataSource = null;
                return; 
            }
            if (dgvProgramari.CurrentRow != null)
            {
                var id = dgvProgramari.CurrentRow.Cells["Id"].Value;

                if (id != null && id!= DBNull.Value && !string.IsNullOrWhiteSpace(id.ToString()))
                {
                    table.DefaultView.RowFilter = $"IdProgramare = {id}";
                }
                else
                {
                    table.DefaultView.RowFilter = string.Empty;
                }
            }

            dgvPlati.DataSource = table;
            if (dgvPlati.Columns["Id"] != null)
            {
                dgvPlati.Columns["Id"].Visible = false;
                dgvPlati.Columns["Suma"].Visible = false;
                dgvPlati.Columns["StatusPlata"].Visible = false;

            }
            //dgvProgramari.ClearSelection();
        }

        private void btnAdaugaProgramare_Click(object sender, EventArgs e)
        {
            int id = 0, idutilizator;
            FormSelectieUtilizatorAngajat frmselectieutilizator = new FormSelectieUtilizatorAngajat();
            Form_Gestiune_programari_adaugare frm = new Form_Gestiune_programari_adaugare();
            Form_Gestiune_plati_adaugare frm_plati = new Form_Gestiune_plati_adaugare();
            if (frmselectieutilizator.ShowDialog() == DialogResult.OK)
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = connection.table_programari.NewRow();
                    row["IdUtilizator"] = frmselectieutilizator.id;
                    idutilizator = frmselectieutilizator.id;
                    row["Pacient"] = frmselectieutilizator.Nume;
                    row["Serviciu"] = frm.Serviciu;
                    row["DataProgramare"] = frm.DataProgramare;
                    row["Pret"] = frm.Pret;
                    connection.table_programari.Rows.Add(row);
                    try
                    {
                        connection.adapter_programari!.Update(connection.table_programari);
                        LoadData_programari();

                    }
                    catch
                    {
                        MessageBox.Show("Exista deja o programare pe aceasta ora!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    for (int i = connection.table_programari.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow row_programari = connection.table_programari.Rows[i];
                        if ((int)row_programari["IdUtilizator"] == idutilizator && (string)row_programari["Serviciu"] == frm.Serviciu)
                        {
                            id = (int)row_programari["Id"];
                            break;
                        }
                    }
                    if (frm_plati.ShowDialog() == DialogResult.OK)
                    {
                        DataRow row_plati = connection.table_plati.NewRow();
                        row_plati["IdProgramare"] = id;
                        row_plati["Suma"] = frm.Pret;
                        row_plati["MetodaPlata"] = frm_plati.MetodaPlata;
                        connection.table_plati.Rows.Add(row_plati);
                        connection.adapter_plati!.Update(connection.table_plati);
                    }
                }

                LoadData_programari();
            }
            LoadData_plati();
        }

        private void btnModificaProgramare_Click(object sender, EventArgs e)
        {
            if (dgvProgramari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați o programare pentru a modifica!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvProgramari.CurrentRow.DataBoundItem as DataRowView;
            Form_Gestiune_programari_modificare frm = new Form_Gestiune_programari_modificare();
            frm.Status = (string)viewRow["Status"];
            frm.Data = (DateTime)viewRow["DataProgramare"];
            if (frm.Status.ToString().Trim() != "Finalizat")
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    viewRow.BeginEdit();
                    viewRow["DataProgramare"] = frm.Data;
                    viewRow["Status"] = frm.Status;
                    viewRow.EndEdit();
                    try
                    {
                        connection.adapter_programari!.Update(connection.table_programari);
                        LoadData_programari();
                    }
                    catch
                    {
                        MessageBox.Show("Exista deja o programare pe aceasta ora!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Programarea este finalizata, nu mai poate fi modificata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData_plati();
        }

        private void btnStergeProgramare_Click(object sender, EventArgs e)
        {
            if (dgvProgramari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați o programare pentru a șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvProgramari.CurrentRow.DataBoundItem as DataRowView;
            if (MessageBox.Show("Sigur doriti sa stergeti aceasta programare?", "Confirmare stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                viewRow.Delete();
                connection.adapter_programari!.Update(connection.table_programari);
                LoadData_programari();
                dgvProgramari.ClearSelection();
            }
            LoadData_plati();
        }

        private void cmbsortareprog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsortareprog.SelectedItem != null)
            {
                switch (cmbsortareprog.SelectedItem.ToString())
                {
                    case "DataProgramareCrescator":
                        connection.table_programari.DefaultView.Sort = "DataProgramare ASC";
                        break;
                    case "PacientCrescator":
                        connection.table_programari.DefaultView.Sort = "Pacient ASC";
                        break;
                    case "DataProgramareDescrescator":
                        connection.table_programari.DefaultView.Sort = "DataProgramare DESC";
                        break;
                    case "PacientDescrescator":
                        connection.table_programari.DefaultView.Sort = "Pacient DESC";
                        break;
                    case "PretCrescator":
                        connection.table_programari.DefaultView.Sort = "Pret ASC";
                        break;
                    case "PretDescrescator":
                        connection.table_programari.DefaultView.Sort = "Pret DESC";
                        break;
                }
                dgvProgramari.ClearSelection();
            }
        }
        private void btnCautareProg_Click(object sender, EventArgs e)
        {

            if (cmbfiltruprog.SelectedIndex != -1 && !string.IsNullOrEmpty(txtdenumireprog.Text))
            {
                if (cmbfiltruprog.Text == "Pacient")
                    connection.table_programari.DefaultView.RowFilter = $"Pacient LIKE '%{txtdenumireprog.Text}%'";
                else if (cmbfiltruprog.Text == "Serviciu")
                    connection.table_programari.DefaultView.RowFilter = $"Serviciu LIKE '%{txtdenumireprog.Text}%'";
                else if (cmbfiltruprog.Text == "Status")
                    connection.table_programari.DefaultView.RowFilter = $"Status LIKE '%{txtdenumireprog.Text}%'";
                else if (cmbfiltruprog.Text == "Pret")
                {
                    if (decimal.TryParse(txtdenumireprog.Text, out decimal pretCautat))
                    {
                        string pretFormatatCorect = pretCautat.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        connection.table_programari.DefaultView.RowFilter = $"Pret = {pretFormatatCorect}";
                    }
                    else
                        MessageBox.Show("Introduceți un preț valid pentru filtrare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvProgramari.ClearSelection();
            }
        }


        private void btnResetProg_Click(object sender, EventArgs e)
        {
            connection.table_programari.DefaultView.RowFilter = "";
            cmbfiltruprog.SelectedIndex = -1;
            cmbsortareprog.SelectedIndex = -1;
            txtdenumireprog.Clear();
            dgvProgramari.ClearSelection();
        }


        #endregion

        #region Evenimente_butoane_Statistica

        private void btnStatistica_Click(object sender, EventArgs e)
        {
            panelProgramari.Visible = false;
            panelPacienti.Visible = false;
            panelCont.Visible = false;
            panelStatistica.Visible = true;
            btnGesProgramari.BackColor = this.BackColor;
            btnStatistica.BackColor = Color.LightGray;
            btnContulMeu.BackColor = this.BackColor;
            btnGesUtilizatori.BackColor = this.BackColor;
            StatisticaPacientiAzi();
        }
        private void InregistrareLog_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            
            if (e.Status == UpdateStatus.Continue && e.RecordsAffected > 0)
            {
                string actiune = "";
                if (e.StatementType == StatementType.Insert) actiune = "Adăugare";
                else if (e.StatementType == StatementType.Update) actiune = "Modificare";
                else if (e.StatementType == StatementType.Delete) actiune = "Ștergere";
                string tabel = e.TableMapping.DataSetTable;
                string log = $"[{DateTime.Now:HH:mm:ss}] {actiune} cu succes în '{tabel}'. (Rânduri: {e.RecordsAffected})";
                listBoxLoggari.Items.Add(log);
                listBoxLoggari.TopIndex = listBoxLoggari.Items.Count - 1;
            }
        }


        private void StatisticaPacientiAzi()
        {
            if (connection.table_programari.Rows.Count == 0) return;

            chart1.Series.Clear();
            chart1.Titles.Clear();

            var serie = chart1.Series.Add("Pacienti");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            int pacientiAzi = 0;
            int pacientiAlteZile = 0;
            foreach (DataRow rand in connection.table_programari.Rows)
            {
                string status = rand["Status"].ToString().Trim();
                if (status == "In asteptare")
                {
                    DateTime dataProgramare;
                    if (DateTime.TryParse(rand["DataProgramare"].ToString(), out dataProgramare))
                    {
                        if (dataProgramare.Date == DateTime.Today)
                            pacientiAzi++;
                        else
                            pacientiAlteZile++; 
                    }
                }
            }

            chart1.Titles.Add($"Programări în așteptare\nAzi: {pacientiAzi}");
            if (pacientiAzi > 0)
            {
                int index = serie.Points.AddXY("Azi", pacientiAzi);
                serie.Points[index].Color = Color.DodgerBlue; 
            }

            if (pacientiAlteZile > 0)
            {
                int index = serie.Points.AddXY("Alte zile", pacientiAlteZile);
                serie.Points[index].Color = Color.LightGray; 
            }

            serie.IsValueShownAsLabel = true;

            chart1.BackColor = Color.Transparent;
            chart1.ChartAreas[0].BackColor = Color.Transparent;

            if (chart1.Legends.Count > 0)
            {
                chart1.Legends[0].Enabled = true;
                chart1.Legends[0].BackColor = Color.Transparent;
            }
        }



        #endregion

    }
}
