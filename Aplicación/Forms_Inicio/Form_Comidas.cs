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
    public partial class Form_Comidas : Form
    {
        public Form_Comidas()
        {
            InitializeComponent();
        }

        private void btn_Volver_Comidas_Click(object sender, EventArgs e) 
        {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }
        private void ActualizarGrilla()
        {
            LogicaComida logicacomida = new LogicaComida(); 
            grilla_Comidas.DataSource = null;
            grilla_Comidas.DataSource = logicacomida.LeerComidas();
        }
        private void grilla_Comidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Comidas_Load(object sender, EventArgs e)
        {
            grilla_Comidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
    }
}
