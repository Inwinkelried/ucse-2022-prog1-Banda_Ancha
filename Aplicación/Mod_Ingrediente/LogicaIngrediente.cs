using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Ingrediente {
    public class LogicaIngrediente {
        
        public List<Ingrediente> ingredientesMinimo = new List<Ingrediente>();
        
        public List<Ingrediente> Ingredientes = new List<Ingrediente>();
        public List<Ingrediente> getIngredientes() {
            return Ingredientes;
        }
        
        //public List<Ingrediente> getIngredientesAlMinimo() {
        //    foreach (Ingrediente ingrediente in Ingredientes) {
        //        if (ingrediente.Cantidad <= ingrediente.CantMinima) {
        //            ingredientesMinimo.Add(ingrediente);
        //        }
        //    }
            
        //    return ingredientesMinimo;
        //}
        //debe retornar los ingredientes los cuales necesitan reposición, es decir cantidad <= cantidadMinim     

        public void DescontarIngrediente(int cantidad) { //una vez cargada una comida, se restan las cantidades de ingredientes de cada uno
            throw new NotImplementedException();
        }

        public void AgregarIngrediente(int cantidad) {
            throw new NotImplementedException();
        }

        public decimal CostoDelIngrediente() {
            throw new NotImplementedException();
        }
        


    }


}
