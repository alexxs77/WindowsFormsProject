using Proiect.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAdministratorLogic
{

    public partial class FormSelectieUtilizator : Form
    {
        DataBaseConnection connection = new DataBaseConnection();
        public int id;
        public string Nume;

        public FormSelectieUtilizator()
        {
            InitializeComponent();
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
                dgvUtilizatori.DataSource = connection.table_utilizatori;
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

        private void btnCancelSelectie_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
