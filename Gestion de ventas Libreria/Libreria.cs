using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_ventas_Libreria
{
    public class Libreria
    {
        public double Total;

        public void Calcular (Venta _venta) 
        {
            Total += _venta.totalVenta();
        }
    }
}