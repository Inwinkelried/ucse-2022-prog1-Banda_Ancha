using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Aplicacion
{
    public class LogicaIngrediente : ArchivosIngredientes {
        
        public List<Ingrediente> ingredientesMinimo = new List<Ingrediente>();
        public List<Ingrediente> StockIngredientes = new List<Ingrediente>();

        //Metodo para agregar un ingrediente a una lista (Hay que revisar, no se si es factible)
        
        public List<Ingrediente> getAllIngredientes()
        {
            return LeerIngredientes().ToList<Ingrediente>();
        }
        public void eliminarIngrediente(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            int IndexDelete = StockIngredientes.FindIndex(x => x.Codigo == ingrediente.Codigo);
            StockIngredientes.RemoveAt(IndexDelete);            
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        public void agregarIngredientes(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            StockIngredientes.Add(ingrediente);
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        public void ModificarIngrediente(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            int IndexDelete = StockIngredientes.FindIndex(x => x.Codigo == ingrediente.Codigo);
            StockIngredientes[IndexDelete] = ingrediente;
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        public List<Ingrediente> getListaSuper()
        {         
            StockIngredientes = LeerIngredientes();
            ingredientesMinimo = StockIngredientes.FindAll(x => x.Cantidad >= x.CantMinima);
            return ingredientesMinimo;
        }
        // Luego de seleccionar una receta elimina los ingredientes de el stock
        public void actualizarIngredientesRecetas(Receta receta)
        {
            StockIngredientes = LeerIngredientes();
            foreach (Ingrediente ingrediente in receta.ingredientes)
            {
                
            }
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
