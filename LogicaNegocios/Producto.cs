using LogicaDatos;
using System;
using System.Collections.Generic;
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
            return dataProducto.Insertar(clave, nombre, descripcion, unidadMedida)>0;
       
        }


    }
}
