using LogicaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Ventas
    {


        public Ventas()
        {
            // Constructor de la clase Ventas
        }

        public DataTable ObtenerVentasDelDia(DateTime fechaSeleccionada)
        {
            DataVenta dataVenta = new DataVenta();
            return dataVenta.ObtenerVentas(fechaSeleccionada);
           
        }
    }
}
