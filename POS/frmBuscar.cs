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
        private string tabla;
        private List<string> listaCampos;
        private string query;
        private string consulta;
        private string campo;
        public string Id_Busqueda;
        public string tituloPantalla;
        private string idResultado;
        // setCampo, SetQuery, SetConsulta
        public string Campo { get => campo; set => campo = value; }
        public string Query { get => query; set => query = value; }
        public string Consulta
        {
            get => consulta; set => consulta = value;
        }
        public string IdResultado { get => idResultado; set => idResultado = value; }

        //Metodos - Propiedades


        public frmBuscar()
        {
            InitializeComponent();
        }
        public frmBuscar(string tablaP, List<String> lista, string campoBuscar)
        {
            InitializeComponent();
            //Inicializar variables

            tabla = tablaP;
            listaCampos = lista;
            campo = campoBuscar;

        }
        private void ConsultaQuery()
        {
            Query = "SELECT ";
            for (int i = 0; i < listaCampos.Count; i++)
            {
                if (i == listaCampos.Count - 1)
                {
                    Query += listaCampos[i];
                }
                else
                {
                    Query += listaCampos[i] + ", ";
                }
            }
            Query += " FROM " + tabla;
        }
        private void ConsultaQuery(string campo)
        {
            Query = "SELECT ";
            for (int i = 0; i < listaCampos.Count; i++)
            {
                if (i == listaCampos.Count - 1)
                {
                    Query += listaCampos[i];
                }
                else
                {
                    Query += listaCampos[i] + ", ";
                }
            }
            Query += " FROM " + tabla + " WHERE " + campo + " LIKE @valorBusqueda";
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            dtConsulta = new DataTable();
            ConfigurarDataGrid();
            //Configurar el título del formulario
            this.Text = "Buscar información de " + tabla;
            //Configurar la consulta
            ConsultaQuery();
            //Configurar DataGridView

            //Obtener query de la tabla
            //query= "select id, nombre, ubicacion, precio from productos order by nombre asc"
            mostrarResultados();
            //mostrar resultados en dGV_datos



        }
        private string getConsulta()
        {
            if (Query.Length == 0)
                Consulta = "SELECT 'SIN DATOS A BUSCAR O BUSQUEDA INCOMPLETA' AS DESCRIPCION";
            else if (txtBuscar.Text.Length == 0)
            {
                Consulta = query + " order by " + campo + " asc";
            }
            else
            {
                Consulta = query + " where " + campo + " like '%" + txtBuscar.Text + "%'";
            }
            return Consulta;
        }

        private void mostrarResultados()
        {
            try
            {
                //levantar conexion a BD con query

                //Enviar consulta
                string consultaBuscar = getConsulta();

                //Llenar DataGridView
                //crear un metodo en capaDatos que reciba parametros SQLCommand, retorne un DataSet
                LogicaDatos.DataBuscar datos = new LogicaDatos.DataBuscar();
                dtConsulta = datos.consultaDataGridView(consultaBuscar);
                dGV_datos.DataSource = dtConsulta;
                // Ocultar la primera columna
                if (dGV_datos.Columns.Count > 0)
                {
                    dGV_datos.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[frmBuscar] " + ex.Message);
                //escribir a un archivo de LOG
            }

        }

        private void dGV_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtener el ID del registro seleccionado
            if (dGV_datos.Rows.Count > 0 && e.RowIndex >= 0)
            {
                IdResultado = dGV_datos.Rows[e.RowIndex].Cells[0].Value.ToString();
                //Cerrar el formulario y devolver el ID
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void ConfigurarDataGrid()
        {
            dGV_datos.BackgroundColor = Color.White;
            dGV_datos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_datos.MultiSelect = false;

            dGV_datos.ReadOnly = true; // Hacer que las filas no sean editables
            dGV_datos.AllowUserToAddRows = false;
            dGV_datos.AllowUserToDeleteRows = false;
            dGV_datos.AllowUserToResizeColumns = false;
            dGV_datos.AllowUserToResizeRows = false;
            dGV_datos.RowHeadersVisible = false;
            dGV_datos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGV_datos.EnableHeadersVisualStyles = false;
            dGV_datos.ScrollBars = ScrollBars.Vertical;

            // Estilo de las columnas
            dGV_datos.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dGV_datos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dGV_datos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_datos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dGV_datos.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

            // Estilo de las filas
            dGV_datos.DefaultCellStyle.BackColor = Color.White;
            dGV_datos.DefaultCellStyle.ForeColor = Color.Black;
            dGV_datos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dGV_datos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGV_datos.DefaultCellStyle.Padding = new Padding(5);
            //dgv_datos.DefaultCellStyle.BorderStyle = BorderStyle.None;

            dGV_datos.RowTemplate.Height = 30;
            dGV_datos.BorderStyle = BorderStyle.None;

            // Método para ajustar el tamaño de las columnas según el contenido
            //dgv_datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Ajustar el tamaño de las columnas para llenar el panel
            dGV_datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
