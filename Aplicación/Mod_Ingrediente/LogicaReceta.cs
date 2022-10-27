using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Aplicacion {
    public class LogicaReceta {

        string path_Recetas = "Recetas.txt";
        public List<Receta> Recetas = new List<Receta>();


        public List<Receta> GetRecetas() {
            return LeerRecetas().ToList<Receta>();
        }
        
        //Serializar recetas
        protected void SerializarListaRecetas(List<Receta> receta)
        {
            string ingredientesJson = JsonConvert.SerializeObject(receta);
        }
        //Lectura de recetas
        public List<Receta> LeerRecetas()
        {
            string path_ = GetPathDominio() + path_Recetas;
            using (StreamReader lectorarchivos = new StreamReader(path_))
            {
                string json = lectorarchivos.ReadToEnd();
                List<Receta> ListaRecetas = JsonConvert.DeserializeObject<List<Receta>>(json);
                return ListaRecetas;
            }
        }
        public void GuardarListaRecetas(string listaSerializada)
        {
            string pathRecetas = GetPathDominio() + path_Recetas;
            using (StreamWriter wrtr = new StreamWriter(pathRecetas, false))
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
