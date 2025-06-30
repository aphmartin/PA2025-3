using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
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
                String idProducto = frm.IdResultado; // Obtener el ID del producto seleccionado

                if (idProducto != "0")
                {

                    BuscarProdcuto(idProducto);


                }
                else
                {
                    //nuevo();
                    txtClave.Text = string.Empty; // Limpiar el campo Clave
                    txtNombre.Text = string.Empty; // Limpiar el campo Nombre
                    txtPrecio.Text = string.Empty; // Limpiar el campo Precio
                    txtCantidad.Text = string.Empty; // Limpiar el campo Cantidad
                    txtImporte.Text = string.Empty; // Limpiar el campo Importe
                    btnAgregar.Text = "Agregar"; // Cambiar el texto del botón a "Nuevo"
                    btnAgregar.Enabled = false; // Deshabilitar el botón Agregar si no se encuentra el producto

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        } //fin clic

        private void BuscarProdcuto(string idProducto)
        {
            // Llenar los campos del formulario con los datos del producto encontrado
            Producto producto = new Producto();
            producto.IdProducto = int.Parse(idProducto);
            if (producto.fnBuscarPorId())
            {
                txtClave.Text = producto.Clave;
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.PrecioVenta.ToString("F2");
                txtCantidad.Text = "1"; // Asignar una cantidad por defecto de 1 al campo Cantidad, si es necesario
                txtImporte.Text = (producto.PrecioVenta * int.Parse(txtCantidad.Text)).ToString("F2");
                txtClave.Enabled = false; // Deshabilitar el campo ID para evitar modificaciones
                btnAgregar.Text = "Agregar";
                btnAgregar.Enabled = true; // Habilitar el botón Agregar para permitir añadir el producto al ticket
            }
            else
            {
                //poner mensaje que no hubo datos
                MessageBox.Show("No se encontró el producto con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClave.Text = string.Empty; // Limpiar el campo Clave
                txtNombre.Text = string.Empty; // Limpiar el campo Nombre
                txtPrecio.Text = string.Empty; // Limpiar el campo Precio
                txtCantidad.Text = string.Empty; // Limpiar el campo Cantidad
                txtImporte.Text = string.Empty; // Limpiar el campo Importe
                btnAgregar.Text = "Agregar"; // Cambiar el texto del botón a "Nuevo"
                btnAgregar.Enabled = false; // Deshabilitar el botón Agregar si no se encuentra el producto

            }
        }
        private void BuscarProductoPorClave(string claveProducto)
        {
            // Llenar los campos del formulario con los datos del producto encontrado
            Producto producto = new Producto();
            producto.Clave = claveProducto;
            if (producto.fnBuscarPorClave())
            {
                txtClave.Text = producto.Clave;
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.PrecioVenta.ToString("F2");
                txtCantidad.Text = "1"; // Asignar una cantidad por defecto de 1 al campo Cantidad, si es necesario
                txtImporte.Text = (producto.PrecioVenta * int.Parse(txtCantidad.Text)).ToString("F2");
                txtClave.Enabled = false; // Deshabilitar el campo ID para evitar modificaciones
                btnAgregar.Text = "Agregar";
                btnAgregar.Enabled = true; // Habilitar el botón Agregar para permitir añadir el producto al ticket
            }
            else
            {
                //poner mensaje que no hubo datos
                MessageBox.Show("No se encontró el producto con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClave.Text = string.Empty; // Limpiar el campo Clave
                txtNombre.Text = string.Empty; // Limpiar el campo Nombre
                txtPrecio.Text = string.Empty; // Limpiar el campo Precio
                txtCantidad.Text = string.Empty; // Limpiar el campo Cantidad
                txtImporte.Text = string.Empty; // Limpiar el campo Importe
                btnAgregar.Text = "Agregar"; // Cambiar el texto del botón a "Nuevo"
                btnAgregar.Enabled = false; // Deshabilitar el botón Agregar si no se encuentra el producto

            }
        }
        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            //Si presiono ENTER
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (!string.IsNullOrEmpty(txtClave.Text))
                    {
                        BuscarProductoPorClave(txtClave.Text);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una clave de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    e.SuppressKeyPress = true; // Evitar el sonido del beep al presionar Enter
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Añadir el producto a la DataGridView
            try
            {
                if (btnAgregar.Text == "Agregar")
                {
                    // Validar que los campos no estén vacíos
                    if (string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtCantidad.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Calcular el importe
                    decimal precio = decimal.Parse(txtPrecio.Text);
                    int cantidad = int.Parse(txtCantidad.Text);
                    decimal importe = precio * cantidad;

                    // Agregar el producto a la DataGridView
                    dgvProductos.Rows.Add(txtClave.Text, txtNombre.Text, precio.ToString("F2"), cantidad, importe.ToString("F2"));

                    // Limpiar los campos después de agregar
                    txtClave.Clear();
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();
                    txtImporte.Clear();

                    txtClave.Enabled = true; // Habilitar el campo Clave para permitir agregar otro producto

                    //Añadir un metodo para calcular el total de la venta del DataGridView
                    decimal totalVenta = 0;
                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        if (row.Cells["Importe"].Value != null)
                        {
                            totalVenta += Convert.ToDecimal(row.Cells["Importe"].Value);
                        }
                    }
                    // Mostrar el total de la venta en un Label o TextBox (puedes crear un Label llamado lblTotalVenta)
                    txtTotal.Text = totalVenta.ToString("C2"); // Formato de moneda

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            //Agregar las columnas a la DataGridView
            dgvProductos.Columns.Add("Clave", "Clave");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Importe", "Importe");
            // Configurar las propiedades de las columnas
            dgvProductos.Columns["Clave"].Width = 100;
            dgvProductos.Columns["Nombre"].Width = 200;
            dgvProductos.Columns["Precio"].Width = 80;
            dgvProductos.Columns["Cantidad"].Width = 80;
            dgvProductos.Columns["Importe"].Width = 80;
            // Establecer el formato de las columnas de precio e importe
            dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2"; // Formato de moneda
            dgvProductos.Columns["Importe"].DefaultCellStyle.Format = "C2"; // Formato de moneda
            // Deshabilitar la edición de las celdas
            dgvProductos.ReadOnly = true; // Hacer que la DataGridView sea de solo lectura para evitar modificaciones directas
            dgvProductos.AllowUserToAddRows = false; // Deshabilitar la opción de agregar filas manualmente
            dgvProductos.AllowUserToDeleteRows = false; // Deshabilitar la opción de eliminar filas manualmente
            dgvProductos.AllowUserToResizeRows = false; // Deshabilitar el cambio de tamaño de las filas
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar filas completas
            dgvProductos.MultiSelect = false; // Deshabilitar la selección múltiple de filas


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si hay productos en la DataGridView antes de proceder con la venta
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la lista. Por favor, agregue productos antes de realizar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Procesar la venta
            //Recoger los datos de la venta desde la DataGridView y otros campos necesarios
            List<Producto> productosVendidos = new List<Producto>();
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                string clave = row.Cells["Clave"].Value.ToString();
                string nombre = row.Cells["Nombre"].Value.ToString();
                decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal importe = Convert.ToDecimal(row.Cells["Importe"].Value);
                // Crear un objeto Producto con los datos de la venta
                Producto producto = new Producto
                {
                    Clave = clave,
                    Nombre = nombre,
                    PrecioVenta = precio,
                    Existencia = cantidad // Asignar la cantidad vendida como existencia temporal
                };
                productosVendidos.Add(producto); // Agregar el producto a la lista de productos vendidos

            }
            //Generar el metodo de la clase Producto para procesar la venta
            Producto productoVenta = new Producto();
            // Por ejemplo, podrías llamar a un método en la clase Producto para guardar la venta en la base de datos
            productoVenta.GuardarVentaEnBaseDeDatos(productosVendidos); // Método ficticio para guardar la venta en la base de datos




            // Aquí puedes agregar la lógica para procesar la venta, como guardar los datos en la base de datos o generar un ticket
            MessageBox.Show("Venta procesada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Limpiar la DataGridView y los campos de entrada después de procesar la venta
            dgvProductos.Rows.Clear(); // Limpiar la DataGridView
            txtClave.Clear(); // Limpiar el campo Clave
            txtNombre.Clear(); // Limpiar el campo Nombre
            txtPrecio.Clear(); // Limpiar el campo Precio
            txtCantidad.Clear(); // Limpiar el campo Cantidad
            txtImporte.Clear(); // Limpiar el campo Importe
            txtTotal.Clear(); // Limpiar el campo Total
            txtClave.Enabled = true; // Habilitar el campo Clave para permitir agregar nuevos productos

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            //validar que solo ingrese numeros
            e.Handled = true;
            if (char.IsDigit((char)e.KeyCode) || e.KeyCode == Keys.Back)
            {
                e.Handled = false; // Permitir el ingreso de números y la tecla Backspace
            }
            // Hacer el calculo del importe al cambiar la cantidad
            if (decimal.TryParse(txtPrecio.Text, out decimal precio) && int.TryParse(txtCantidad.Text, out int cantidad))
            {
                txtImporte.Text = (precio * cantidad).ToString("F2"); // Calcular el importe y mostrarlo en el campo Importe
            }
            else
            {
                txtImporte.Text = "0.00"; // Si no se puede calcular, establecer el importe a 0.00
            }
        }
    }
}
