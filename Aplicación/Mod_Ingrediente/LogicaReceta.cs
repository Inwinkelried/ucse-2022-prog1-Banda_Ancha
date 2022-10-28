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
        public List<Receta> GetRecetas() {
            return LeerRecetas().ToList<Receta>();
        }
        
        //Serializar recetas
        protected string SerializarListaRecetas(List<Receta> receta)
        {
            string ingredientesJson = JsonConvert.SerializeObject(receta);
            return ingredientesJson;
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
        //Metodo para guardar la lista
        public void GuardarListaRecetas(string listaSerializada)
        {
            string pathRecetas = GetPathDominio() + path_Recetas;
            using (StreamWriter wrtr = new StreamWriter(pathRecetas, false))
            {
                wrtr.Write(listaSerializada);
            }
        }
        //Guardar una receta
        public void CargarUnaReceta(Receta receta)
        {
            Recetas = LeerRecetas();
            Recetas.Add(receta);
            GuardarListaRecetas(SerializarListaRecetas(Recetas));
        }
        //Eliminar una receta
        public void EliminarUnaReceta(Receta receta)
        {
            Recetas = LeerRecetas();
            int index = Recetas.FindIndex(x => x.IDRECETA == receta.IDRECETA);
            Recetas.RemoveAt(index);
        }

        //Filtrar por saludable
        public List<Receta> FiltroSPoraludable()
        {
            Recetas = LeerRecetas();
            return Recetas.Where(x => x.Saludable is true).ToList();
        }
        //Filtrar por tipo de receta
        public List<Receta> FiltroPorTipo(Tipo_Receta tipo)
        {
            Recetas = LeerRecetas();
            return Recetas.Where(x => x.TipoDeReceta == tipo).ToList();


        }
        //Encontrar una receta por nombre
        public Receta FiltroNombreReceta (string Nombrereceta)
        {
            Receta receta;
            Recetas = LeerRecetas();
            return receta = Recetas.Find(x => x.Nombre == Nombrereceta);
        }
        private string GetPathDominio()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "\\JSON\\";
        }
    }
}
