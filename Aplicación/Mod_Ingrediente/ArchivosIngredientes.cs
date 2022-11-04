using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace Aplicacion {
    //Todo lo que esta en archivos Ingredientes podría estar en la lógica, solo esta asi para visualzar mejor.
    public abstract class ArchivosIngredientes {

        public string path_Bebidas = "Bebidas.txt";
        public string path_Carnes = "Carnes.txt";
        public string path_Verduras = "Verduras.txt";
        public string path_Frutas = "Frutas.txt";
        public string path_Pescados = "Pescados.txt";
        public string path_Lacteos = "Lacteos.txt";
        public string path_Panaderia = "Panaderia.txt";
        public string path_Quesos = "Quesos.txt";




        //Lectores de archivos      
        public List<Ingrediente> LeerCarnes() 
        {
            string pathCarne = GetPathDominio() + path_Carnes;
            List<Carnes> ListaCarne = new List<Carnes>();
            if (VerificarArchivo(pathCarne))
            {
                using (StreamReader lectorarchivos = new StreamReader(pathCarne))
                {
                    string json = lectorarchivos.ReadToEnd();
                    ListaCarne = JsonConvert.DeserializeObject<List<Carnes>>(json);
                    List<Ingrediente> carnes = ListaCarne.Select(x => x as Ingrediente).ToList();
                    return carnes;
                }
            }
            else return null;

        }
        public List<Ingrediente> LeerBebidas() {
            string pathBebidas = GetPathDominio() + path_Bebidas;
            List<Bebida> ListaBebidas = new List<Bebida>();
            VerificarArchivo(pathBebidas);
            using (StreamReader lectorarchivos = new StreamReader(pathBebidas))
            {
                string json = lectorarchivos.ReadToEnd();
                ListaBebidas = JsonConvert.DeserializeObject<List<Bebida>>(json);
                List<Ingrediente> bebidas = ListaBebidas.Select(x => x as Ingrediente).ToList();
                return bebidas;
            }
        }

        public List<Ingrediente> LeerPanaderia() {
            string pathPanaderia = GetPathDominio() + path_Panaderia;
            List<Panaderia> ListaPanaderia = new List<Panaderia>();
            if (VerificarArchivo(pathPanaderia)) {
                using (StreamReader lectorarchivos = new StreamReader(pathPanaderia)) {
                    string json = lectorarchivos.ReadToEnd();
                    ListaPanaderia = JsonConvert.DeserializeObject<List<Panaderia>>(json);
                    List<Ingrediente> panaderia = ListaPanaderia.Select(x => x as Ingrediente).ToList();
                    return panaderia;
                }
            } else return null;

        }
        public List<Ingrediente> LeerVerduras() {
            string pathVerduras = GetPathDominio() + path_Verduras;
            List<HortalizaYVerdura> ListaVerduras = new List<HortalizaYVerdura>();
            if (VerificarArchivo(pathVerduras)) {
                using (StreamReader lectorarchivos = new StreamReader(pathVerduras)) {
                    string json = lectorarchivos.ReadToEnd();
                    ListaVerduras = JsonConvert.DeserializeObject<List<HortalizaYVerdura>>(json);
                    List<Ingrediente> verduras = ListaVerduras.Select(x => x as Ingrediente).ToList();
                    return verduras;
                }
            } else return null;

        }
        public List<Ingrediente> LeerFrutas() {
            string pathFrutas = GetPathDominio() + path_Frutas;
            List<Fruta> ListaFruta = new List<Fruta>();
            if (VerificarArchivo(pathFrutas)) {
                using (StreamReader lectorarchivos = new StreamReader(pathFrutas)) {
                    string json = lectorarchivos.ReadToEnd();
                    ListaFruta = JsonConvert.DeserializeObject<List<Fruta>>(json);
                    List<Ingrediente> frutas = ListaFruta.Select(x => x as Ingrediente).ToList();
                    return frutas;
                }
            } else return null;
        }
        public List<Ingrediente> LeerPescado() {
            string pathPescados = GetPathDominio() + path_Pescados;
            List<Pescados> ListaPescados = new List<Pescados>();
            if (VerificarArchivo(pathPescados)) {
                using (StreamReader lectorarchivos = new StreamReader(pathPescados)) {
                    string json = lectorarchivos.ReadToEnd();
                    ListaPescados = JsonConvert.DeserializeObject<List<Pescados>>(json);
                    List<Ingrediente> pescado = ListaPescados.Select(x => x as Ingrediente).ToList();
                    return pescado;
                }
            } else return null;

        }
        public List<Ingrediente> LeerLacteos() {
            string pathLacteos = GetPathDominio() + path_Lacteos;
            List<Lacteo> ListaLacteos = new List<Lacteo>();
            if (VerificarArchivo(pathLacteos)) {
                using (StreamReader lectorarchivos = new StreamReader(pathLacteos)) {
                    string json = lectorarchivos.ReadToEnd();
                    ListaLacteos = JsonConvert.DeserializeObject<List<Lacteo>>(json);
                    List<Ingrediente> lacteos = ListaLacteos.Select(x => x as Ingrediente).ToList();
                    return lacteos;
                }
            } else return null;

        }
        public List<Ingrediente> LeerQuesos() {
            string pathQuesos = GetPathDominio() + path_Quesos;
            List<Queso> ListaQuesos = new List<Queso>();
            if (VerificarArchivo(pathQuesos)) {
                using (StreamReader lectorarchivos = new StreamReader(pathQuesos)) {
                    string json = lectorarchivos.ReadToEnd();
                    ListaQuesos = JsonConvert.DeserializeObject<List<Queso>>(json);
                    List<Ingrediente> quesos = ListaQuesos.Select(x => x as Ingrediente).ToList();
                    return quesos;
                }
            } else return null;

        }
        protected string SerializarLista(List<Carnes> carnes) {
            string ingredientesJson = JsonConvert.SerializeObject(carnes);
            return ingredientesJson;
        }
        protected string SerializarLista(List<Fruta> frutas) {
            string ingredientesJson = JsonConvert.SerializeObject(frutas);
            return ingredientesJson;
        }
        protected string SerializarLista(List<Pescados> pescados) {
            string ingredientesJson = JsonConvert.SerializeObject(pescados);
            return ingredientesJson;
        }
        protected string SerializarLista(List<HortalizaYVerdura> verduras) {
            string ingredientesJson = JsonConvert.SerializeObject(verduras);
            return ingredientesJson;
        }
        protected string SerializarLista(List<Queso> quesos) {
            string ingredientesJson = JsonConvert.SerializeObject(quesos);
            return ingredientesJson;
        }
        protected string SerializarLista(List<Panaderia> ingredientes) {
            string ingredientesJson = JsonConvert.SerializeObject(ingredientes);
            return ingredientesJson;

        }
        protected string SerializarLista(List<Bebida> ingredientes) {
            string ingredientesJson = JsonConvert.SerializeObject(ingredientes);
            return ingredientesJson;

        }
        protected string SerializarLista(List<Lacteo> ingredientes) {
            string ingredientesJson = JsonConvert.SerializeObject(ingredientes);
            return ingredientesJson;

        }
        //Metodo para guardar en los archivos una lista ya serializada
        public void GuardarLista(string listaSerializada, string path_) {
            string pathIngredientes = GetPathDominio() + path_;
            using (StreamWriter wrtr = new StreamWriter(pathIngredientes, false)) {
                wrtr.Write(listaSerializada);
            }
        }
        private string GetPathDominio() {
            return AppDomain.CurrentDomain.BaseDirectory ;
        }
        //Verificar si el archivo existe o si hay que crearlo
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
