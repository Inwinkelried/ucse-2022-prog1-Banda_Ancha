using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Aplicacion {
    public class Comida {
        public string Codigo { get; set; }
        public string CodigoReceta { get; set; }
        public string NombreRec { get; set; }
        public DateTime FechaCreacion { get; set; }
        [JsonIgnore]
        public Receta Receta { get; set; }



        public Comida(string codigo, string codigoreceta, Receta receta, string nombreReceta, DateTime fecha) {
            Codigo = codigo;
            CodigoReceta = codigoreceta;
            Receta = receta;
            NombreRec = nombreReceta;
            FechaCreacion = fecha;
        }
    }
}
