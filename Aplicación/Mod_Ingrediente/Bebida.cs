using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    internal class Bebida : PorCantidad {
        public enum TipoBebida { Alcoholica, AltaEnAzucar, Normal }
        public TipoBebida Tipo { get; set; }
    }
}
