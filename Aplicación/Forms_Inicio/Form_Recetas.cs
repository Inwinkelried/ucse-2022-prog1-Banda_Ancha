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
    public partial class Form_Recetas : Form
    {
        public Form_Recetas()
        {
            InitializeComponent();
        }

        private void btn_Volver_recetas_Click(object sender, EventArgs e) {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }
    }
}
