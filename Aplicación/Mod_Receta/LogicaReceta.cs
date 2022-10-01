using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Receta {
    public class LogicaReceta {
        public List<Receta> Recetas = new List<Receta>();

        public List<Receta> GetRecetas() {
            return Recetas;
        }
    }
}
