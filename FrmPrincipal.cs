using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class FrmPrincipal : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

       
        FrmLibros formularioLibros;
        
        private void LibrostoolStripButton_Click(object sender, EventArgs e)
        {
            if (formularioLibros == null)
            {
                formularioLibros = new FrmLibros();
                formularioLibros.MdiParent = this;
                formularioLibros.FormClosed += FormularioLibros_FormClosed;
                formularioLibros.Show();
            }
            else
            {
                formularioLibros.Activate();
            }
            
           
        }

        private void FormularioLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioLibros = null;
        }
    }
}
