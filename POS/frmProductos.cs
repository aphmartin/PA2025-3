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
                //Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("La clave del producto es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción del producto es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text) || !decimal.TryParse(txtPrecioCompra.Text, out _))
                {
                    MessageBox.Show("El precio de compra es obligatorio y debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecioCompra.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text) || !decimal.TryParse(txtPrecioVenta.Text, out _))
                {
                    MessageBox.Show("El precio de venta es obligatorio y debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecioVenta.Focus();
                    return;
                }

                //Recolectar datos del formulario
                string clave = txtClave.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                string medida = txtMedida.Text.Trim();

                decimal precioCompra = decimal.Parse(txtPrecioCompra.Text.Trim());
                decimal precioVenta = decimal.Parse(txtPrecioVenta.Text.Trim());
                int existencia = int.Parse(txtExistencia.Text.Trim());
                string ubicacion = txtUbicacion.Text.Trim();
                int minimo = int.Parse(txtMinimo.Text.Trim());
                int maximo = int.Parse(txtMaximo.Text.Trim());
                // Validar que los valores numéricos sean válidos
                if (existencia < 0 || minimo < 0 || maximo < 0)
                {
                    MessageBox.Show("Los valores de existencia, mínimo y máximo deben ser números no negativos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validar que el máximo sea mayor o igual al mínimo
                if (maximo < minimo)
                {
                    MessageBox.Show("El valor máximo debe ser mayor o igual al valor mínimo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validar que el precio de venta sea mayor que el precio de compra
                if (precioVenta <= precioCompra)
                {
                    MessageBox.Show("El precio de venta debe ser mayor que el precio de compra.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //...completar

                //crear el objeto de la clase Producto
                Producto producto = new Producto();
                //Asignar los valores del formulario al objeto Producto
                producto.Clave = clave;
                producto.Nombre = nombre;
                producto.Descripcion = descripcion;
                producto.PrecioCompra = precioCompra;
                producto.PrecioVenta = precioVenta;
                producto.Existencia = existencia;
                producto.Ubicacion = ubicacion;
                producto.UnidadMedida = medida;
                producto.Minimo = minimo;
                producto.Maximo = maximo;
                // Si el ID es 0, significa que es un nuevo producto
                if (txtID.Text == "0")
                {
                    producto.IdProducto = 0; // Nuevo producto
                                             //Guardar el producto en la base de datos
                    if (producto.fnGuardar())
                    {
                        MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    producto.IdProducto = int.Parse(txtID.Text); // Producto existente
                                                                 //Guardar el producto en la base de datos
                    if (producto.fnActualizar())
                    {
                        MessageBox.Show("Producto ACTUALIZADO correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al ACTUALIZAR el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                lista.Add("idk");
                lista.Add("clave");
                lista.Add("nombre");
                lista.Add("descripcion");
                lista.Add("precioVenta");


                //Llamar a un formulario HIJO que se llamara frmBuscar, pasar QUERY
                frmBuscar frm = new frmBuscar("Productos", lista, "nombre");
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
                    // Llenar los campos del formulario con los datos del producto encontrado
                    Producto producto = new Producto();
                    producto.IdProducto = int.Parse(txtID.Text);
                    if (producto.fnBuscarPorId())
                    {
                        txtClave.Text = producto.Clave;
                        txtNombre.Text = producto.Nombre;
                        txtDescripcion.Text = producto.Descripcion;
                        txtPrecioCompra.Text = producto.PrecioCompra.ToString("F2");
                        txtPrecioVenta.Text = producto.PrecioVenta.ToString("F2");
                        txtExistencia.Text = producto.Existencia.ToString();
                        txtUbicacion.Text = producto.Ubicacion;
                        txtMedida.Text = producto.UnidadMedida;
                        txtMinimo.Text = producto.Minimo.ToString();
                        txtMaximo.Text = producto.Maximo.ToString();
                        txtID.Enabled = false; // Deshabilitar el campo ID para evitar modificaciones
                        btnGuardar.Text = "Actualizar";
                    }
                    else
                    {
                        //poner mensaje que no hubo datos
                        MessageBox.Show("No se encontró el producto con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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



        private void frmProductos_Load(object sender, EventArgs e)
        {

            LimpiarCampos();


        }
        private void LimpiarCampos()
        {
            //Limpiar campos
            txtID.Text = "0";
            txtID.Enabled = false;
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtClave.Focus();
            txtMedida.Text = "Pieza";
            txtPrecioCompra.Text = "0.00";
            txtPrecioVenta.Text = "0.00";
            txtExistencia.Text = "0";
            txtUbicacion.Text = string.Empty;
            txtMinimo.Text = "0";
            txtMaximo.Text = "0";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
