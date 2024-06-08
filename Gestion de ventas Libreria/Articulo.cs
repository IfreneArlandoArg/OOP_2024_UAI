using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_ventas_Libreria
{
    public class Articulo
    {
        public string Nombre { get; set; }
        public string Codigo_Barra { get; set; }
        public double Precio { get; set; }

        public Articulo(string _Nombre, string _Cod, double _Prec) 
        { 
          Nombre = _Nombre;
          Codigo_Barra = _Cod;
          Precio = _Prec;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Codigo_Barra} - {Precio}";
        }
    }
}
