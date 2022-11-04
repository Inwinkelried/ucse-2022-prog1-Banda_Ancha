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
    public partial class Form_Super : Form
    {
        public Form_Super()
        {
            InitializeComponent();
        }

        private void Form_Super_Load(object sender, EventArgs e)
        {
            grilla_Super.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void btn_Volver_Super_Click(object sender, EventArgs e) {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }

        private void btn_GeneraCarrito_Click(object sender, EventArgs e)
        {
            grilla_Super.AutoGenerateColumns = false;
            ActualizarGrilla();

        }
        private void ActualizarGrilla()
        {
           LogicaIngrediente logica = new LogicaIngrediente();
           grilla_Super.DataSource = null;
           grilla_Super.DataSource = logica.getListaSuper();
        }

        private void grilla_Super_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            decimal CostoCompra = 0;
            foreach (DataGridViewRow columna in grilla_Super.Rows)
            {
                LogicaIngrediente logica = new LogicaIngrediente();
                
                if (Convert.ToBoolean(columna.Cells[5].Value) == true && columna.Cells[5].Value != null) 
                {
                    CostoCompra = (Convert.ToDecimal(columna.Cells[2].Value.ToString()) - Convert.ToDecimal(columna.Cells[1].Value.ToString())) * Convert.ToDecimal(columna.Cells[3].Value.ToString()) + CostoCompra;
                }
            }
            visor_Total.Text = CostoCompra.ToString();
            
        }
    }
}
