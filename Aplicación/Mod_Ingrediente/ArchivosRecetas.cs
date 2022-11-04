using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion;

namespace Aplicacion
{
    public  class ArchivosRecetas : Receta
    {
        public List<string> CodigosIngredientes { get; set; }
    }
}
