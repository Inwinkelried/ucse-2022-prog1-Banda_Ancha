using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class Fruta : PorCantidad 
    {
        public Fruta(int codigo, string nombre, decimal cantidadminima, decimal preciounidad, decimal cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantMinima = cantidadminima;
            Precio = preciounidad;
            Cantidad = cantidad;

        }

    }
}
