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

        private void ActualizarGrilla()
        {
            LogicaIngrediente logica = new LogicaIngrediente();
            grilla_Super.DataSource = null;
            grilla_Super.DataSource = logica.getListaSuper();
        }
        private void Form_Super_Load(object sender, EventArgs e)
        {
            grilla_Super.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void btn_GeneraCarrito_Click(object sender, EventArgs e)
        {
            grilla_Super.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void btn_Volver_Super_Click(object sender, EventArgs e)
        {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
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

        private void btn_filtrocarniceria_Click(object sender, EventArgs e)
        {
            LogicaSuper logSuper = new LogicaSuper();
            grilla_Super.DataSource = null;
            grilla_Super.DataSource = logSuper.FiltrarPorCarniceria();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal precio = decimal.Parse(txt_FiltroPrecio.Text);
            LogicaSuper logica = new LogicaSuper();
            grilla_Super.DataSource = null;
            grilla_Super.DataSource = logica.FiltrarPorPrecio(precio);
        }

        private void btn_FiltroVerduleria_Click(object sender, EventArgs e)
        {
            LogicaSuper logica = new LogicaSuper();
            grilla_Super.DataSource = null;
            grilla_Super.DataSource = logica.FiltrarPorVerduleria();
        }

        private void FiltroLacteos_Click(object sender, EventArgs e)
        {
            LogicaSuper logica = new LogicaSuper();
            grilla_Super.DataSource = null;
            grilla_Super.DataSource = logica.FiltrarPorLacteos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LogicaSuper logica = new LogicaSuper();
            if (radioButton_Bebidas.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Bebida");
            }
            else if (radioButton_Carnes.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Carne");
            }
            else if (radioButton_pescados.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Pescado");
            }
            else if (radioButton_Panaderia.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Panaderia");
            }
            else if (radioButton_Lacteos.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Lacteo");
            }
            else if (radioButton_Frutas.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Fruta");
            }
            else if (radioButton_Quesos.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Queso");
            }
            else if (radioButton_Verduras.Checked)
            {
                grilla_Super.DataSource = null;
                grilla_Super.DataSource = logica.FiltrarPorTipo("Verdura");
            }
        }
    }
}


