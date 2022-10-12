using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class Receta : Archivos {
        public enum Tipo {Desayuno, Almuerzo, Merienda, Cena} 
        public bool Saludable { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
        public Tipo TipoDeReceta { get; set; }
       

    }
}
