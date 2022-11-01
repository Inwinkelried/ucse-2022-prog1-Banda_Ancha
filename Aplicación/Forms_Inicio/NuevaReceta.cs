using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Inicio {
    public partial class NuevaReceta : Form {
        public NuevaReceta() {
            InitializeComponent();
           
        }

        public void VolverARecetas() {
            Form_Recetas recetas = new Form_Recetas();
            recetas.Show();
            this.Hide();
        }

        private void btn_Volver_NuevaReceta_Click(object sender, EventArgs e) {
            VolverARecetas();
        }

        private void btn_confirmarReceta_Click(object sender, EventArgs e) {
            Txt_nombre.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) {
            MessageBox.Show("Su receta no se guardó");
            VolverARecetas();

        }

    }   
}
