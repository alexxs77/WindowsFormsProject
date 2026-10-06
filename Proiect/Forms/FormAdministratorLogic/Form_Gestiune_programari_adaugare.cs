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
    public partial class Form_Gestiune_programari_adaugare : Form
    {
        DataBaseConnection connection = new DataBaseConnection();
        List<string> listaDenumiri = new List<string>();
        public string Serviciu
        {
            get => cmbServiciu.Text;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Pret
        {
            get => numericUpDownPret.Value;

        }
        public DateTime DataProgramare
        {
            get => dateTimePicker.Value;
        }
        public Form_Gestiune_programari_adaugare()
        {
            InitializeComponent();
            LoadData_servicii();
            cmbServiciu.SelectedIndex = -1;
            foreach (DataRow rand in connection.table_servicii.Rows)
            {
                listaDenumiri.Add(rand["Denumire"].ToString());
            }
            cmbServiciu.DataSource = listaDenumiri;
            numericUpDownPret.ReadOnly = true;
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

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (cmbServiciu.SelectedIndex != -1 && numericUpDownPret.Value > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Eroare la selectarea serviciului sau introducerea pretului!");
            }
        }

        private void cmbServiciu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow rand in connection.table_servicii.Rows)
            {
                if (rand["Denumire"].ToString() == cmbServiciu.Text)
                    numericUpDownPret.Value = Convert.ToDecimal(rand["Pret"]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
