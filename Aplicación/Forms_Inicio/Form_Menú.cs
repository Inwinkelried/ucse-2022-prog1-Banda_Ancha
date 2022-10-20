using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Inicio
{
    public partial class Form_Menú : Form
    {
        public Form_Menú()
        {
            InitializeComponent();
        }

        private void btn_Despensa_Click(object sender, EventArgs e)
        {
            Form_Despensa formDespensa = new Form_Despensa();
            formDespensa.Show();
            this.Hide();
        }

        private void btn_Recetas_Click(object sender, EventArgs e)
        {
            Form_Recetas formRecetas = new Form_Recetas();
            formRecetas.Show();
            this.Hide();
        }

        private void btn_Super_Click(object sender, EventArgs e)
        {
            Form_Super formSuper = new Form_Super();
            formSuper.Show();
            this.Hide();

        }

        private void btn_Comidas_Click(object sender, EventArgs e)
        {
            Form_Comidas formComidas = new Form_Comidas();
            formComidas.Show();
            this.Hide();
        }

        private void Form_Menú_Load(object sender, EventArgs e)
        {

        }
    }
}
