using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class FrmLibros : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmLibros()
        {
            InitializeComponent();
        }

        private string Operacion = string.Empty;
        private void FrmLibros_Load(object sender, EventArgs e)
        {
            LLenarCategorias();
            LLenarEstado();
            ListarLibros();



        }

        private void LLenarCategorias()
        {
            BaseDatos bd = new BaseDatos();
            CategoriascomboBox.DataSource = bd.CargarCategorias();
            CategoriascomboBox.DisplayMember = "DESCRIPCION";
            CategoriascomboBox.ValueMember = "ID";
        }

        private void LLenarEstado()
        {
            BaseDatos bd = new BaseDatos();
            EstadocomboBox.DataSource = bd.CargarEstado();
            EstadocomboBox.DisplayMember = "DESCRIPCION";
            EstadocomboBox.ValueMember = "ID";
        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            Operacion = "Nuevo Registro";
            HabilitarControles();
            CodigotextBox.Focus();
        }

        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            DescripciontextBox.Enabled = true;
            CategoriascomboBox.Enabled = true;
            EstadocomboBox.Enabled = true;
            ClientetextBox.Enabled = true;
            ExistenciastextBox.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            DescripciontextBox.Clear();
            ClientetextBox.Clear();
            ExistenciastextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigotextBox.Text))
            {
                errorProvider1.SetError(CodigotextBox, "Ingrese un codigo");
                CodigotextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Ingrese una Descripcion");
                DescripciontextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ClientetextBox.Text))
            {
                errorProvider1.SetError(ClientetextBox, "Ingrese un Nombre");
                ClientetextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ExistenciastextBox.Text))
            {
                errorProvider1.SetError(ExistenciastextBox, "Ingrese una existencia");
                ExistenciastextBox.Focus();
                return;
            }

            BaseDatos bd = new BaseDatos();
            if (Operacion == "Nuevo Registro")
            {
                bool inserto = bd.InsertarLibro(CodigotextBox.Text,DescripciontextBox.Text, Convert.ToInt32(CategoriascomboBox.SelectedValue), Convert.ToInt32(EstadocomboBox.SelectedValue), ClientetextBox.Text, Convert.ToInt32(ExistenciastextBox.Text));
                LimpiarControles();
                ListarLibros();
            }
            else if(Operacion == "Modificar Registro")
            {
                bool modifico = bd.EditarLibros(CodigotextBox.Text, DescripciontextBox.Text, Convert.ToInt32(CategoriascomboBox.SelectedValue), Convert.ToInt32(EstadocomboBox.SelectedValue), ClientetextBox.Text, Convert.ToInt32(ExistenciastextBox.Text));
                LimpiarControles();
                ListarLibros();

            }
           

        }

        private void ListarLibros()
        {
            BaseDatos bd = new BaseDatos();
            LibrosdataGridView.DataSource = bd.ListarLibros();
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            Operacion = "Modificar Registro";
            if (LibrosdataGridView.SelectedRows.Count > 0)
            {
                CodigotextBox.Text = LibrosdataGridView.CurrentRow.Cells["CODIGO"].Value.ToString();
                DescripciontextBox.Text = LibrosdataGridView.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                CategoriascomboBox.Text = LibrosdataGridView.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                EstadocomboBox.Text = LibrosdataGridView.CurrentRow.Cells["ESTADO"].Value.ToString();
                ClientetextBox.Text = LibrosdataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                ExistenciastextBox.Text = LibrosdataGridView.CurrentRow.Cells["EXISTENCIAS"].Value.ToString();
                HabilitarControles();
                DescripciontextBox.Focus();
                CodigotextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe Seleccione una fila completa");
            }
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if(LibrosdataGridView.SelectedRows.Count > 0)
            {
                BaseDatos bd = new BaseDatos();
                bool elimino = bd.EliminarRegistroL(LibrosdataGridView.CurrentRow.Cells[0].Value.ToString());
                ListarLibros();

            }
            else
            {
                MessageBox.Show("Debe Seleccione una fila completa");
            }
        }

        private void ExistenciastextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            CodigotextBox.Clear();
            DescripciontextBox.Clear();
            ClientetextBox.Clear();
            ExistenciastextBox.Clear();

        }
    }
}
