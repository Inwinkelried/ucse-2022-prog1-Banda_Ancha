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
        public List<Receta> GetRecetasFiltradas() { //devuelve lista de recetas filtradas por los ingredientes que el usuario tenga en la despensa
            //public List<Receta> RecetasFiltradas = new List<Receta>();

            //foreach (Receta receta in )
            throw new NotImplementedException();
        }
    }
}
