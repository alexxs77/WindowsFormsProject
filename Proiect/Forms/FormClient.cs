using Proiect.Classes;
using Proiect.Forms.FormAdministratorLogic;
using Proiect.Forms.FormClientLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormClient : Form
    {
        DataBaseConnection connection = new DataBaseConnection();


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Parola { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nume { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Email { get; set; }

        public FormClient()
        {
            InitializeComponent();
            LoadData_utilizatori();
            LoadData_programari();
            LoadData_servicii();
            LoadData_plati();
            this.Text = "Bine ai venit!";
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            label1.Text = $"Bine ai venit, {Nume}!";
        }

        #region LoadData
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
        private void LoadData_programari()
        {
            if (connection.adapter_programari == null)
                return;
            try
            {
                connection.table_programari.Clear();
                connection.adapter_programari.Fill(connection.table_programari);
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

        #region Evenimente
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDetaliiCont_Click(object sender, EventArgs e)
        {
            FormClientCont frm = new FormClientCont();
            frm.Username = Username;
            frm.Nume = Nume;
            frm.Email = Email;
            frm.Parola = Parola;
            this.Hide();
            frm.ShowDialog();
            Username = frm.Username;
            Nume = frm.Nume;
            Email = frm.Email;
            Parola = frm.Parola;
            label1.Text = $"Bine ai venit, {Nume}!";
            this.Show();
        }

        private void btnAdaugaProgramare_Click(object sender, EventArgs e)
        {
            int id = 0, idutilizator;
            Form_Gestiune_programari_adaugare frm = new Form_Gestiune_programari_adaugare();
            Form_Gestiune_plati_adaugare frm_plati = new Form_Gestiune_plati_adaugare();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow row = connection.table_programari.NewRow();
                row["IdUtilizator"] = Id;
                idutilizator = Id;
                row["Pacient"] = Nume;
                row["Serviciu"] = frm.Serviciu;
                row["DataProgramare"] = frm.DataProgramare;
                row["Pret"] = frm.Pret;
                connection.table_programari.Rows.Add(row);
                connection.adapter_programari!.Update(connection.table_programari);
                LoadData_programari();
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

            LoadData_plati();
        }


        #endregion




        private void btnIstoric_Click(object sender, EventArgs e)
        {
            FormIstoricProgramari frm = new FormIstoricProgramari();
            frm.Id = Id;
            frm.ShowDialog();
        }
    }
}
