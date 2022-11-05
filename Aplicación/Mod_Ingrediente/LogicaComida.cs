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
        public List<Comida> Comidasfiltradas = new List<Comida>();

        public LogicaComida() {
            this.Comidas = LeerComidas();
        }
        public string SerializarListaComidas(List<Comida> comida) {
            string ingredientesJson = JsonConvert.SerializeObject(comida);
            return ingredientesJson;
        }
        private string GetPathDominio() {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        //De Json a comida
        public List<Comida> LeerComidas() {
            if (VerificarArchivo(path_Comidas)) {
                string pathComidas = GetPathDominio() + path_Comidas;
                using (StreamReader reader = new StreamReader(pathComidas)) {
                    string json = reader.ReadToEnd();
                    List<Comida> HistorialComidasDesdeArchivo = JsonConvert.DeserializeObject<List<Comida>>(json);
                    return HistorialComidasDesdeArchivo;
                }
            } else return null;
        }
        //De Comida a Json
        public void GuardarLista(string listaSerializada) {
            string pathComidas = GetPathDominio() + path_Comidas;
            using (StreamWriter wrtr = new StreamWriter(pathComidas, false)) {
                wrtr.Write(listaSerializada);
            }
        }

        //Eliminar una comida
        public void EliminarComida(Comida comida) {
            Comidas = LeerComidas();
            int index = Comidas.FindIndex(x => x == comida);
            Comidas.RemoveAt(index);
            GuardarLista(SerializarListaComidas(Comidas));
        }

        //Agregar una comida
        public void AgregarComida(Comida comida) {
            Comidas = LeerComidas();
            Comidas.Add(comida);
            GuardarLista(SerializarListaComidas(Comidas));
        }
        public List<Comida> FiltroSinHarina() {
            Comidas = LeerComidas();
            LogicaIngrediente logicaIng = new LogicaIngrediente();
            LogicaReceta logica = new LogicaReceta();
            List<Comida> ListaSinHarina = new List<Comida>();
            foreach (Comida comida in Comidas) {
                foreach (Receta receta in logica.LeerRecetas()) {
                    if (receta.IDRECETA.ToString() == comida.CodigoReceta) {
                        bool bandera = true;
                        foreach (string codigo in receta.CodigosIngredientes) {
                            foreach (Ingrediente ingrediente in logicaIng.LeerIngredientes()) {
                                if (ingrediente.Codigo.ToString() == codigo && ingrediente is Panaderia) {
                                    bandera = false;
                                }
                            }
                        }
                        if (bandera) {
                            ListaSinHarina.Add(comida);
                        }
                    }
                }
            }
            return ListaSinHarina;

        }
        //Filtrar por saludable
        public List<Comida> FiltroSPoraludable() {

            return Comidas.Where(x => x.Receta.Saludable is true).ToList();
        }
        //Filtrar por tipo de receta
        public List<Comida> FiltroPorTipo(Tipo_Receta tipo) {
            Comidas = LeerComidas();
            List<Comida> comidasReturn = Comidas.Where(x => x.Receta.TipoDeReceta == tipo).ToList();
            return comidasReturn;
        }
        //Filtro por fecha
        public List<Comida> FiltroFecha(DateTime fechamenor, DateTime fechamayor) {
            Comidas = LeerComidas();
            List<Comida> comidasReturn = Comidas.FindAll(x => x.FechaCreacion >= fechamenor && x.FechaCreacion <= fechamayor).ToList();
            return comidasReturn;
        }
        private bool VerificarArchivo(string path) {
            if (File.Exists(path)) {
                return true;
            } else {
                File.WriteAllText(path, "[]");
                return false;
            }
        }
    }
}
