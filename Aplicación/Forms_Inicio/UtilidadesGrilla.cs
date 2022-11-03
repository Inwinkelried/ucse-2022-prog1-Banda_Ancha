using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Inicio
{
    internal class UtilidadesGrilla 
    {
        internal static int getIndexColumna(DataGridView grilla, string nombreColumna)
        {
            int indexColumna = -1;
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                if (column.Name == nombreColumna)
                {
                    return indexColumna = column.Index;
                }
            }
            throw new Exception("No hay una columna con nombre solicitado en la grilla");


        }

    }
}
