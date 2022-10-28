using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class HortalizaYVerdura : PorCantidad {

        public HortalizaYVerdura(int codigo, string nombre, int cantidadminima, decimal preciounidad, decimal cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantMinima = cantidadminima;
            Precio = preciounidad;
            Cantidad = cantidad;

        }
    }
}
