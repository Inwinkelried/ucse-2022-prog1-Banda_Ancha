﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Pescados : PorPeso
    {
        public Pescados(int codigo, string nombre, int cantidadminima, decimal precio, decimal cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantMinima = cantidadminima;
            Precio = precio;
            Cantidad = cantidad;

        }
    }
}
