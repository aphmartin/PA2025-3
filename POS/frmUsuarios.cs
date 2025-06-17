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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //recolectar
            String nombre = txtNombre.Text;
            Usuarios objUsuario = new Usuarios();
            objUsuario.Nombre = nombre;
            //completar los demas campos
            if (objUsuario.fnGuardar()) //llamar a la logica de negocio
            {
                MessageBox.Show("Usuario guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Conexion logica de negocio
        }
    }
}
