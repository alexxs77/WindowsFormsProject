using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAdministratorLogic
{


    public partial class Form_Gestiune_programari_modificare : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Status
        {
            get => cmbStatus.SelectedItem.ToString();
            set => cmbStatus.SelectedItem = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Data
        {
            get => dateTimePickerDataProgramare.Value;
            set => dateTimePickerDataProgramare.Value = value;
        }
        public Form_Gestiune_programari_modificare()
        {
            InitializeComponent();
            this.Text = "Modificare programare";
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
