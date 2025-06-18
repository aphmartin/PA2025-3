using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LogicaDatos
{
    public class ConexionSQL
    {
        SqlConnection conn;
        String nombreServidor = "DELL-MARTIN";
        String nombreBD = "POS";
        String usuarioBD = "userpos";
        String passwordBD = "ues2025";
        private String ConnectionString;

        public ConexionSQL()
        {
            try
            {
                ConnectionString = $"Server={nombreServidor}; Database={nombreBD}; User Id={usuarioBD}; Password={passwordBD};";
                conn = new SqlConnection(ConnectionString);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ConexionSQL: " + ex.Message);
            }
            //Agregar connectionString




        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
