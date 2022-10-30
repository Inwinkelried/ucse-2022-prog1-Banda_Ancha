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
       
        

        //Lector de archivos
        public List<Ingrediente> LeerIngredientes()
        {
            string pathIngredientes = GetPathDominio() + path_Ingredientes;
            using (StreamReader lectorarchivos = new StreamReader(pathIngredientes)) 
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
