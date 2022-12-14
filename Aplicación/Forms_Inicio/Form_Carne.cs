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

namespace Forms_Inicio {
    public partial class Form_Carne : Form {
        public Form_Carne() {
            InitializeComponent();
        }

        private void btn_volver_Carnes_Click(object sender, EventArgs e) {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }
        private void ActualizarGrilla() {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_Carnes.DataSource = null;
            grilla_Carnes.DataSource = logicaIngrediente.LeerCarnes();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e) {


        }

        private void Form_Carne_Load(object sender, EventArgs e) {
            grilla_Carnes.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void grilla_Carnes_CellClick(object sender, DataGridViewCellEventArgs e) {


        }

        private void button1_Click(object sender, EventArgs e) {
            LogicaIngrediente logica = new LogicaIngrediente();
            if ((txt_Cantidad_minima_Carne.Text != null && txt_Cantidad_minima_Carne.Text != string.Empty) && (txt_PrecioxKg.Text != null && txt_PrecioxKg.Text != string.Empty) && (txt_Cantidad.Text != null && (txt_Cantidad.Text != string.Empty) && (txt_Nombre.Text != null && txt_Nombre.Text != string.Empty))) {
                decimal cantidad = decimal.Parse(txt_Cantidad.Text);
                decimal cantidadminima = decimal.Parse(txt_Cantidad_minima_Carne.Text);
                decimal PrecioXKg = decimal.Parse(txt_PrecioxKg.Text);
                if (logica.RevisarExistencia(txt_Nombre.Text)) {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
                } else {
                    int Codigo = logica.StockIngredientes.Count() + 1;
                    Carnes carne = new Carnes(Codigo, txt_Nombre.Text, cantidadminima, PrecioXKg, cantidad);
                    logica.agregarIngredientes(carne);


                }
                grilla_Carnes.AutoGenerateColumns = false;
                ActualizarGrilla();
            } else {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void grilla_Carnes_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Carnes, "Eliminar");
            int indiceEditar = UtilidadesGrilla.getIndexColumna(grilla_Carnes, "Editar");
            LogicaIngrediente logicaIng = new LogicaIngrediente();

            if (indiceEditar == e.ColumnIndex) {

                foreach (DataGridViewRow columna in grilla_Carnes.Rows) {
                    var indice = UtilidadesGrilla.getIndexColumna(grilla_Carnes, "Codigo");
                    string Codigo = grilla_Carnes.Rows[e.RowIndex].Cells[indice].Value.ToString();
                    string codigo = Convert.ToString(columna.Cells[2].Value);
                    if (Codigo == codigo) {

                        string Nombre = Convert.ToString(columna.Cells[0].Value);
                        decimal Cantidad = Convert.ToDecimal(columna.Cells[1].Value);
                        logicaIng.ModificarIngrediente(Codigo, Cantidad, Nombre);
                        ActualizarGrilla();
                        break;

                    }
                }
            }

            if (indiceEliminar == e.ColumnIndex) {
                LogicaIngrediente logica = new LogicaIngrediente();
                var indice = UtilidadesGrilla.getIndexColumna(grilla_Carnes, "Codigo");
                string codigoProducto = grilla_Carnes.Rows[e.RowIndex].Cells[indice].Value.ToString();
                logica.eliminarIngrediente(codigoProducto);
                ActualizarGrilla();
            }
        }
    }
}
