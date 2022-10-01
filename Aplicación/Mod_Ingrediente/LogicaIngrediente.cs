using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Ingrediente {
    public class LogicaIngrediente {
        public List<Ingrediente> Ingredientes = new List<Ingrediente>();
        public List<Ingrediente> getIngredientes() {
            return Ingredientes;
        }
        public List<Ingrediente> getIngredientesAlMinimo() {
            throw new NotImplementedException(); //debe retornar los ingredientes los cuales necesitan reposición, es decir cantidad <= cantidadMinima

        }
        



    }
}
