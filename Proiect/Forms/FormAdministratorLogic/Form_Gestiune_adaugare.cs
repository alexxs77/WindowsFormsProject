using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect.Forms.FormAdministratorLogic
{

    public enum Rol
    {
        Administrator,
        Angajat,
        Pacient
    }


    public partial class Form_Gestiune_adaugare : Form
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


        public Form_Gestiune_adaugare()
        {
            InitializeComponent();
            cmbRol.DataSource = Enum.GetValues(typeof(Rol));
            this.Text = "Adaugare Utilizator";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
