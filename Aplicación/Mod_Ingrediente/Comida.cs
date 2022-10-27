using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class Comida  {
        public Receta Receta { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Comida( Receta receta, DateTime fechacreacion)
        {
            Receta = receta;
            FechaCreacion = fechacreacion;
        }
    }
}
