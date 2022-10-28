using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class Lacteo : Ingrediente 
    {
        public Lacteo(int codigo, string nombre, int cantidadminima, decimal precioLitro, decimal cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantMinima = cantidadminima;
            Precio = precioLitro;
            Cantidad = cantidad;

        }
    }
}
