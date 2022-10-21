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
            int cantidad = int.Parse(Lector_Cantidad.Text);
            if (Lector_Nombre.Text != "") //&& condicion de que la casilla de tipo este marcada)
            {
                //Revisar si la bebida no esta cargada, si no lo esta salta un messagebox que preguntara si esta seguro que desea cargar la bebida
                // Si la bebida esta solo se suma la cantidad.
                //Se deben cargar los datos a la grilla y a el txt que contendra la informacion.
            }

        }
    }
}
