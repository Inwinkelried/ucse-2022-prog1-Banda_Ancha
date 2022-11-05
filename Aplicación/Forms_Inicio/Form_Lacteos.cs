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

        private void Form_Lacteos_Load(object sender, EventArgs e)
        {
            grilla_Lacteos.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void grilla_Lacteos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Lacteos, "Eliminar");
            int indiceEditar = UtilidadesGrilla.getIndexColumna(grilla_Lacteos, "Editar");
            LogicaIngrediente logicaIng = new LogicaIngrediente();

            if (indiceEditar == e.ColumnIndex)
            {

                foreach (DataGridViewRow columna in grilla_Lacteos.Rows)
                {
                    var indice = UtilidadesGrilla.getIndexColumna(grilla_Lacteos, "Codigo");
                    string Codigo = grilla_Lacteos.Rows[e.RowIndex].Cells[indice].Value.ToString();
                    string codigo = Convert.ToString(columna.Cells[2].Value);
                    if (Codigo == codigo)
                    {

                        string Nombre = Convert.ToString(columna.Cells[0].Value);
                        decimal Cantidad = Convert.ToDecimal(columna.Cells[1].Value);
                        logicaIng.ModificarIngrediente(Codigo, Cantidad, Nombre);
                        ActualizarGrilla();
                        break;

                    }
                }
            }
            if (indiceEliminar == e.ColumnIndex)
            {
                LogicaIngrediente logica = new LogicaIngrediente();
                var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grilla_Lacteos, "Codigo");
                string codigoProducto = grilla_Lacteos.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                logica.eliminarIngrediente(codigoProducto);
                ActualizarGrilla();
            }
        }
    }
    
}
