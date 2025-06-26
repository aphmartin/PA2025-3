using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;

namespace LogicaDatos
{
    public class DataProducto
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;


        public int Insertar(string clave, string nombre, string descripcion, string unidadMedida, int existencia, 
            decimal precioCompra, decimal precioVenta, String ubicacion, int minimo, int maximo)
        {
            try
            {


                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                //Enviar nombre de recursos sql
                comandoSQL.CommandText = "proc_InsertarProducto";

                //Tipo de comando
                comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;

                //Agregar parametro
                comandoSQL.Parameters.AddWithValue("@clave", clave);
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@descripcion", descripcion);
                comandoSQL.Parameters.AddWithValue("@unidadmedida", unidadMedida);
                comandoSQL.Parameters.AddWithValue("@existencia", existencia);
                comandoSQL.Parameters.AddWithValue("@preciocompra", precioCompra);
                comandoSQL.Parameters.AddWithValue("@precioventa", precioVenta);
                comandoSQL.Parameters.AddWithValue("@ubicacion", ubicacion);
                comandoSQL.Parameters.AddWithValue("@minimo", minimo);
                comandoSQL.Parameters.AddWithValue("@maximo", maximo);


                //Ejecutar query
                comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();

                //Cerrar conexion
                renglonesAfectados = 1;
                Console.WriteLine("Se agrego correctamente");

            }
            catch (Exception ex)
            {

                Console.WriteLine("DataUsuario: Insertar" + ex.Message);
                renglonesAfectados = 0;
                connSQL.CerrarConexion();
            }
           return renglonesAfectados;




        }

        public DataTable BuscarPorId(int idProducto)
        {
            try
            {
                DataTable consultaData = new DataTable();

                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                comandoSQL.CommandText = "SELECT * FROM PRODUCTOS WHERE IDK="+idProducto;
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
                Console.WriteLine("DataProducto: BuscarPorId" + ex.Message);
                renglonesAfectados = 0;
                return null;
            }
        }
    }
}
