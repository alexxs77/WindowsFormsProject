using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAdministratorLogic
{
    public partial class Form_Gestiune_plati_modificare : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MetodaPlata
        {
            get => cmbMetodaPlata.SelectedItem?.ToString();
            set => cmbMetodaPlata.SelectedItem = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StatusPlata
        {
            get => cmbStatusPlata.SelectedItem?.ToString();
            set => cmbStatusPlata.SelectedItem = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal SumaPlata
        {
            get => numericUpDownSuma.Value;
            set => numericUpDownSuma.Value = value;
        }
       
        public Form_Gestiune_plati_modificare()
        {
            InitializeComponent();
            this.Text = "Modificare Plata";
            
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
