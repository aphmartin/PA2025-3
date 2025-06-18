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
    public partial class frmBuscar : Form
    {
        //Variables de clase
        DataTable dtConsulta;
        private string query;
        private string consulta;
        private string campo;
        public string Id_Busqueda;
        public string tituloPantalla;
        private string idResultado;
        // setCampo, SetQuery, SetConsulta
        public string Campo { get => campo; set => campo = value; }
        public string Query { get => query; set => query = value; }
        public string Consulta { 
            get => consulta; 
        }
        public string IdResultado { get => idResultado; set => idResultado = value; }

        //Metodos - Propiedades


        public frmBuscar()
        {
            InitializeComponent();
        }
        public frmBuscar(string baseDatos, List<String> lista)
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {



        }
    }
}
