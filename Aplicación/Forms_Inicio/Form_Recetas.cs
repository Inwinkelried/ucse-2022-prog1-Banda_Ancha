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
    public partial class Form_Recetas : Form
    {
        public Form_Recetas()
        {
            InitializeComponent();
        }
        private void ActualizarGrilla()
        {
            LogicaReceta logicaIngrediente = new LogicaReceta();
            grillla_IngredientesRecetas.DataSource = null;
            grillla_IngredientesRecetas.DataSource = logicaIngrediente.LeerRecetas();
        }
        private void btn_Volver_Recetas_Click(object sender, EventArgs e) {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }

        private void btn_Volver_Recetas_Click_1(object sender, EventArgs e) {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }

        private void btn_NuevaReceta_Click(object sender, EventArgs e) {
            NuevaReceta nuevaReceta = new NuevaReceta();
            nuevaReceta.Show();
            this.Hide();
        }

        private void grillla_IngredientesRecetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
