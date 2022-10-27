using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace Aplicacion
{   
    //Todo lo que esta en archivos Ingredientes podría estar en la lógica, solo esta asi para visualzar mejor.
    public abstract class ArchivosIngredientes
    {
        public string path_Ingredientes = "Ingredientes.txt";
        protected string SerializarLista(List<Ingrediente> ingredientes)
        {
            string ingredientesJson = JsonConvert.SerializeObject(ingredientes);
            return ingredientesJson;
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

        //Lector de archivos
        public List<Ingrediente> LeerIngredientes()
        {
            string path_ = GetPathDominio() + path_Ingredientes;
            using (StreamReader lectorarchivos = new StreamReader(path_))
            {
                string json = lectorarchivos.ReadToEnd();
                List<Ingrediente> ListaIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(json);
                return ListaIngredientes;
            }
        }
        
        //Metodo para guardar en los archivos una lista ya serializada
        public void GuardarListaIngredientes(string listaSerializada)
        {
            string pathIngredientes = GetPathDominio() + path_Ingredientes;
            using (StreamWriter wrtr = new StreamWriter(pathIngredientes, false))
            {
                wrtr.Write(listaSerializada);
            }
        }
        
        private string GetPathDominio()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "\\JSON\\";
        }
    }
}
