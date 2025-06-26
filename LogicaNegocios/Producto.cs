using LogicaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Producto
    {
        private int idProducto;
        private string clave;
        private string nombre;
        private string descripcion;
        private decimal precioCompra;
        private decimal precioVenta;
        private int existencia;
        private string ubicacion;
        private string unidadMedida;
        private int minimo;
        private int maximo;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public int Minimo { get => minimo; set => minimo = value; }
        public int Maximo { get => maximo; set => maximo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Producto()
        {
            // Constructor por defecto
        }

        public Producto(int idProducto, string clave, string nombre, string descripcion, decimal precioCompra, decimal precioVenta, int existencia, string ubicacion, string unidadMedida, int minimo, int maximo)
        {
            this.idProducto = idProducto;
            this.clave = clave;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.existencia = existencia;
            this.ubicacion = ubicacion;
            this.unidadMedida = unidadMedida;
            this.minimo = minimo;
            this.maximo = maximo;
        }

        public override string ToString()
        {
            return $"{clave} - {descripcion} - Precio Venta: {precioVenta:C} - Existencia: {existencia}";
        }

        public bool fnGuardar()
        {
            // Lógica para guardar el producto en la base de datos
            DataProducto dataProducto = new DataProducto();
            return dataProducto.Insertar(clave, nombre, descripcion, unidadMedida,existencia,precioCompra,precioVenta,ubicacion,minimo,maximo)>0;
       
        }

        public bool fnBuscarPorId()
        {
            // Lógica para buscar un producto por su ID
            DataProducto dataProducto = new DataProducto();
            DataTable productoEncontrado = dataProducto.BuscarPorId(idProducto);
            if (productoEncontrado != null)
            {
                // Asignar los valores del producto encontrado a las propiedades de la clase
                this.idProducto = Convert.ToInt32( productoEncontrado.Rows[0]["idProducto"]);
                this.clave = productoEncontrado.Rows[0]["clave"].ToString();
                this.nombre = productoEncontrado.Rows[0]["nombre"].ToString();
                this.descripcion = productoEncontrado.Rows[0]["descripcion"].ToString();
                this.precioCompra = Convert.ToDecimal( productoEncontrado.Rows[0]["precioCompra"]);
                this.precioVenta = Convert.ToDecimal(productoEncontrado.Rows[0]["precioVenta"]);
                this.existencia = Convert.ToInt32(productoEncontrado.Rows[0]["existencia"]);
                this.ubicacion = productoEncontrado.Rows[0]["ubicacion"].ToString();
                this.unidadMedida = productoEncontrado.Rows[0]["unidadMedida"].ToString();
                this.minimo = Convert.ToInt32(productoEncontrado.Rows[0]["minimo"]);
                this.maximo = Convert.ToInt32(productoEncontrado.Rows[0]["maximo"]);

                return true; // Producto encontrado y asignado correctamente
            }
            else { 
            return false;
        }
        }

        public bool fnActualizar()
        {
            throw new NotImplementedException();
        }
    }
}
