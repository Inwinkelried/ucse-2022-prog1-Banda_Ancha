﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Panaderia : PorPeso
    {
        public Panaderia(int codigo, string nombre, decimal cantidadminima, decimal precioKilo, decimal cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantMinima = cantidadminima;
            Precio = precioKilo;
            Cantidad = cantidad;

        }
    }
}
