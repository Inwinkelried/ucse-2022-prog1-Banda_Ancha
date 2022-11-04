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

        public LogicaReceta()
        {
            this.Recetas = LeerRecetas();
        }
        
        
        //Escritura de recetas (SERIALIZACION)
        protected string SerializarListaRecetas(List<Receta> receta)
        {
            string ingredientesJson = JsonConvert.SerializeObject(receta);
            return ingredientesJson;
        }

        //Lectura de recetas (DESERIALIZACION)
        public List<Receta> LeerRecetas()
        {          
            string pathRecetas = GetPathDominio() + path_Recetas;
            List<Receta> ListaRecetas = new List<Receta>();
            if (VerificarArchivo(path_Recetas))
            {
                using (StreamReader lectorarchivos = new StreamReader(pathRecetas))
                {
                    string json = lectorarchivos.ReadToEnd();
                    ListaRecetas = JsonConvert.DeserializeObject<List<Receta>>(json);

                    return ListaRecetas;
                }
            }
            else return null;
        }

        //Metodo para guardar la lista
        public void GuardarListaRecetas(string listaRecetas)
        {
            string pathRecetas = GetPathDominio() + path_Recetas;
            using (StreamWriter wrtr = new StreamWriter(pathRecetas, false))
            {
                wrtr.Write(listaRecetas);
            }
        }
        //Anadir una receta
        public void AnadirUnaReceta(Receta receta)
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

        
        //Filtrar por sin harinas
        
        
        //Filtrar por

        //Encontrar una receta por nombre
        public Receta FiltroNombreReceta (string Nombrereceta)
        {
            Receta receta;
            Recetas = LeerRecetas();
            return receta = Recetas.Find(x => x.Nombre == Nombrereceta);
        }
        private string GetPathDominio()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        public void ActualizarRecetas(Receta receta)
        {
            List<Receta> recetas = new List<Receta>();
            recetas = LeerRecetas();
            List<string> codeRecetas = recetas.Select(x => x.IDRECETA.ToString()).ToList();
            if (!codeRecetas.Contains(receta.IDRECETA.ToString())) 
            {
                recetas.Add(receta);
            }
            else
            {
                
                foreach (var r in recetas)
                {
                    if (r.IDRECETA == receta.IDRECETA) 
                    {
                        
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
        private bool VerificarArchivo(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                File.WriteAllText(path, "[]");
                return false;
            }
        }
    }
}
