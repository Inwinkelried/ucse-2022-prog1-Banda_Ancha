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
    public class LogicaIngrediente {
        
        public List<Ingrediente> ingredientesMinimo = new List<Ingrediente>();
        public List<Ingrediente> Ingredientes = new List<Ingrediente>();


        public string path_verduras = @"c:\Ingredientes\verduras.txt";
        public string path_Frutas = @"c:\Ingredientes\Frutas.txt";
        public string path_Carnes = @"c:\Ingredientes\Carnes.txt";
        public string path_Pollo = @"c:\Ingredientes\Pollo.txt";
        public string path_Pescado = @"c:\Ingredientes\Pescado.txt";
        public string path_Panaderia = @"c:\Ingredientes\Panaderia.txt";


        protected void SerializarLista(List<Lacteo> lacteos)
        {
            string ingredientesJson = JsonConvert.SerializeObject(lacteos);
        }
        protected void SerializarLista(List<Bebida> bebidas)
        {
            string ingredientesJson = JsonConvert.SerializeObject(bebidas);
        }
        protected void SerializarLista(List<Fruta> frutas)
        {
            string ingredientesJson = JsonConvert.SerializeObject(frutas);
        }
        protected void SerializarLista(List<HortalizaYVerdura> verduras)
        {
            string ingredientesJson = JsonConvert.SerializeObject(verduras);
        }
        protected void SerializarLista(List<Lacteo> lacteos)
        {
            string ingredientesJson = JsonConvert.SerializeObject(lacteos);
        }




        public bool EscribirIngredientes(List<Ingrediente> ingredientes, string path_)
        {
            using (StreamWriter escritor = new StreamWriter(path_, false))
            {
                string ingredientesJson = JsonConvert.SerializeObject(ingredientes);
                escritor.Write(ingredientesJson);
                return true;
            }
        }

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
