using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Biblioteca
{
    public partial class FrmLog : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == "")
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese el Usuario");
                UsuariotextBox.Focus();
                return;
            }
            errorProvider1.SetError(UsuariotextBox, "");
            if (ContrasenatextBox.Text == "")
            {
                errorProvider1.SetError(ContrasenatextBox, "Ingrese la contrasena");
                ContrasenatextBox.Focus();
                return;
            }
            errorProvider1.SetError(ContrasenatextBox, "");

            BaseDatos conexion = new BaseDatos();

            if (conexion.ValidarUsuario(UsuariotextBox.Text, ContrasenatextBox.Text))
            {
                FrmPrincipal formulario = new FrmPrincipal();
                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Invalidos");
            }

            
        }
    }
}
