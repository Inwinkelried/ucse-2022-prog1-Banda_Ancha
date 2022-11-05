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

namespace Forms_Inicio {
    public partial class VisualizarRecetas : Form {
        public VisualizarRecetas() {
            InitializeComponent();
        }
        private void ActualizarGrilla() {
            LogicaReceta receta = new LogicaReceta();
            grilla_Recetas.DataSource = null;
            grilla_Recetas.DataSource = receta.LeerRecetas();
        }
        private void VisualizarRecetas_Load(object sender, EventArgs e) {
            grilla_Recetas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void grilla_Recetas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            UtilidadesGrilla utilidad = new UtilidadesGrilla();
            utilidad.CargarCamposAcciones(grilla_Recetas);
        }
        private void grilla_Recetas_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            int indiceEditar = UtilidadesGrilla.getIndexColumna(grilla_Recetas, "Editar");
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Recetas, "Eliminar");

            if (e.RowIndex >= 0) {
                Receta receta = grilla_Recetas.Rows[e.RowIndex].DataBoundItem as Receta;
                string codigo = receta.IDRECETA.ToString();

                if (indiceEliminar == e.ColumnIndex) {
                    LogicaReceta logica = new LogicaReceta();
                    logica.EliminarUnaReceta(codigo);
                    ActualizarGrilla();
                }
            }

        }

        private void btn_Volver_VisualizarRecetas_Click(object sender, EventArgs e) {
            Form_Recetas recetas = new Form_Recetas();
            recetas.Show();
            this.Close();
        }
    }
}
