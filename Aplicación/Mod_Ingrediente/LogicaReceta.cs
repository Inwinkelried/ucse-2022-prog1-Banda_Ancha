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

        //Getter de la lista de recetas completa

        public LogicaReceta() {
            this.Recetas = LeerRecetas();
        }
        //Escritura de recetas (SERIALIZACION)
        public string SerializarListaRecetas(List<Receta> receta) {
            string ingredientesJson = JsonConvert.SerializeObject(receta);
            return ingredientesJson;
        }
        //Lectura de recetas (DESERIALIZACION) 
        public List<Receta> LeerRecetas() {
            string pathReceta = GetPathDominio() + path_Recetas;
            List<Receta> ListaReceta = new List<Receta>();
            if (VerificarArchivo(pathReceta)) {
                using (StreamReader lectorarchivos = new StreamReader(pathReceta)) {
                    string json = lectorarchivos.ReadToEnd();
                    ListaReceta = JsonConvert.DeserializeObject<List<Receta>>(json);
                }
            }
            return ListaReceta;

        }
        //Metodo para guardar la lista
        public void GuardarListaRecetas(string listaRecetas) {
            string pathRecetas = GetPathDominio() + path_Recetas;
            using (StreamWriter wrtr = new StreamWriter(pathRecetas, false)) {
                wrtr.Write(listaRecetas);
            }
        }
        //Anadir una receta
        public void AnadirUnaReceta(Receta receta) {
            Recetas = LeerRecetas();
            Recetas.Add(receta);
            GuardarListaRecetas(SerializarListaRecetas(Recetas));
        }
        //Eliminar una receta
        public void EliminarUnaReceta(string Codigo) {
            Recetas = LeerRecetas();
            int indice = Recetas.FindIndex(x => x.IDRECETA.ToString() == Codigo);
            Recetas.RemoveAt(indice);
            GuardarListaRecetas(SerializarListaRecetas(Recetas));
        }

        //Encontrar una receta por nombre
        public Receta FiltroNombreReceta(string Nombrereceta) {
            Receta receta;
            Recetas = LeerRecetas();
            return receta = Recetas.Find(x => x.Nombre == Nombrereceta);
        }
        private string GetPathDominio() {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        public void ActualizarRecetas(Receta receta) {
            List<Receta> recetas = new List<Receta>();
            recetas = LeerRecetas();
            List<string> codeRecetas = recetas.Select(x => x.IDRECETA.ToString()).ToList();
            if (!codeRecetas.Contains(receta.IDRECETA.ToString())) {
                recetas.Add(receta);
            } else {
                foreach (var r in recetas) {
                    if (r.IDRECETA == receta.IDRECETA) {

                        r.Nombre = receta.Nombre;
                        r.Saludable = receta.Saludable;
                        r.Ingredientes = receta.Ingredientes;
                        r.CantidadesIngredientes = receta.CantidadesIngredientes;
                        r.TipoDeReceta = receta.TipoDeReceta;
                    }
                }
            }
            GuardarListaRecetas(SerializarListaRecetas(recetas));
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
