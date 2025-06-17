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
            return true;
        }

        public bool fnGuardar()
        {

            DataUsuario dataUsuario = new DataUsuario();
            return dataUsuario.Insertar(this.Usuario, this.Pwd, this.Nombre, this.ApellidoP, this.ApellidoM, this.Correo, this.Telefono);
            
          
        }
    }

}
