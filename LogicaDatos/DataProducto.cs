using System;
using System.Collections.Generic;
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


        public int Insertar(string clave, string nombre, string descripcion, string unidadMedida)
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

    }
}
