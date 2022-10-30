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
using Newtonsoft.Json;
using System.IO;

namespace Forms_Inicio
{
    public partial class Form_Bebidas : Form
    {
        public Form_Bebidas()
        {
            InitializeComponent();
        }

        private void btn_volver_Bebidas_Click(object sender, EventArgs e)
        {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void grilla_bebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Boton_acpetar_bebidas_Click(object sender, EventArgs e)
        {
            LogicaIngrediente logica = new LogicaIngrediente();
            decimal cantidad = decimal.Parse(Lector_Cantidad.Text);
            
            if ((Lector_Cantidad.Text != null && Lector_Cantidad.Text != string.Empty) && (Lector_Nombre.Text != null && Lector_Nombre.Text != string.Empty) && (alcoholica.Checked || noalcoholica.Checked || altaenazucares.Checked))
            {
                if (logica.RevisarExistencia(Lector_Nombre.Text))
                {
                    int index = logica.buscarIngrediente(Lector_Nombre.Text);
                    logica.StockIngredientes[index].Cantidad += cantidad;
                }
                else
                {
                    Tipo_Bebida tipo_Bebida = new Tipo_Bebida();
                    if (alcoholica.Checked)
                    {
                        tipo_Bebida = Tipo_Bebida.Alcoholica;
                    }
                    else if (altaenazucares.Checked)
                    {
                        tipo_Bebida = Tipo_Bebida.AltaEnAzcure;
                    }
                    else
                    {
                        tipo_Bebida = Tipo_Bebida.NoAlcoholica;
                    }
                    int Codigo = logica.StockIngredientes.Count();
                    Bebida bebida = new Bebida(Codigo, Lector_Nombre.Text, 1, 100, cantidad, tipo_Bebida);
                    logica.agregarIngredientes(bebida);                    
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }

        }

        private void Lector_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
