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


        public string path_verduras = "Verduras.txt";
        public string path_Frutas = "Frutas.txt";
        public string path_Carnes = "Carnes.txt";
        public string path_Pollo = "Pollo.txt";
        public string path_Pescado = "Pescado.txt";
        public string path_Panaderia = "Panaderia.txt";
        public string path_Lacteos = "Lacteos.txt";


        protected void SerializarLista(List<Ingrediente> ingredientes)
        {
            string ingredientesJson = JsonConvert.SerializeObject(ingredientes);
        }
        /*protected void SerializarLista(List<Bebida> bebidas)
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
        protected void SerializarLista(List<Carnes> carnes)
        {
            string ingredientesJson = JsonConvert.SerializeObject(carnes);
        }
        protected void SerializarLista(List<Panaderia> panaderias)
        {
            string ingredientesJson = JsonConvert.SerializeObject(panaderias);
        }
        protected void SerializarLista(List<Pescados> pescados)
        {
            string ingredientesJson = JsonConvert.SerializeObject(pescados);
        }*/


    //Getters
        public List<Carnes> getCarne (List<Ingrediente> ingredientes)
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





        public void GuardarLista(string listaSerializada, string nombredelarchivo)
        {
            string pathArchivo = GetPathDominio() + nombredelarchivo;
            using (StreamWriter wrtr = new StreamWriter(pathArchivo, false))
            {
                wrtr.Write(listaSerializada);
            }
        }
        private string GetPathDominio()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "\\JSON\\";
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
