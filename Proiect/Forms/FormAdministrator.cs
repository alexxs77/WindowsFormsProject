using Microsoft.Data.SqlClient;
using Proiect.Classes;
using Proiect.Forms.FormAdministratorLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace Proiect
{
    public partial class FormAdministrator : Form
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


        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            this.Text = $"Panou Administrator - {Username}";

        }

        private void InitializareComponente()
        {
            panelUtilizatori.Visible = false;
            panelServicii.Visible = false;
            panelPlati.Visible = false;
            panelProgramari.Visible = false;
            panelCont.Visible = false;
            panelStatistica.Visible = false;


            dgvUtilizatori.AutoGenerateColumns = true;
            dgvUtilizatori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtilizatori.MultiSelect = false;
            dgvUtilizatori.ReadOnly = true;
            dgvUtilizatori.AllowUserToAddRows = false;
            dgvUtilizatori.AllowUserToDeleteRows = false;
            dgvUtilizatori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvServicii.AutoGenerateColumns = true;
            dgvServicii.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicii.MultiSelect = false;
            dgvServicii.ReadOnly = true;
            dgvServicii.AllowUserToAddRows = false;
            dgvServicii.AllowUserToDeleteRows = false;
            dgvServicii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        }


        public FormAdministrator()
        {
            InitializeComponent();
            InitializareComponente();
            LoadData_utilizatori();
            LoadData_servicii();
            LoadData_programari();
            LoadData_plati();
            IncarcaStatisticaServicii();
            StatisticaSumaPlati();
            connection.connection.InfoMessage += new SqlInfoMessageEventHandler(InterceptareMesajeSql);
            connection.adapter_utilizatori.RowUpdated += new SqlRowUpdatedEventHandler(InregistrareModificari_RowUpdated);
            connection.adapter_servicii.RowUpdated += new SqlRowUpdatedEventHandler(InregistrareModificari_RowUpdated);
            connection.adapter_programari.RowUpdated += new SqlRowUpdatedEventHandler(InregistrareModificari_RowUpdated);
            connection.adapter_plati.RowUpdated += new SqlRowUpdatedEventHandler(InregistrareModificari_RowUpdated);
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
                dgvUtilizatori.DataSource = connection.table_utilizatori;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }

        }
        private void LoadData_servicii()
        {
            if (connection.adapter_servicii == null)
                return;
            try
            {
                connection.table_servicii.Clear();
                connection.adapter_servicii.Fill(connection.table_servicii);
                dgvServicii.DataSource = connection.table_servicii;
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
                dgvPlati.DataSource = connection.table_plati;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }
        #endregion

        #region Verificari

        private bool Verificare()
        {
            int count = 0;
            for (int i = 0; i < connection.table_utilizatori.Rows.Count; i++)
                if (connection.table_utilizatori.Rows[i]["Rol"].ToString() == "Administrator")
                    count = count + 1;
            if (count <= 1)
                return false;
            return true;
        }

        #endregion

        #region Evenimente_butoane_utilizatori
        private void btnGesUtilizatori_Click(object sender, EventArgs e)
        {
            panelUtilizatori.Visible = true;
            panelProgramari.Visible = false;
            panelServicii.Visible = false;
            panelPlati.Visible = false;
            panelCont.Visible = false;
            panelStatistica.Visible = false;
            btnContulMeu.BackColor = this.BackColor;
            btnGesProgramari.BackColor = this.BackColor;
            btnGesUtilizatori.BackColor = Color.LightGray;
            btnGesServicii.BackColor = this.BackColor;
            btnGesPlati.BackColor = this.BackColor;
            btnStatistica.BackColor = this.BackColor;
            LoadData_utilizatori();
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com)$";
            Form_Gestiune_adaugare frm_gestiune_adaugare = new Form_Gestiune_adaugare();
            if (frm_gestiune_adaugare.ShowDialog() == DialogResult.OK)
            {
                DataRow row = connection.table_utilizatori.NewRow();
                row["Username"] = frm_gestiune_adaugare.Username;
                row["Parola"] = frm_gestiune_adaugare.Parola;
                row["Nume"] = frm_gestiune_adaugare.Nume;
                if (!Regex.IsMatch(frm_gestiune_adaugare.Email, pattern))
                {
                    MessageBox.Show("Adresa de email trebuie sa fie valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                row["Email"] = frm_gestiune_adaugare.Email;
                row["Rol"] = frm_gestiune_adaugare.Rol;
                try
                {
                    connection.table_utilizatori.Rows.Add(row);
                    connection.adapter_utilizatori.Update(connection.table_utilizatori);
                    LoadData_utilizatori();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la adaugare(email existent).Reincearca cu alt email!");
                }
            }

        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com)$";
            DataRowView? viewRow = dgvUtilizatori.CurrentRow.DataBoundItem as DataRowView;
            Form_Gestiune_modificare frm_gestiune_modificare = new Form_Gestiune_modificare();
            frm_gestiune_modificare.Username = (string)viewRow["Username"];
            frm_gestiune_modificare.Parola = (string)viewRow["Parola"];
            frm_gestiune_modificare.Nume = (string)viewRow["Nume"];
            frm_gestiune_modificare.Email = (string)viewRow["Email"];
            frm_gestiune_modificare.Rol = (string)viewRow["Rol"];
            if (Verificare() == false && frm_gestiune_modificare.Rol == "Administrator")
            {
                frm_gestiune_modificare.cmbRolVisible = false;
                frm_gestiune_modificare.labelVisible = false;

            }
            else
            {
                frm_gestiune_modificare.cmbRolVisible = true;
                frm_gestiune_modificare.labelVisible = true;
            }
            if (frm_gestiune_modificare.ShowDialog() == DialogResult.OK)
            {
                viewRow.BeginEdit();
                viewRow["Username"] = frm_gestiune_modificare.Username;
                viewRow["Parola"] = frm_gestiune_modificare.Parola;
                viewRow["Nume"] = frm_gestiune_modificare.Nume;
                if (!Regex.IsMatch(frm_gestiune_modificare.Email, pattern))
                {
                    MessageBox.Show("Adresa de email trebuie sa fie valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                viewRow["Email"] = frm_gestiune_modificare.Email;
                viewRow["Rol"] = frm_gestiune_modificare.Rol;
                viewRow.EndEdit();
                connection.adapter_utilizatori!.Update(connection.table_utilizatori);
                LoadData_utilizatori();
            }
        }


        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvUtilizatori.CurrentRow == null)
            {
                MessageBox.Show("Selectați un utilizator pentru a șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvUtilizatori.CurrentRow.DataBoundItem as DataRowView;
            string rolSelectat = viewRow["Rol"].ToString();

            if (rolSelectat == "Administrator" && Verificare() == false)
            {
                MessageBox.Show("Nu poți șterge singurul administrator din sistem!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Sigur doriti sa stergeti acest utilizator?", "Confirmare stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                viewRow.Delete();
                connection.adapter_utilizatori!.Update(connection.table_utilizatori);
                LoadData_utilizatori();
            }

        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Evenimente_butoane_servicii
        private void btnGesServicii_Click_1(object sender, EventArgs e)
        {
            panelUtilizatori.Visible = false;
            panelProgramari.Visible = false;
            panelServicii.Visible = true;
            panelPlati.Visible = false;
            panelCont.Visible = false;
            panelStatistica.Visible = false;
            btnContulMeu.BackColor = this.BackColor;
            btnGesProgramari.BackColor = this.BackColor;
            btnGesServicii.BackColor = Color.LightGray;
            btnGesUtilizatori.BackColor = this.BackColor;
            btnGesPlati.BackColor = this.BackColor;
            btnStatistica.BackColor = this.BackColor;
            cmbSortare.DataSource = Enum.GetValues(typeof(EnumerareSortare));
            cmbSortare.SelectedIndex = -1;

            LoadData_servicii();


        }


        private void btnAdaugaServicii_Click(object sender, EventArgs e)
        {
            Form_Gestiune_servicii_adaugare frm = new Form_Gestiune_servicii_adaugare();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow row = connection.table_servicii.NewRow();
                row["Denumire"] = frm.Denumire;
                row["Descriere"] = frm.Descriere;
                row["Pret"] = frm.Pret;
                connection.table_servicii.Rows.Add(row);
                connection.adapter_servicii!.Update(connection.table_servicii);
                LoadData_servicii();
            }
        }
        private void btnStergeServicii_Click(object sender, EventArgs e)
        {
            if (dgvServicii.CurrentRow == null)
            {
                MessageBox.Show("Selectați un serviciu pentru a șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvServicii.CurrentRow.DataBoundItem as DataRowView;
            if (MessageBox.Show("Sigur doriti sa stergeti acest serviciu?", "Confirmare stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                viewRow.Delete();
                connection.adapter_servicii!.Update(connection.table_servicii);
                LoadData_servicii();
            }
        }

        private void btnModificaServicii_Click(object sender, EventArgs e)
        {
            if (dgvServicii.CurrentRow == null)
            {
                MessageBox.Show("Selectați un serviciu pentru a modifica!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvServicii.CurrentRow.DataBoundItem as DataRowView;
            Form_Gestiune_servicii_modificare frm = new Form_Gestiune_servicii_modificare();
            frm.Denumire = (string)viewRow["Denumire"];
            frm.Descriere = (string)viewRow["Descriere"];
            frm.Pret = (decimal)viewRow["Pret"];
            if (frm.ShowDialog() == DialogResult.OK)
            {
                viewRow.BeginEdit();
                viewRow["Denumire"] = frm.Denumire;
                viewRow["Descriere"] = frm.Descriere;
                viewRow["Pret"] = frm.Pret;
                viewRow.EndEdit();
                connection.adapter_servicii!.Update(connection.table_servicii);
                LoadData_servicii();
            }
        }

        private void cmbSortare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortare.SelectedItem != null)
            {
                EnumerareSortare sortareSelectata = (EnumerareSortare)Enum.Parse(typeof(EnumerareSortare), cmbSortare.SelectedItem.ToString());

                switch (sortareSelectata)
                {
                    case EnumerareSortare.AlfabeticCrescatorDupaDenumire:
                        connection.table_servicii.DefaultView.Sort = "Denumire ASC";
                        break;

                    case EnumerareSortare.AlfabeticDescrescatorDupaDenumire:
                        connection.table_servicii.DefaultView.Sort = "Denumire DESC";
                        break;

                    case EnumerareSortare.DupaPretCrescator:
                        connection.table_servicii.DefaultView.Sort = "Pret ASC";
                        break;
                    case EnumerareSortare.DupaPretDescrescator:
                        connection.table_servicii.DefaultView.Sort = "Pret DESC";
                        break;
                }
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            if (cmbFiltruCautare.SelectedItem != null && !string.IsNullOrEmpty(txtCautare.Text))
            {
                if (cmbFiltruCautare.Text == "Denumire")
                    connection.table_servicii.DefaultView.RowFilter = $"Denumire LIKE '%{txtCautare.Text}%'";
                else if (cmbFiltruCautare.Text == "Descriere")
                    connection.table_servicii.DefaultView.RowFilter = $"Descriere LIKE '%{txtCautare.Text}%'";
                else if (cmbFiltruCautare.Text == "Pret")
                {
                    if (decimal.TryParse(txtCautare.Text, out decimal pretCautat))
                    {
                        string pretFormatatCorect = pretCautat.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        connection.table_servicii.DefaultView.RowFilter = $"Pret = {pretFormatatCorect}";

                    }
                    else
                        MessageBox.Show("Introduceți un preț valid pentru filtrare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            connection.table_servicii.DefaultView.RowFilter = "";
            txtCautare.Clear();
            cmbFiltruCautare.SelectedIndex = -1;
            cmbSortare.SelectedIndex = -1;
        }


        #endregion

        #region Evenimente_butoane_plati
        private void btnGesPlati_Click(object sender, EventArgs e)
        {
            panelUtilizatori.Visible = false;
            panelProgramari.Visible = false;
            panelServicii.Visible = false;
            panelPlati.Visible = true;
            panelCont.Visible = false;
            panelStatistica.Visible = false;
            btnGesProgramari.BackColor = this.BackColor;
            btnGesServicii.BackColor = this.BackColor;
            btnGesUtilizatori.BackColor = this.BackColor;
            btnContulMeu.BackColor = this.BackColor;
            btnGesPlati.BackColor = Color.LightGray;
            btnStatistica.BackColor = this.BackColor;
            cmbSortarePlati.DataSource = Enum.GetValues(typeof(EnumerareSortarePlati));
            cmbSortarePlati.SelectedIndex = -1;

            LoadData_plati();
        }
        private void btnModificaPlati_Click(object sender, EventArgs e)
        {
            if (dgvPlati.CurrentRow == null)
            {
                MessageBox.Show("Selectați o plata pentru a modifica!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvPlati.CurrentRow.DataBoundItem as DataRowView;
            Form_Gestiune_plati_modificare frm = new Form_Gestiune_plati_modificare();
            frm.SumaPlata = (decimal)viewRow["Suma"];
            frm.MetodaPlata = (string)viewRow["MetodaPlata"];
            frm.StatusPlata = (string)viewRow["StatusPlata"];
            if (frm.ShowDialog() == DialogResult.OK)
            {
                viewRow.BeginEdit();
                viewRow["Suma"] = frm.SumaPlata;
                // viewRow["DataPlata"] = frm.DataPlata;
                viewRow["MetodaPlata"] = frm.MetodaPlata;
                viewRow["StatusPlata"] = frm.StatusPlata;
                viewRow.EndEdit();
                connection.adapter_plati!.Update(connection.table_plati);
                LoadData_plati();
            }
            StatisticaSumaPlati();

        }

        private void btnStergePlati_Click(object sender, EventArgs e)
        {
            if (dgvPlati.CurrentRow == null)
            {
                MessageBox.Show("Selectați o plata pentru a șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvPlati.CurrentRow.DataBoundItem as DataRowView;
            if (MessageBox.Show("Sigur doriti sa stergeti aceasta plata?", "Confirmare stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                viewRow.Delete();
                connection.adapter_plati!.Update(connection.table_plati);
                LoadData_plati();
            }
            StatisticaSumaPlati();
        }

        private void cmbSortarePlati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortarePlati.SelectedItem != null)
            {
                EnumerareSortarePlati sortareSelectata = (EnumerareSortarePlati)Enum.Parse(typeof(EnumerareSortarePlati), cmbSortarePlati.SelectedItem.ToString());

                switch (sortareSelectata)
                {
                    case EnumerareSortarePlati.SumaCrescator:
                        connection.table_plati.DefaultView.Sort = "Suma ASC";
                        break;

                    case EnumerareSortarePlati.SumaDescrescator:
                        connection.table_plati.DefaultView.Sort = "Suma DESC";
                        break;

                    case EnumerareSortarePlati.DataPlataCrescator:
                        connection.table_plati.DefaultView.Sort = "DataPlata ASC";
                        break;
                    case EnumerareSortarePlati.DataPlataDescrescator:
                        connection.table_plati.DefaultView.Sort = "DataPlata DESC";
                        break;
                }
            }
        }

        private void btnCautarePlati_Click(object sender, EventArgs e)
        {
            if (cmbFiltruPlati.SelectedIndex != -1 && !string.IsNullOrEmpty(txtDenumirePlati.Text))
            {
                if (cmbFiltruPlati.Text == "Suma")
                {
                    if (decimal.TryParse(txtDenumirePlati.Text, out decimal sumaCautata))
                    {
                        string sumaFormatataCorect = sumaCautata.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        connection.table_plati.DefaultView.RowFilter = $"Suma = {sumaFormatataCorect}";
                    }
                    else
                        MessageBox.Show("Introduceți o sumă validă pentru filtrare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbFiltruPlati.Text == "MetodaPlata")
                    connection.table_plati.DefaultView.RowFilter = $"MetodaPlata LIKE '%{txtDenumirePlati.Text}%'";
                else if (cmbFiltruPlati.Text == "StatusPlata")
                    connection.table_plati.DefaultView.RowFilter = $"StatusPlata LIKE '%{txtDenumirePlati.Text}%'";
            }
        }

        private void btnResetPlati_Click(object sender, EventArgs e)
        {
            connection.table_plati.DefaultView.RowFilter = "";
            cmbFiltruPlati.SelectedIndex = -1;
            cmbSortarePlati.SelectedIndex = -1;
            txtDenumirePlati.Clear();
        }



        #endregion

        #region Evenimente_butoane_programari

        private void btnGesProgramari_Click(object sender, EventArgs e)
        {
            panelUtilizatori.Visible = false;
            panelServicii.Visible = false;
            panelPlati.Visible = false;
            panelProgramari.Visible = true;
            panelCont.Visible = false;
            panelStatistica.Visible = false;
            btnGesUtilizatori.BackColor = this.BackColor;
            btnGesServicii.BackColor = this.BackColor;
            btnGesPlati.BackColor = this.BackColor;
            btnGesProgramari.BackColor = Color.LightGray;
            btnContulMeu.BackColor = this.BackColor;
            btnStatistica.BackColor = this.BackColor;
            connection.table_programari.DefaultView.Sort = "Id ASC";
            LoadData_programari();
        }


        public void btnAdaugaProgramari_Click(object sender, EventArgs e)
        {
            int id = 0, idutilizator;
            FormSelectieUtilizator frmselectieutilizator = new FormSelectieUtilizator();
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exista deja o programare pe aceasta ora!: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LoadData_servicii();
            }
            IncarcaStatisticaServicii();
            LoadData_plati();
            StatisticaSumaPlati();
        }
        private void btnStergeProgramari_Click(object sender, EventArgs e)
        {
            if (dgvProgramari.CurrentRow == null)
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
            }
            IncarcaStatisticaServicii();
            LoadData_plati();
            StatisticaSumaPlati();
        }

        public void btnModificaProgramari_Click(object sender, EventArgs e)
        {
            if (dgvProgramari.CurrentRow == null)
            {
                MessageBox.Show("Selectați o programare pentru a modifica!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRowView? viewRow = dgvProgramari.CurrentRow.DataBoundItem as DataRowView;
            Form_Gestiune_programari_modificare frm = new Form_Gestiune_programari_modificare();
            frm.Status = (string)viewRow["Status"];
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
                catch (Exception ex)
                {
                    MessageBox.Show("Exista deja o programare pe aceasta ora!: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData_plati();
            StatisticaSumaPlati();

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
            }
        }

        private void btnResetProg_Click(object sender, EventArgs e)
        {
            connection.table_programari.DefaultView.RowFilter = "";
            cmbfiltruprog.SelectedIndex = -1;
            cmbsortareprog.SelectedIndex = -1;
            txtdenumireprog.Clear();
        }


        #endregion

        #region Evenimente_butoane_cont
        private void btnContulMeu_Click(object sender, EventArgs e)
        {
            panelUtilizatori.Visible = false;
            panelProgramari.Visible = false;
            panelServicii.Visible = false;
            panelPlati.Visible = false;
            panelStatistica.Visible = false;
            panelCont.Visible = true;
            btnGesProgramari.BackColor = this.BackColor;
            btnGesUtilizatori.BackColor = this.BackColor;
            btnGesServicii.BackColor = this.BackColor;
            btnGesPlati.BackColor = this.BackColor;
            btnStatistica.BackColor = this.BackColor;
            btnContulMeu.BackColor = Color.LightGray;
            txtDetaliiUsername.Text = Username;
            txtDetaliiNume.Text = Nume;
            txtDetaliiParola.Text = Parola;
            txtDetaliiEmail.Text = Email;
            LoadData_utilizatori();

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
                    MessageBox.Show($"A apărut o eroare la actualizarea email-ului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Vă rugăm să completați corect câmpurile pentru modificare/email vechi invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Evenimente_butoane_statistica
        private void btnStatistica_Click(object sender, EventArgs e)
        {
            panelUtilizatori.Visible = false;
            panelProgramari.Visible = false;
            panelServicii.Visible = false;
            panelPlati.Visible = false;
            panelStatistica.Visible = true;
            panelCont.Visible = false;
            btnGesProgramari.BackColor = this.BackColor;
            btnGesUtilizatori.BackColor = this.BackColor;
            btnGesServicii.BackColor = this.BackColor;
            btnGesPlati.BackColor = this.BackColor;
            btnStatistica.BackColor = Color.LightGray;
            btnContulMeu.BackColor = this.BackColor;
        }

        private void IncarcaStatisticaServicii()
        {
            if (connection.table_programari.Rows.Count == 0) return;


            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Popularitatea Serviciilor");

            var serie = chart1.Series.Add("Servicii");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            Dictionary<string, int> contorServicii = new Dictionary<string, int>();
            foreach (DataRow rand in connection.table_programari.Rows)
            {
                string numeServiciu = rand["Serviciu"].ToString();
                if (contorServicii.ContainsKey(numeServiciu))
                {
                    contorServicii[numeServiciu] = contorServicii[numeServiciu] + 1;
                }

                else
                {
                    contorServicii.Add(numeServiciu, 1);
                }
            }


            foreach (KeyValuePair<string, int> element in contorServicii)
            {
                serie.Points.AddXY(element.Key, element.Value);
            }

            serie.IsValueShownAsLabel = true;
            chart1.BackColor = Color.Transparent;
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.Legends[0].BackColor = Color.Transparent;
            chart1.Legends[0].Enabled = true;
        }


        private void StatisticaSumaPlati()
        {
            if (connection.table_plati.Rows.Count == 0) return;
            chart2.Series.Clear();
            chart2.Titles.Clear();

            var series = chart2.Series.Add("Plati");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            decimal sumaIncasata = 0;
            decimal sumaNeincasata = 0;

            foreach (DataRow row in connection.table_plati.Rows)
            {
                if (row["StatusPlata"].ToString() == "Platit")
                {
                    sumaIncasata += Convert.ToDecimal(row["Suma"]);
                }
                else if (row["StatusPlata"].ToString() == "Neplatit")
                {
                    sumaNeincasata += Convert.ToDecimal(row["Suma"]);
                }
            }
            chart2.Titles.Add($"Status Incasari \nTotal: {sumaIncasata + sumaNeincasata:F2} Lei");
            if (sumaIncasata > 0)
            {
                int index = series.Points.AddXY("Incasata", sumaIncasata);
                series.Points[index].Color = Color.Green;
            }
            if (sumaNeincasata > 0)
            {
                int index = series.Points.AddXY("Neincasata", sumaNeincasata);
                series.Points[index].Color = Color.Red;
            }
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0} Lei";
            chart2.BackColor = Color.Transparent;
            chart2.ChartAreas[0].BackColor = Color.Transparent;
            chart2.Legends[0].BackColor = Color.Transparent;
            chart2.Legends[0].Enabled = true;
        }

        private void InterceptareMesajeSql(object sender, SqlInfoMessageEventArgs e)
        {
            string log = $"[{DateTime.Now:HH:mm:ss}] Info SQL: {e.Message}";
            listBoxLoggari.Items.Add(log);
            listBoxLoggari.TopIndex = listBoxLoggari.Items.Count - 1;
        }

        private void InregistrareModificari_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.RecordsAffected > 0)
            {
                string actiune = "";


                if (e.StatementType == StatementType.Insert) actiune = "Adăugare";
                else if (e.StatementType == StatementType.Update) actiune = "Modificare";
                else if (e.StatementType == StatementType.Delete) actiune = "Ștergere";

                string tabel = e.TableMapping.DataSetTable;

                string log = $"[{DateTime.Now:HH:mm:ss}] {actiune} reușită în '{tabel}'. (Rânduri afectate: {e.RecordsAffected})";

                listBoxLoggari.Items.Add(log);
                listBoxLoggari.TopIndex = listBoxLoggari.Items.Count - 1;
            }
        }
        #endregion

       


    }
}