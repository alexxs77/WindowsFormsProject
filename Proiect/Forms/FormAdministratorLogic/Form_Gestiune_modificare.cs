using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAdministratorLogic
{

   
    public partial class Form_Gestiune_modificare : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username
        {
            get => txtUsername.Text;
            set => txtUsername.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Parola
        {
            get => txtParola.Text;
            set => txtParola.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nume
        {
            get => txtNume.Text;
            set => txtNume.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Email
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Rol
        {
            get => cmbRol.SelectedItem.ToString();
            set
            {
                if (Enum.TryParse(typeof(Rol), value, out object rezultatEnum))
                {
                    cmbRol.SelectedItem = rezultatEnum;
                }
                else
                {
                    cmbRol.SelectedIndex = -1;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool cmbRolVisible
        {
            get => cmbRol.Visible;
            set=> cmbRol.Visible = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool labelVisible
        {
            get => label5.Visible;
            set => label5.Visible = value;
        }
        
        public Form_Gestiune_modificare()
        {
            InitializeComponent();
            cmbRol.Visible = false;
            label5.Visible = false;
            cmbRol.DataSource = Enum.GetValues(typeof(Rol));
            this.Text = "Modificare Utilizator";
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
