
namespace Proyecto_Biblioteca
{
    partial class FrmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ExistenciastextBox = new System.Windows.Forms.TextBox();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoriascomboBox = new System.Windows.Forms.ComboBox();
            this.LibrosdataGridView = new System.Windows.Forms.DataGridView();
            this.EstadocomboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LibrosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categorias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del Cliente";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Enabled = false;
            this.CodigotextBox.Location = new System.Drawing.Point(209, 94);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(151, 20);
            this.CodigotextBox.TabIndex = 5;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Enabled = false;
            this.DescripciontextBox.Location = new System.Drawing.Point(209, 133);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(151, 20);
            this.DescripciontextBox.TabIndex = 6;
            // 
            // ExistenciastextBox
            // 
            this.ExistenciastextBox.Enabled = false;
            this.ExistenciastextBox.Location = new System.Drawing.Point(570, 185);
            this.ExistenciastextBox.Name = "ExistenciastextBox";
            this.ExistenciastextBox.Size = new System.Drawing.Size(161, 20);
            this.ExistenciastextBox.TabIndex = 8;
            this.ExistenciastextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciastextBox_KeyPress);
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.Enabled = false;
            this.ClientetextBox.Location = new System.Drawing.Point(570, 138);
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(161, 20);
            this.ClientetextBox.TabIndex = 9;
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.Location = new System.Drawing.Point(159, 225);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(83, 37);
            this.Nuevobutton1.TabIndex = 10;
            this.Nuevobutton1.Text = "Nuevo Registro";
            this.Nuevobutton1.UseVisualStyleBackColor = true;
            this.Nuevobutton1.Click += new System.EventHandler(this.Nuevobutton1_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(263, 225);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(83, 37);
            this.Modificarbutton.TabIndex = 11;
            this.Modificarbutton.Text = "Modifcar Registro";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(364, 225);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 37);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar Registro";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(466, 225);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(83, 37);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar Registro";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(561, 225);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(83, 37);
            this.Cancelarbutton.TabIndex = 14;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado del Libro";
            // 
            // CategoriascomboBox
            // 
            this.CategoriascomboBox.Enabled = false;
            this.CategoriascomboBox.FormattingEnabled = true;
            this.CategoriascomboBox.Location = new System.Drawing.Point(209, 179);
            this.CategoriascomboBox.Name = "CategoriascomboBox";
            this.CategoriascomboBox.Size = new System.Drawing.Size(151, 21);
            this.CategoriascomboBox.TabIndex = 17;
            // 
            // LibrosdataGridView
            // 
            this.LibrosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrosdataGridView.Location = new System.Drawing.Point(-3, 278);
            this.LibrosdataGridView.Name = "LibrosdataGridView";
            this.LibrosdataGridView.Size = new System.Drawing.Size(812, 185);
            this.LibrosdataGridView.TabIndex = 18;
            // 
            // EstadocomboBox
            // 
            this.EstadocomboBox.Enabled = false;
            this.EstadocomboBox.FormattingEnabled = true;
            this.EstadocomboBox.Location = new System.Drawing.Point(570, 91);
            this.EstadocomboBox.Name = "EstadocomboBox";
            this.EstadocomboBox.Size = new System.Drawing.Size(161, 21);
            this.EstadocomboBox.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 461);
            this.Controls.Add(this.EstadocomboBox);
            this.Controls.Add(this.LibrosdataGridView);
            this.Controls.Add(this.CategoriascomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.ClientetextBox);
            this.Controls.Add(this.ExistenciastextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibrosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox ExistenciastextBox;
        private System.Windows.Forms.TextBox ClientetextBox;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CategoriascomboBox;
        private System.Windows.Forms.DataGridView LibrosdataGridView;
        private System.Windows.Forms.ComboBox EstadocomboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}