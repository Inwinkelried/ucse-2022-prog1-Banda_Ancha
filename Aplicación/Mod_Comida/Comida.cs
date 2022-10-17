using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class Comida : Archivos {
        public Receta Receta { get; set; }
        public DateTime FechaCreacion { get; set; }

        public void DescontarIngredientes() {
           throw new NotImplementedException();
        }
    }
}
