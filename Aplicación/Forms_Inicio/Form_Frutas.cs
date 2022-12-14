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
    public partial class Form_Frutas : Form {
        public Form_Frutas() {
            InitializeComponent();
        }

        private void btn_volver_frutas_Click(object sender, EventArgs e) {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }
        private void ActualizarGrilla() {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grillafrutas.DataSource = null;
            grillafrutas.DataSource = logicaIngrediente.LeerFrutas();
        }
        private void label1_Click(object sender, EventArgs e) {

        }
        private void btn_aceptar_Click(object sender, EventArgs e) {
            LogicaIngrediente logica = new LogicaIngrediente();
            if ((txtbx_cantminima_fruta.Text != null && txtbx_cantminima_fruta.Text != string.Empty) && (txtbx_Precio_unitario_fruta.Text != null && txtbx_Precio_unitario_fruta.Text != string.Empty) && (txtbx_Cantidad_fruta.Text != null && (txtbx_Cantidad_fruta.Text != string.Empty) && (textbx_Nombre_fruta.Text != null && textbx_Nombre_fruta.Text != string.Empty))) {
                decimal cantidad = decimal.Parse(txtbx_Cantidad_fruta.Text);
                int cantidadminima = int.Parse(txtbx_cantminima_fruta.Text);
                decimal PrecioUnitario = decimal.Parse(txtbx_Precio_unitario_fruta.Text);
                if (logica.RevisarExistencia(textbx_Nombre_fruta.Text)) {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
                } else {
                    int Codigo = logica.StockIngredientes.Count() + 1;
                    Fruta fruta = new Fruta(Codigo, textbx_Nombre_fruta.Text, cantidadminima, PrecioUnitario, cantidad);
                    logica.agregarIngredientes(fruta);
                }
                grillafrutas.AutoGenerateColumns = false;
                ActualizarGrilla();
            } else {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }

        }

        private void Form_Frutas_Load(object sender, EventArgs e) {
            grillafrutas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void grillafrutas_CellClick(object sender, DataGridViewCellEventArgs e) {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grillafrutas, "Eliminar");
            int indiceEditar = UtilidadesGrilla.getIndexColumna(grillafrutas, "Editar");
            LogicaIngrediente logicaIng = new LogicaIngrediente();

            if (indiceEditar == e.ColumnIndex) {

                foreach (DataGridViewRow columna in grillafrutas.Rows) {
                    var indice = UtilidadesGrilla.getIndexColumna(grillafrutas, "Codigo");
                    string Codigo = grillafrutas.Rows[e.RowIndex].Cells[indice].Value.ToString();
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
                var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grillafrutas, "Codigo");
                string codigoProducto = grillafrutas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                logica.eliminarIngrediente(codigoProducto);
                ActualizarGrilla();
            }

        }
    }
}
