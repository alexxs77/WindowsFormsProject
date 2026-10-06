using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAdministratorLogic
{
    public partial class Form_Gestiune_servicii_modificare : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Denumire
        {
            get => txtDenumire.Text;
            set => txtDenumire.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Descriere
        {
            get => txtDescriere.Text;
            set => txtDescriere.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Pret
        {
            get => numericUpDownPret.Value;
            set => numericUpDownPret.Value = value;
        }
        public Form_Gestiune_servicii_modificare()
        {
            InitializeComponent();
            this.Text = "Modificare serviciu";
        }

        private void btnModifica_Click(object sender, EventArgs e)
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
