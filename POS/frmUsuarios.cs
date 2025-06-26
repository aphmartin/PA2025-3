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


        private void AccionDeBoton()
        {
            //validar campos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtAp1.Text) || string.IsNullOrEmpty(txtAp2.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtPwd.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            //objUsuario.Telefono = "0";

            // Si el ID es 0, significa que es un nuevo usuario
            if (id == "0")
            {
                objUsuario.Clave = 0; //nuevo
                btnAccion.Text = "Guardar"; //cambiar el texto del boton a guardar
                                            //completar los demas campos
                if (objUsuario.fnGuardar()) //llamar a la logica de negocio
                {
                    MessageBox.Show("Usuario guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); //limpiar los campos

                }
                else
                {
                    MessageBox.Show("Error al guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                objUsuario.Clave = Convert.ToInt32(id); //actualizar
                btnAccion.Text = "Actualizar"; //cambiar el texto del boton a actualizar
                                               //completar los demas campos
                if (objUsuario.fnActualizar()) //llamar a la logica de negocio
                {
                    MessageBox.Show("Usuario ACTUALIZO correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar(); //limpiar los campos

                }
                else
                {
                    MessageBox.Show("Error al ACTUALIZAR el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                lista.Add("idk");
                lista.Add("nombre");
                lista.Add("apellidoP");
                lista.Add("apellidoM");
                lista.Add("correo");

                //Llamar a un formulario HIJO que se llamara frmBuscar, pasar QUERY
                frmBuscar frm = new frmBuscar("Usuarios", lista, "nombre");
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

                    //obtener los datos del usuario
                    LogicaNegocios.Usuarios objUsuario = new LogicaNegocios.Usuarios();
                    objUsuario.Clave = Convert.ToInt32(txtID.Text);
                    if (objUsuario.fnBuscarPorID())
                    {
                        //cargar los datos en los campos
                        txtNombre.Text = objUsuario.Nombre;
                        txtAp1.Text = objUsuario.ApellidoP;
                        txtAp2.Text = objUsuario.ApellidoM;
                        txtCorreo.Text = objUsuario.Correo;
                        txtPwd.Text = objUsuario.Pwd;
                        txtUsuario.Text = objUsuario.Usuario;
                        btnAccion.Text = "Actualizar"; //cambiar el texto del boton a actualizar
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
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

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            
            LimpiarCampos();

        }

        private void Limpiar()
        {
            txtID.Text = "0";
            txtID.Enabled = true;
            txtNombre.Text = "";
            txtAp1.Text = "";
            txtAp2.Text = "";
            txtCorreo.Text = "";
            txtPwd.Text = "";
            txtUsuario.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccionDeBoton();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtID.Text = "0";
            txtID.Enabled = false;
            txtNombre.Text = string.Empty;
            txtAp1.Text = string.Empty;
            txtAp2.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtUsuario.Text = string.Empty;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
