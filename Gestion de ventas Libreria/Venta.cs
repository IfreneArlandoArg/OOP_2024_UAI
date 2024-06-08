using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_ventas_Libreria
{
    public class Venta
    {
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }

        public Venta(Articulo articulo, int cantidad)
        {
            Articulo = articulo;
            Cantidad = cantidad;
        }

        public double totalVenta() 
        {
          return Articulo.Precio*Cantidad;
        }

        public override string ToString()
        {
            return $"{Articulo.Nombre} - {Articulo.Codigo_Barra} - {Articulo.Precio} - {Cantidad} - Total : {totalVenta()}";
        }
    }
}
