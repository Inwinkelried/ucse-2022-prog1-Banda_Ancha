using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Aplicacion {
    public class Receta  {
         
        public int IDRECETA { get; set; }
        public string Nombre { get; set; }
        public bool Saludable { get; set; }
        
        public List<int> CantidadesIngredientes = new List<int>();
        public Tipo_Receta TipoDeReceta { get; set; }

        [JsonIgnore]
        public List<Ingrediente> Ingredientes = new List<Ingrediente>();

        public List<string> CodigosIngredientes { get; set; }

    }
}
