using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mod_Ingrediente {
    public class Archivos_Ingrediente {
        
        public List<Ingrediente> Ingredientes = new List<Ingrediente>();
        string path = @"c:\ingredientes.txt";
        public void EscribirIngredientes(List<Ingrediente> ingredientes) {
            
            
            string ingredientesJson = JsonConvert.SerializeObject(ingredientes.ToArray(), Formatting.Indented);
            File.WriteAllText(path, ingredientesJson);  
        }
        public void LeerIngredientes() {
            using (var StreamReader = new StreamReader(path));

        }

    }
}
