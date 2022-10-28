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
        public List<int> CodigosIngredientes { get; set; }
        public Tipo_Receta TipoDeReceta { get; set; }

        [JsonIgnore]
        public List<Ingrediente> Ingredientes { get; set; }

        public Receta(int id, Tipo_Receta tipo, string Nombrereceta, bool saludable, List<int> idIngredientes)
        {   
            LogicaIngrediente ingrediente = new LogicaIngrediente();

            IDRECETA = id;
            Nombre = Nombrereceta;
            TipoDeReceta = tipo;           
            Saludable = saludable;
            Ingredientes = ingrediente.FiltrarIngredientesCodigo(idIngredientes);
            CodigosIngredientes = idIngredientes;

        }
    }
}
