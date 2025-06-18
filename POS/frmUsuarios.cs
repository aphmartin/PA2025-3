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
            string id = txtID.Text;
            String nombre = txtNombre.Text;
            String apellidoP = txtAp1.Text;
            String apellidoM = txtAp2.Text;
            String correo = txtCorreo.Text;
            String pwd = txtPwd.Text;
            string usuario = txtUsuario.Text;

            Usuarios objUsuario = new Usuarios();
            objUsuario.Clave = 0;
            objUsuario.Nombre = nombre;
            objUsuario.ApellidoP = apellidoP;
            objUsuario.ApellidoM = apellidoM;
            objUsuario.Correo = correo;
            objUsuario.Pwd = pwd;
            objUsuario.Usuario = usuario;
            objUsuario.Telefono = "0";


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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            try
            {
                List<string> lista = new List<string>();
                lista.Add("nombres");
                lista.Add("primer_apellido");
                lista.Add("segundo_apellido");
                lista.Add("correo");

                //Llamar a un formulario HIJO que se llamara frmBuscar, pasar QUERY
                frmBuscar frm = new frmBuscar("Usuarios", lista);
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
