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
    public partial class Form_Pescado : Form {
        public Form_Pescado() {
            InitializeComponent();
        }

        private void btn_volver_Pescado_Click(object sender, EventArgs e) {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }

        private void ActualizarGrilla() {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_Pescado.DataSource = null;
            grilla_Pescado.DataSource = logicaIngrediente.LeerPescado();
        }

        private void button1_Click(object sender, EventArgs e) {
            LogicaIngrediente logica = new LogicaIngrediente();
            if ((txt_CantMin.Text != null && txt_CantMin.Text != string.Empty) && (txt_Cantidad.Text != null && txt_Cantidad.Text != string.Empty) && (txt_PrecioxKG.Text != null && (txt_PrecioxKG.Text != string.Empty) && (txt_Nombre.Text != null && txt_Nombre.Text != string.Empty))) {
                decimal cantidad = decimal.Parse(txt_Cantidad.Text);
                decimal cantidadminima = decimal.Parse(txt_CantMin.Text);
                decimal PrecioXKg = decimal.Parse(txt_PrecioxKG.Text);
                if (logica.RevisarExistencia(txt_Nombre.Text)) {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
                } else {
                    int Codigo = logica.StockIngredientes.Count() + 1;
                    Pescados pescados = new Pescados(Codigo, txt_Nombre.Text, cantidadminima, PrecioXKg, cantidad);
                    logica.agregarIngredientes(pescados);
                }
                grilla_Pescado.AutoGenerateColumns = false;
                ActualizarGrilla();
            } else {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void grilla_Pescado_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Pescado, "Eliminar");
            int indiceEditar = UtilidadesGrilla.getIndexColumna(grilla_Pescado, "Editar");
            LogicaIngrediente logicaIng = new LogicaIngrediente();

            if (indiceEditar == e.ColumnIndex) {

                foreach (DataGridViewRow columna in grilla_Pescado.Rows) {
                    var indice = UtilidadesGrilla.getIndexColumna(grilla_Pescado, "Codigo");
                    string Codigo = grilla_Pescado.Rows[e.RowIndex].Cells[indice].Value.ToString();
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
                var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grilla_Pescado, "Codigo");
                string codigoProducto = grilla_Pescado.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                logica.eliminarIngrediente(codigoProducto);
                ActualizarGrilla();
            }
        }

        private void Form_Pescado_Load(object sender, EventArgs e) {
            grilla_Pescado.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void button2_Click(object sender, EventArgs e) {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }
    }
}
