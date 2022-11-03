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
        private void ActualizarGrilla()
        {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_bebidas.DataSource = null;
            grilla_bebidas.DataSource = logicaIngrediente.LeerBebidas();
        }
        private void btn_volver_Bebidas_Click(object sender, EventArgs e)
        {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }

        private void Boton_acpetar_bebidas_Click(object sender, EventArgs e)
        {
            LogicaIngrediente logica = new LogicaIngrediente();           
            if ((Lector_Cantidad.Text != null && Lector_Cantidad.Text != string.Empty) && (Lector_Nombre.Text != null && Lector_Nombre.Text != string.Empty) && (alcoholica.Checked || noalcoholica.Checked || altaenazucares.Checked) && (text_cantminima.Text != null && text_cantminima.Text !=string.Empty) && (text_precioUnitario.Text != null && text_precioUnitario.Text != string.Empty))
            {
                decimal cantidad = decimal.Parse(Lector_Cantidad.Text);
                decimal cantidadminima = decimal.Parse(text_cantminima.Text);
                decimal PrecioUnitario = decimal.Parse(text_precioUnitario.Text);
                if (logica.RevisarExistencia(Lector_Nombre.Text))
                {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
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
                    int Codigo = logica.StockIngredientes.Count()+1;
                    Bebida bebida = new Bebida(Codigo, Lector_Nombre.Text, 1, 100, cantidad, tipo_Bebida);
                    logica.agregarIngredientes(bebida);
                    Lector_Cantidad.Text = String.Empty;
                    Lector_Nombre.Text = String.Empty;
                    
                }
                grilla_bebidas.AutoGenerateColumns = false;
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }
        private void Form_Bebidas_Load(object sender, EventArgs e)
        {
            grilla_bebidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void grilla_bebidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_bebidas, "Eliminar");
            if (indiceEliminar == e.ColumnIndex)
            {
                
                    LogicaIngrediente logica = new LogicaIngrediente();
                    var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grilla_bebidas, "Codigo");
                    string codigoProducto = grilla_bebidas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                    logica.eliminarIngrediente(codigoProducto);
                    ActualizarGrilla();
                
            }

        }
    }
}
