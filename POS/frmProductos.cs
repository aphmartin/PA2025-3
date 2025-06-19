using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Recolectar dtos del formulario
                string clave = txtClave.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                //...completar

                //crear el objeto de la clase Producto
                Producto producto = new Producto();
                //Asignar los valores del formulario al objeto Producto
                producto.Clave = clave;
                producto.Nombre = nombre;
                producto.Descripcion = descripcion;
                //...completar
                //Guardar el producto en la base de datos
                if (producto.fnGuardar())
                {
                    MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            try
            {
                List<string> lista = new List<string>();
                lista.Add("codigo");
                lista.Add("nombre");
                lista.Add("ubicacion");
                lista.Add("precioventa");

                //Llamar a un formulario HIJO que se llamara frmBuscar, pasar QUERY
                frmBuscar frm = new frmBuscar("Productos", lista);
                //tamaño
                frm.Width = this.Width;
                frm.Height = this.Height;
                frm.StartPosition = FormStartPosition.Manual;
                var posicionX = this.Parent.PointToScreen(this.Location).X + (this.Width - frm.Width) / 2;
                var posicionY = this.Parent.PointToScreen(this.Location).Y + (this.Height - frm.Height) / 2;
                frm.Location = new Point(posicionX, posicionY);
                //fin tamaño
                DialogResult resultado = frm.ShowDialog();
                txtID.Text = frm.IdResultado;
                txtID.Enabled = false;
                if (txtID.Text != "0")
                {

                    //BuscarDatos(txtID.Text);
                }
                else
                {
                    //nuevo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
