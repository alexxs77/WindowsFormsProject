using Proiect.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAngajatLogic
{
    public partial class FormSelectieUtilizatorAngajat : Form
    {
        DataBaseConnection connection = new DataBaseConnection();
        public int id;
        public string Nume;

        public FormSelectieUtilizatorAngajat()
        {
            InitializeComponent();
            dgvUtilizatori.AutoGenerateColumns = true;
            dgvUtilizatori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtilizatori.MultiSelect = false;
            dgvUtilizatori.ReadOnly = true;
            dgvUtilizatori.AllowUserToAddRows = false;
            dgvUtilizatori.AllowUserToDeleteRows = false;
            dgvUtilizatori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadData_utilizatori();
        }
        private void LoadData_utilizatori()
        {
            if (connection.adapter_utilizatori == null)
                return;
            try
            {
                connection.table_utilizatori.Clear();
                connection.adapter_utilizatori.Fill(connection.table_utilizatori);
                var table = connection.table_utilizatori;
                table.DefaultView.RowFilter = "Rol <> 'Administrator' and Rol <> 'Angajat'";
                dgvUtilizatori.DataSource = table;
                if (dgvUtilizatori.Columns["Id"] != null)
                {
                    dgvUtilizatori.Columns["Id"].Visible = false;
                    dgvUtilizatori.Columns["Parola"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }

        private void btnOKSelectie_Click(object sender, EventArgs e)
        {
            DataRowView randSelectat = dgvUtilizatori.CurrentRow.DataBoundItem as DataRowView;
            if (randSelectat != null)
            {
                id = Convert.ToInt32(randSelectat["Id"]);
                Nume = randSelectat["Nume"].ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelSelectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
