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
    public partial class frnPrincipal : Form
    {
        public frnPrincipal()
        {
            InitializeComponent();
        }

        private void frnPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Punto de Venta - " + Application.ProductVersion;
                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();
                //MessageBox.Show("Bienvenido al sistema de Punto de Venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                barra_nombre.Text = Utilerias.G_NombreUsuario; // Asignar el usuario logueado a la barra de estado
                barra_version.Text = "Versión:" + Application.ProductVersion; // Asignar la versión de la aplicación a la barra de estado
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir frmUsuarios
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this; // Establecer el formulario principal como padre  
            frmUsuarios.Show(); // Mostrar el formulario de usuarios

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.MdiParent = this; // Establecer el formulario principal como padre
            frmProductos.Show(); // Mostrar el formulario de productos
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.MdiParent = this; // Establecer el formulario principal como padre
            frmVentas.Show(); // Mostrar el formulario de ventas
        }

        private void corteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCorteCaja frmCorteCaja = new frmCorteCaja();
            frmCorteCaja.MdiParent = this; // Establecer el formulario principal como padre
            frmCorteCaja.Show(); // Mostrar el formulario de corte de caja
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
