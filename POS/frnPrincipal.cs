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
                MessageBox.Show("Bienvenido al sistema de Punto de Venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
