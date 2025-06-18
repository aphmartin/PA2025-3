using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using Microsoft.VisualBasic;

namespace POS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //recolectar datos de la pantalla
            if (Utilerias.validaCampo(txtUsuario.Text, 5)==false)
            {
                MessageBox.Show("El campo Usuario es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Utilerias.validaCampo(txtPWD.Text, 5)==false)
            {
                MessageBox.Show("El campo Contraseña es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtUsuario.Text;
            string pwd = txtPWD.Text;

            Usuarios objUsuario = new Usuarios();
            objUsuario.Usuario = usuario;
            objUsuario.Pwd = pwd;
            bool acceso = objUsuario.fnValidaLogin();

            if (acceso)
            {
                //MessageBox.Show("Bienvenido al sistema POS");
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }


            //recolectar datos de la pantalla

            //validacion de datos

            //llamar a la logica de negocio
            //validar usuario y contraseña
            //si todo es correcto, abrir el formulario principal
            this.Close();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
