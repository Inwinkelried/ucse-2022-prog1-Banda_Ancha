using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class Bebida : PorCantidad {
        
        public Tipo_Bebida Tipo { get; set; }

        public Bebida(int codigo, string nombre, int cantidadminima, decimal preciounidad, decimal cantidad, Tipo_Bebida tipobebida)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantMinima = cantidadminima;
            Precio = preciounidad;
            Cantidad = cantidad;
            Tipo = tipobebida;
        } 
    }
}
