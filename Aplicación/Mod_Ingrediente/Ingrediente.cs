using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public abstract class Ingrediente {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal CantMinima { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }


    }
}
