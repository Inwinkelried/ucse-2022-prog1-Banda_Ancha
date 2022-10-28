using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    internal class Queso : PorPeso
    {
        public Queso(int codigo, string nombre, int cantidadminima, decimal precioKilo, decimal cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantMinima = cantidadminima;
            Precio = precioKilo;
            Cantidad = cantidad;

        }

    }
}
