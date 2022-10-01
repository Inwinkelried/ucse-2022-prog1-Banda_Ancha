using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {
    public class Receta : Archivos {
        public bool Saludable { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
        //public enum Tipo { get; set; } //se implementara un enumerador para saber el tipo de comida: desayuno, almuerzo, etc

    }
}
