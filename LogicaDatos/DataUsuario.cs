using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient; // Ensure you have the Microsoft.Data.SqlClient package installed

namespace LogicaDatos
{
    public class DataUsuario
    {

        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;
        public String NombreDeUsuario = "";
        public String UserName = "";

        public void Insertar(String nombre, String apellidoP, String apellidoM, String correo, String usuario, String password)
        {
            try
            {


                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                //Enviar nombre de recursos sql
                comandoSQL.CommandText = "proc_InsertarUsuario";

                //Tipo de comando
                comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;
                comandoSQL.Parameters.Clear();
                //Agregar parametro
                comandoSQL.Parameters.AddWithValue("@NOMBRE", nombre);
                comandoSQL.Parameters.AddWithValue("@AP1", apellidoP);
                comandoSQL.Parameters.AddWithValue("@AP2", apellidoM);
                comandoSQL.Parameters.AddWithValue("@EMAIL", correo);
                comandoSQL.Parameters.AddWithValue("@USER", usuario);
                comandoSQL.Parameters.AddWithValue("@PASSWORD", password);


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
            }



        }


        public void Auntenticar(String usuario, String password)
        {
            try
            {


                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                //Enviar nombre de recursos sql
                comandoSQL.CommandText = "proc_ValidaLogin";

                //Tipo de comando
                comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;

                //Agregar parametro
                comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                comandoSQL.Parameters.AddWithValue("@pwd", password);

                //Ejecutar query
                //renglonesAfectados = comandoSQL.ExecuteNonQuery();
                SqlDataReader result = comandoSQL.ExecuteReader();
                if (result.Read())
                {
                    renglonesAfectados = 1;
                    UserName = result["usuario"].ToString();
                    NombreDeUsuario = result["nombre"].ToString();
                }
                else
                {
                    renglonesAfectados = 0;
                }


                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //Cerrar conexion

            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuario: Auntenticar" + ex.Message);
                renglonesAfectados = 0;
            }

        }

        public DataTable BuscarPorID(int id)
        {
            try
            {
                DataTable consultaData = new DataTable();

                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                comandoSQL.CommandText = "SELECT * FROM USUARIOS WHERE IDK=" + id;
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
