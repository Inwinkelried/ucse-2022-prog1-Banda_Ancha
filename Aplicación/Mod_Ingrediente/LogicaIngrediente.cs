using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Schema;

namespace Aplicacion
{
    public class LogicaIngrediente : ArchivosIngredientes {
        
        public List<Ingrediente> ingredientesMinimo = new List<Ingrediente>();
        public List<Ingrediente> StockIngredientes = new List<Ingrediente>();

        //Metodo para agregar un ingrediente a una lista (Hay que revisar, no se si es factible)
        
        public LogicaIngrediente()
        {
            this.StockIngredientes = LeerIngredientes();
        }
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
        public int buscarIngrediente (string Nombre)
        {
            int Index = 0;
            StockIngredientes = LeerIngredientes();
            return Index = StockIngredientes.FindIndex(x => x.Nombre == Nombre);
            
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
                int index = StockIngredientes.FindIndex(x => x == ingrediente);
                int indexReceta = receta.CodigosIngredientes.FindIndex(x => x == ingrediente.Codigo);
                StockIngredientes[index].Cantidad -= receta.CantidadesIngredientes[indexReceta];
            }
            GuardarListaIngredientes(SerializarLista(StockIngredientes));
        }
        //Paso codigo de ingrediete como parametro, devuelve la lista de ingredientes
        public List<Ingrediente> FiltrarIngredientesCodigo(List<int> CodigosIngredientes)
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.FindAll(x => CodigosIngredientes.Contains(x.Codigo));
        }

        public bool RevisarExistencia(string Nombre)
        {
            StockIngredientes = LeerIngredientes();
            bool band = false;
            foreach (Ingrediente ingrediente in StockIngredientes)
            {   
                
                if (ingrediente.Nombre == Nombre)
                {
                    band = true;
                    break;
                }
            }
            return band;

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

        public decimal CostoDelIngrediente(Ingrediente ingrediente) 
        {
            decimal precio = ingrediente.Precio * (ingrediente.CantMinima - ingrediente.Cantidad);
            return precio;
        }

        //Getters
        public List<Carnes> getCarne()
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.Where(x => x is Carnes).Select(x => x as Carnes).ToList();
        }
        public List<Pescados> getPescado()
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.Where(x => x is Pescados).Select(x => x as Pescados).ToList();
        }
        public List<Panaderia> getPanaderia()
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.Where(x => x is Panaderia).Select(x => x as Panaderia).ToList();
        }
        public List<Bebida> getBebidas()
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
        }
        public List<Fruta> getFrutas()
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.Where(x => x is Fruta).Select(x => x as Fruta).ToList();
        }
        public List<HortalizaYVerdura> getVerduras()
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.Where(x => x is HortalizaYVerdura).Select(x => x as HortalizaYVerdura).ToList();
        }
        public List<Lacteo> getLacteos()
        {
            StockIngredientes = LeerIngredientes();
            return StockIngredientes.Where(x => x is Lacteo).Select(x => x as Lacteo).ToList();
        }


    }


}
