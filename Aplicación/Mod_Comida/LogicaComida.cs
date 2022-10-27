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
        public List<Receta> Recetasfiltradas (int tiporeceta) {
            throw new NotImplementedException();
        }
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
        public void GuardarLista(string listaSerializada)
        {
            string pathComidas = GetPathDominio() + path_Comidas;
            using (StreamWriter wrtr = new StreamWriter(pathComidas, false))
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
