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
    public partial class Form_Quesos : Form
    {
        public Form_Quesos()
        {
            InitializeComponent();
        }

        private void Form_Quesos_Load(object sender, EventArgs e)
        {
            grilla_Quesos.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_Quesos.DataSource = null;
            grilla_Quesos.DataSource = logicaIngrediente.LeerQuesos();
        }
        private void grilla_Quesos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Quesos, "Eliminar");
            int indiceEditar = UtilidadesGrilla.getIndexColumna(grilla_Quesos, "Editar");
            LogicaIngrediente logicaIng = new LogicaIngrediente();
            if (indiceEditar == e.ColumnIndex)
            {
                foreach (DataGridViewRow columna in grilla_Quesos.Rows)
                {
                    string Codigo = Convert.ToString(columna.Cells[2].Value);
                    string Nombre = Convert.ToString(columna.Cells[0].Value);
                    decimal Cantidad = Convert.ToDecimal(columna.Cells[1].Value);
                    logicaIng.ModificarIngrediente(Codigo, Cantidad, Nombre);
                    ActualizarGrilla();
                    break;
                }
            }
            if (indiceEliminar == e.ColumnIndex)
            {
                LogicaIngrediente logica = new LogicaIngrediente();
                var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grilla_Quesos, "Codigo");
                string codigoProducto = grilla_Quesos.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                logica.eliminarIngrediente(codigoProducto);
                ActualizarGrilla();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            LogicaIngrediente logica = new LogicaIngrediente();
            if ((txt_CantMin.Text != null && txt_CantMin.Text != string.Empty) && (txt_Cantidad.Text != null && txt_Cantidad.Text != string.Empty) && (txt_PrecioxKG.Text != null && (txt_PrecioxKG.Text != string.Empty) && (txt_Nombre.Text != null && txt_Nombre.Text != string.Empty)))
            {
                decimal cantidad = decimal.Parse(txt_Cantidad.Text);
                decimal cantidadminima = decimal.Parse(txt_CantMin.Text);
                decimal PrecioXKg = decimal.Parse(txt_PrecioxKG.Text);
                if (logica.RevisarExistencia(txt_Nombre.Text))
                {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
                }
                else
                {
                    int Codigo = logica.StockIngredientes.Count() + 1;
                    Queso queso = new Queso(Codigo, txt_Nombre.Text, cantidadminima, PrecioXKg, cantidad);
                    logica.agregarIngredientes(queso);
                }
                grilla_Quesos.AutoGenerateColumns = false;
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }
    }
}
