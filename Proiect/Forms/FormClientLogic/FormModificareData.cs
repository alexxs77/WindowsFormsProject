using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormClientLogic
{
    public partial class FormModificareData : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Data
        {
            get => dateTimePicker1.Value;
            set => dateTimePicker1.Value = value;
        }

        public FormModificareData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
