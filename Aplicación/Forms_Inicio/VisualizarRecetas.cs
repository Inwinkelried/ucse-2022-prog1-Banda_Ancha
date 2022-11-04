using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion;

namespace Forms_Inicio
{
    public partial class VisualizarRecetas : Form
    {
        public VisualizarRecetas()
        {
            InitializeComponent();
        }
        private void ActualizarGrilla()
        {
            LogicaReceta receta = new LogicaReceta();
            grilla_Recetas.DataSource = null;
            grilla_Recetas.DataSource = receta.LeerRecetas();
        }
        private void VisualizarRecetas_Load(object sender, EventArgs e)
        {
            grilla_Recetas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void grilla_Recetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Recetas, "Eliminar");
            int indiceEditar = UtilidadesGrilla.getIndexColumna(grilla_Recetas, "Editar");
            LogicaIngrediente logicaIng = new LogicaIngrediente();

            if (indiceEditar == e.ColumnIndex)
            {

                foreach (DataGridViewRow columna in grilla_Recetas.Rows)
                {

                    string Codigo = Convert.ToString(columna.Cells[2].Value);
                    string Nombre = Convert.ToString(columna.Cells[0].Value);
                    decimal Cantidad = Convert.ToDecimal(columna.Cells[1].Value);
                    logicaIng.ModificarIngrediente(Codigo, Cantidad, Nombre);
                    ActualizarGrilla();
                    break;


                }
            }
            if (indiceEliminar == e.ColumnIndex)
            {

                LogicaReceta logicaRecetas = new LogicaReceta();
                var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grilla_Recetas, "Codigo");
                string codigoReceta = grilla_Recetas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                logicaRecetas.EliminarUnaReceta(codigoReceta);
                ActualizarGrilla();

            }
        }
    }
}
