using Proiect.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proiect.Forms.FormClientLogic
{
    public partial class FormIstoricProgramari : Form
    {
        DataBaseConnection connection = new DataBaseConnection();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { get; set; }
        public FormIstoricProgramari()
        {
            InitializeComponent();

            dgvProgramari.AutoGenerateColumns = true;
            dgvProgramari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProgramari.MultiSelect = false;
            dgvProgramari.ReadOnly = true;
            dgvProgramari.AllowUserToAddRows = false;
            dgvProgramari.AllowUserToDeleteRows = false;
            dgvProgramari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Text = "Istoric programari";
        }
        #region Load_data


        private void LoadData_programari()
        {
            if (connection.adapter_programari == null)
                return;
            try
            {
                connection.table_programari.Clear();
                connection.adapter_programari.Fill(connection.table_programari);
                var table = connection.table_programari;
                table.DefaultView.RowFilter = $"idUtilizator = {Id}";
                dgvProgramari.DataSource = table;
                dgvProgramari.Columns["IdUtilizator"].Visible = false;
                dgvProgramari.Columns["Id"].Visible = false;
                dgvProgramari.ClearSelection();
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
        private void FormIstoricProgramari_Load(object sender, EventArgs e)
        {
            LoadData_programari();
        }

        private void cmbFiltru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltru.SelectedItem != null)
                switch (cmbFiltru.SelectedItem.ToString())
                {
                    case "DataCrescator":
                        connection.table_programari.DefaultView.Sort = "DataProgramare ASC";
                        break;
                    case "DataDescrescator":
                        connection.table_programari.DefaultView.Sort = "DataProgramare DESC";
                        break;
                }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            FormModificareData formModificareData = new FormModificareData();
            DataRowView? viewRow = dgvProgramari.CurrentRow.DataBoundItem as DataRowView;
            formModificareData.Data = (DateTime)viewRow["DataProgramare"];
            if (formModificareData.ShowDialog() == DialogResult.OK)
            {
                viewRow.BeginEdit();
                viewRow["DataProgramare"] = formModificareData.Data;
                viewRow.EndEdit();
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
            }
            LoadData_plati();
        }

        private void btnSterge_Click(object sender, EventArgs e)
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
            LoadData_plati();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
