using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDatos
{
    public class DataVenta
    {

        public DataVenta()
        {
            // Constructor de la clase DataVenta
        }

        public DataTable ObtenerVentas(DateTime fechaSeleccionada)
        {
            DataTable dataTable = new DataTable();
            //HAY QUE HACER LA CONEXION A LA BD

            //HAY QUE CONSUMIR EL PROCEDIMIENTO

            //LLENAR UN DATATABLE CON EL RESULTADO DE LA BD

            //RETORNA EL DATATABLE

            //simular la estructura de datos
            dataTable.Columns.Add("cantidad", typeof(int));
            dataTable.Columns.Add("clave", typeof(string));
            dataTable.Columns.Add("nombre", typeof(string));
            dataTable.Columns.Add("importe", typeof(decimal));
            //simular datos
            Random random = new Random();
            int c1, c2, c3;
            c1 = random.Next(1, 10) * 10; // Genera un número aleatorio entre 10 y 90
            c2 = random.Next(1, 10) * 10; // Genera un número aleatorio entre 10 y 90
            c3 = random.Next(1, 10) * 10; // Genera un número aleatorio entre 10 y 90

            dataTable.Rows.Add(c1, "P001", "Producto A", (random.Next(c1, 1000) * 10));
            dataTable.Rows.Add(c2, "P002", "Producto B", (random.Next(c2, 1000) * 10));
            dataTable.Rows.Add(c3, "P003", "Producto C", (random.Next(c3, 1000) * 10));
            //NUMERO ENTERO ALEATORIO
            


            return dataTable;
        }
    }
}
