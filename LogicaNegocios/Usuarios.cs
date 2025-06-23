using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaDatos;

namespace LogicaNegocios
{

    public class Usuarios
    {
        private int clave;
        private string usuario;
        private string pwd;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string correo;
        private string telefono;

        public int Clave { get => clave; set => clave = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Usuarios() { }

        public Usuarios(int clave, string usuario, string pwd, string nombre, string apellidoP, string apellidoM, string correo, string telefono)
        {
            this.Clave = clave;
            this.Usuario = usuario;
            this.Pwd = pwd;
            this.Nombre = nombre;
            this.ApellidoP = apellidoP;
            this.ApellidoM = apellidoM;
            this.Correo = correo;
            this.Telefono = telefono;
        }

        public bool fnValidaLogin()
        {
            try
            {
                Boolean resultado = false;
                //Recoger datos del login
                DataUsuario mUsuario = new DataUsuario();
                mUsuario.Auntenticar(usuario, pwd);
                if (mUsuario.renglonesAfectados == 1)
                {

                    resultado = true;
                    Utilerias.G_NombreUsuario = mUsuario.NombreDeUsuario;
                    Utilerias.G_Usuario = mUsuario.UserName;
                }
                else
                {

                    resultado = false;
                    //Utilerias.G_NombreUsuario = "";
                    //Utilerias.G_Usuario = "";

                }
                return resultado;

                //conectar BD



                //Validar Consulta

            }
            catch (Exception e)
            {
                Console.WriteLine("[fnValidaLogin]" + e.ToString());
                return false;
            }

        }

        public bool fnGuardar()
        {
            try
            {
                Boolean resultado = false;
                DataUsuario vUsuario = new DataUsuario();
                vUsuario.Insertar(nombre, apellidoP, apellidoM, correo, usuario, pwd, telefono, clave);
                if (vUsuario.renglonesAfectados > 0)
                {
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }

}
