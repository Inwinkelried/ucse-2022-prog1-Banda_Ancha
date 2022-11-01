﻿using System;
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
        public List<Ingrediente> LeerIngredientes()
        {
            return getAllIngredientes(LeerCarnes(), LeerVerduras(), LeerFrutas(), LeerBebidas(), LeerPanaderia(), LeerPescado(), LeerLacteos(), LeerQuesos());
        }

        
      /*  private void guardarCarnes() 
        {
            List<Carnes> carnes = getCarne(StockIngredientes);
            GuardarLista(SerializarLista(carnes), path_Carnes) ;
        }
        private void guardarQuesos()
        {
            List<Queso> queso = getQuesos(StockIngredientes);
            GuardarLista(SerializarLista(queso), path_Quesos);
        }
        private void guardarVerduras()
        {
            List<HortalizaYVerdura> verduras = getVerduras (StockIngredientes);
            GuardarLista(SerializarLista(verduras), path_Verduras);
        }
        private void guardarPescados()
        {
            List<Pescados> pescado = getPescado (StockIngredientes);
            GuardarLista(SerializarLista(pescado), path_Pescados);
        }
        private void guardarPanaderia()
        {
            List<Panaderia> panaderia = getPanaderia (StockIngredientes);
            GuardarLista(SerializarLista(panaderia), path_Panaderia);
        }
        private void guardarFrutas()
        {
            List<Fruta> frutas = getFrutas (StockIngredientes);
            GuardarLista(SerializarLista(frutas), path_Frutas);
        }
        private void guardarBebidas()
        {
            List<Bebida > bebidas = getBebidas (StockIngredientes);
            GuardarLista(SerializarLista(bebidas), path_Bebidas);
        }
        private void guardarLacteos()
        {
            List<Lacteo> lacteo = getLacteos (StockIngredientes);
            GuardarLista(SerializarLista(lacteo), path_Lacteos);
        }*/
      //Guarda todos los ingredientes en sus respectivas listas
        private void GuardarListaIngredientes()
        {
            List<Lacteo> lacteo = getLacteos(StockIngredientes);
            GuardarLista(SerializarLista(lacteo), path_Lacteos);
            List<Bebida> bebidas = getBebidas(StockIngredientes);
            GuardarLista(SerializarLista(bebidas), path_Bebidas);
            List<Fruta> frutas = getFrutas(StockIngredientes);
            GuardarLista(SerializarLista(frutas), path_Frutas);
            List<Panaderia> panaderia = getPanaderia(StockIngredientes);
            GuardarLista(SerializarLista(panaderia), path_Panaderia);
            List<Pescados> pescado = getPescado(StockIngredientes);
            GuardarLista(SerializarLista(pescado), path_Pescados);
            List<HortalizaYVerdura> verduras = getVerduras(StockIngredientes);
            GuardarLista(SerializarLista(verduras), path_Verduras);
            List<Queso> queso = getQuesos(StockIngredientes);
            GuardarLista(SerializarLista(queso), path_Quesos);
            List<Carnes> carnes = getCarne(StockIngredientes);
            GuardarLista(SerializarLista(carnes), path_Carnes);
        }













        //Eliminar un ingrediente de la lista
        public void eliminarIngrediente(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            int IndexDelete = StockIngredientes.FindIndex(x => x.Codigo == ingrediente.Codigo);
            StockIngredientes.RemoveAt(IndexDelete);
            GuardarListaIngredientes();
        }
        //Agregar un ingrediente nuevo a la lista
        public void agregarIngredientes(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            StockIngredientes.Add(ingrediente);
            GuardarListaIngredientes();
        }
        //Metodo para actualizar algun ingrediente
        public void ModificarIngrediente(Ingrediente ingrediente)
        {
            StockIngredientes = LeerIngredientes();
            int IndexDelete = StockIngredientes.FindIndex(x => x.Codigo == ingrediente.Codigo);
            StockIngredientes[IndexDelete] = ingrediente;
            GuardarListaIngredientes();
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
            GuardarListaIngredientes();
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
        public List<Carnes> getCarne(List<Ingrediente> ingredientes)
        {         
            return ingredientes.Where(x => x is Carnes).Select(x => x as Carnes).ToList();
        }
        public List<Pescados> getPescado(List<Ingrediente> ingredientes)
        {            
            return ingredientes.Where(x => x is Pescados).Select(x => x as Pescados).ToList();
        }
        public List<Panaderia> getPanaderia(List<Ingrediente> ingredientes)
        {           
            return ingredientes.Where(x => x is Panaderia).Select(x => x as Panaderia).ToList();
        }
        public List<Bebida> getBebidas(List<Ingrediente> ingredientes)
        {           
            return ingredientes.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
        }
        public List<Fruta> getFrutas(List<Ingrediente> ingredientes)
        {            
            return ingredientes.Where(x => x is Fruta).Select(x => x as Fruta).ToList();
        }
        public List<HortalizaYVerdura> getVerduras(List<Ingrediente> ingredientes)
        {            
            return ingredientes.Where(x => x is HortalizaYVerdura).Select(x => x as HortalizaYVerdura).ToList();
        }
        public List<Lacteo> getLacteos(List<Ingrediente> ingredientes)
        {            
            return ingredientes.Where(x => x is Lacteo).Select(x => x as Lacteo).ToList();
        }
        public List<Queso> getQuesos (List<Ingrediente> ingredientes)
        {
            return ingredientes.Where(x => x is Queso).Select(x => x as Queso).ToList();
        }
        private List<Ingrediente> getAllIngredientes( List<Ingrediente> Verduras, List<Ingrediente> Frutas, List<Ingrediente> Bebida, List<Ingrediente> Panaderia, List<Ingrediente> Pescados, List<Ingrediente> Lacteos, List<Ingrediente> Queso, List<Ingrediente> Carnes)
        {
            Carnes.AddRange(Verduras);
            Carnes.AddRange(Frutas);
            Carnes.AddRange(Bebida);
            Carnes.AddRange(Panaderia);
            Carnes.AddRange(Pescados);
            Carnes.AddRange(Lacteos);
            Carnes.AddRange(Queso);
            return Carnes;
        }


    }


}
