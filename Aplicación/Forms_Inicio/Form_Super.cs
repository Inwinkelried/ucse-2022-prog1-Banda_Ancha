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
    public partial class Form_Super : Form
    {
        public Form_Super()
        {
            InitializeComponent();
        }

        private void Form_Super_Load(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Super_Click(object sender, EventArgs e) {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }
    }
}
