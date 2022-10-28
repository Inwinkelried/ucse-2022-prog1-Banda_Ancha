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
        //Eliminar un ingrediente de la lista
        public void eliminarIngrediente(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            int IndexDelete = StockIngredientes.FindIndex(x => x.Codigo == ingrediente.Codigo);
            StockIngredientes.RemoveAt(IndexDelete);            
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        //Agregar un ingrediente nuevo a la lista
        public void agregarIngredientes(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            StockIngredientes.Add(ingrediente);
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        //Metodo para actualizar algun ingrediente
        public void ModificarIngrediente(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            int IndexDelete = StockIngredientes.FindIndex(x => x.Codigo == ingrediente.Codigo);
            StockIngredientes[IndexDelete] = ingrediente;
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        //Preguntar al profe si esta lista va acá o en modsuper
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
            foreach (Ingrediente ingrediente in receta.Ingredientes)
            {
                Ingrediente ingrediente1 = StockIngredientes.Find(x => x.Codigo == ingrediente.Codigo); 
                ingrediente1.Cantidad -= ingrediente.Cantidad;
                int index = StockIngredientes.FindIndex(x => x.Codigo == ingrediente1.Codigo);
                StockIngredientes[index] = ingrediente;
            }
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        //Paso codigo de ingrediete como parametro y retorna la lista con los codigos
        public List<Ingrediente> FiltrarIngredientesCodigo(List<int> CodigosIngredientes)
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.FindAll(x => CodigosIngredientes.Contains(x.Codigo));
        }

        //Antes de hablititar una comida, reviso que esten los ingredientes necesarios en la despensa
        public bool CheckIngredientesReceta (Receta receta)
        {
            bool encontrado = false;
            StockIngredientes = LeerIngredientes();
            foreach (Ingrediente ingredienteReceta in receta.Ingredientes)
            {
                Ingrediente ingrediente = StockIngredientes.Find(x => x.Codigo == ingredienteReceta.Codigo);
                if (ingrediente.Cantidad >= ingredienteReceta.Cantidad)
                {
                    encontrado = true;
                }
                else
                {
                    encontrado = false;
                    break;
                }
            }
            return encontrado;
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
