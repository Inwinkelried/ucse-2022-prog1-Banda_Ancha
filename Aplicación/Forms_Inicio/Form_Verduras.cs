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
    public partial class Form_Verduras : Form
    {
        public Form_Verduras()
        {
            InitializeComponent();
        }
        private void ActualizarGrilla()
        {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_Verduras.DataSource = null;
            grilla_Verduras.DataSource = logicaIngrediente.LeerVerduras();
        }

        private void btn_Volver_Verduras_Click(object sender, EventArgs e)
        {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Verduras, "Eliminar");
            if (indiceEliminar == e.ColumnIndex)
            {
                LogicaIngrediente logica = new LogicaIngrediente();
                var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grilla_Verduras, "Codigo");
                string codigoProducto = grilla_Verduras.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                logica.eliminarIngrediente(codigoProducto);
                ActualizarGrilla();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            LogicaIngrediente logica = new LogicaIngrediente();
            if ((txtbx_cantminima_verdura.Text != null && txtbx_cantminima_verdura.Text != string.Empty) && (txtbx_Precio_unitario_verdura.Text != null && txtbx_Precio_unitario_verdura.Text != string.Empty) && (txtbx_Cantidad_verdura != null && (txtbx_Cantidad_verdura.Text != string.Empty) && (textbx_Nombre_verdura.Text != null && textbx_Nombre_verdura.Text != string.Empty)))
            {
                decimal cantidad = decimal.Parse(txtbx_Cantidad_verdura.Text);
                int cantidadminima = int.Parse(txtbx_cantminima_verdura.Text);
                decimal PrecioUnitario = decimal.Parse(txtbx_Precio_unitario_verdura.Text);
                if (logica.RevisarExistencia(textbx_Nombre_verdura.Text))
                {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
                }
                else
                {
                    int Codigo = logica.StockIngredientes.Count() + 1;
                    HortalizaYVerdura verdura = new HortalizaYVerdura(Codigo, textbx_Nombre_verdura.Text, cantidadminima, PrecioUnitario, cantidad);
                    logica.agregarIngredientes(verdura);
                }
                grilla_Verduras.AutoGenerateColumns = false;
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void Form_Verduras_Load(object sender, EventArgs e)
        {
            grilla_Verduras.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
    }
}
