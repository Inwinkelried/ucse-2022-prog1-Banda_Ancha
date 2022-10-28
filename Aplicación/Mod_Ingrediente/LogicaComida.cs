using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacion;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Aplicacion {
    public class LogicaComida {

        string path_Comidas = "Comidas.txt";
        public List<Comida> Comidas = new List<Comida>();
        
        protected string SerializarListaComidas(List<Comida> comida)
        {
            string ingredientesJson = JsonConvert.SerializeObject(comida);
            return ingredientesJson;
        }
        private string GetPathDominio()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "\\JSON\\";
        }
        //De Json a comida
        public List<Comida> LeerComidas()
        {
            string pathComidas = GetPathDominio() + path_Comidas;
            using (StreamReader reader = new StreamReader(pathComidas))
            {
                string json = reader.ReadToEnd();
                List<Comida> HistorialComidasDesdeArchivo = JsonConvert.DeserializeObject<List<Comida>>(json);
                return HistorialComidasDesdeArchivo;
            }
        }
        //De Comida a Json
        public void GuardarLista(string listaSerializada)
        {
            string pathComidas = GetPathDominio() + path_Comidas;
            using (StreamWriter wrtr = new StreamWriter(pathComidas, false))
            {
                wrtr.Write(listaSerializada);
            }
        }

        //Eliminar una comida
        public void EliminarComida (Comida comida)
        {
            Comidas = LeerComidas();
            int index = Comidas.FindIndex(x => x == comida);
            Comidas.RemoveAt(index);
            GuardarLista(SerializarListaComidas(Comidas));
        }

        //Agregar una comida
        public void AgregarComida (Comida comida)
        {   
            Comidas = LeerComidas();
            Comidas.Add(comida);
            GuardarLista(SerializarListaComidas(Comidas));
        }
        
    }
}
