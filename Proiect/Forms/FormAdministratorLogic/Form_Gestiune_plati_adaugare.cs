using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAdministratorLogic
{
    public partial class Form_Gestiune_plati_adaugare : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MetodaPlata
        {
            get => cmbMetodaPlata.SelectedItem?.ToString();
            set => cmbMetodaPlata.SelectedItem = value;
        }

        public Form_Gestiune_plati_adaugare()
        {
            InitializeComponent();
            this.Text = "Adaugare Plata";
            cmbMetodaPlata.SelectedIndex = -1;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
