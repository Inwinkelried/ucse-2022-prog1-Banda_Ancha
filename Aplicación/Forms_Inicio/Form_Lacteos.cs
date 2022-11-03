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
    public partial class Form_Lacteos : Form
    {
        public Form_Lacteos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }
        private void ActualizarGrilla()
        {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_Lacteos.DataSource = null;
            grilla_Lacteos.DataSource = logicaIngrediente.LeerLacteos();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            LogicaIngrediente logica = new LogicaIngrediente();
            if ((txt_CantMin.Text != null && txt_CantMin.Text != string.Empty) && (txt_Cantidad.Text != null && txt_Cantidad.Text != string.Empty) && (txt_PrecioxLT.Text != null && (txt_PrecioxLT.Text != string.Empty) && (txt_Nombre.Text != null && txt_Nombre.Text != string.Empty)))
            {
                decimal cantidad = decimal.Parse(txt_Cantidad.Text);
                decimal cantidadminima = decimal.Parse(txt_CantMin.Text);
                decimal PrecioXLt = decimal.Parse(txt_PrecioxLT.Text);
                if (logica.RevisarExistencia(txt_Nombre.Text))
                {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
                }
                else
                {
                    int Codigo = logica.StockIngredientes.Count() + 1;
                    Lacteo lacteos = new Lacteo(Codigo, txt_Nombre.Text, cantidadminima, PrecioXLt, cantidad);
                    logica.agregarIngredientes(lacteos);
                }
                grilla_Lacteos.AutoGenerateColumns = false;
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }
    }
}
