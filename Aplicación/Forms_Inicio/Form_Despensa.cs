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
    public partial class Form_Despensa : Form
    {
        public Form_Despensa()
        {
            InitializeComponent();
        }

        private void btn_bebidas_Click(object sender, EventArgs e)
        {
            Form_Bebidas verBebidas = new Form_Bebidas();
            verBebidas.Show();
            this.Hide();
        }

        private void btn_Carnes_Click(object sender, EventArgs e)
        {
            Form_Carne verCarne = new Form_Carne();
            verCarne.Show();
            this.Hide();
        }

        private void btn_Pescado_Click(object sender, EventArgs e)
        {
            Form_Pescado verPescado = new Form_Pescado();
            verPescado.Show();
            this.Hide();
        }

        private void btn_pan_Click(object sender, EventArgs e)
        {
            Form_Panaderia verPanaderia = new Form_Panaderia();
            verPanaderia.Show();
            this.Hide();
        }

        private void btn_Frutas_Click(object sender, EventArgs e)
        {
            Form_Frutas verFrutas = new Form_Frutas();
            verFrutas.Show();
            this.Hide();
        }

        private void btn_Verduras_Click(object sender, EventArgs e)
        {
            Form_Verduras verVerduras = new Form_Verduras();
            verVerduras.Show();
            this.Hide();
        }

        

        private void btn_Volver_Despensa_Click(object sender, EventArgs e)
        {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }
    }
}
