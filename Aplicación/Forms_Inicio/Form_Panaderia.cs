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
    public partial class Form_Panaderia : Form
    {
        public Form_Panaderia()
        {
            InitializeComponent();
        }

        private void btn_volver_Panaderia_Click(object sender, EventArgs e)
        {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }
    }
}
