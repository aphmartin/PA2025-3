using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogicaDatos
{
    public class DataBuscar
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;

        //constructor
        public DataBuscar()
        {
            // Inicialización de variables si es necesario
        }

        public DataTable consultaDataGridView(string consultaBuscar)
        {
            try
            {
                DataTable consultaData = new DataTable();

                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                comandoSQL.CommandText = consultaBuscar;
                comandoSQL.CommandType = CommandType.Text;

                //obtener un datareader
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
                //Llenar el datatable con los datos obtenidos
                adaptador.Fill(consultaData);
                //validar si tiene datos el datatable
                if (consultaData.Rows.Count > 0)
                {
                    renglonesAfectados = consultaData.Rows.Count;
                }
                else
                {
                    renglonesAfectados = 0;
                }

     


                connSQL.CerrarConexion();
                //Cerrar conexion
                return consultaData;

            }
            catch (Exception ex)
            {
                Console.WriteLine("DataBuscar: consultaDataGridView" + ex.Message);
                renglonesAfectados = 0;
                return null;
            }
        }
    }
}
