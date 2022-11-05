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
    public partial class Form_Panaderia : Form {
        public Form_Panaderia() {
            InitializeComponent();
        }

        private void btn_volver_Panaderia_Click(object sender, EventArgs e) {
            Form_Despensa despensa = new Form_Despensa();
            despensa.Show();
            this.Hide();
        }

        private void btn_Cargar_Panaderia_Click(object sender, EventArgs e) {
            LogicaIngrediente logica = new LogicaIngrediente();
            if ((txt_CantMinima.Text != null && txt_CantMinima.Text != string.Empty) && (txt_Cantidad.Text != null && txt_Cantidad.Text != string.Empty) && (txt_PrecioxKG.Text != null && (txt_PrecioxKG.Text != string.Empty) && (txt_Nombre.Text != null && txt_Nombre.Text != string.Empty))) {
                decimal cantidad = decimal.Parse(txt_Cantidad.Text);
                decimal cantidadminima = decimal.Parse(txt_CantMinima.Text);
                decimal PrecioXKg = decimal.Parse(txt_PrecioxKG.Text);
                if (logica.RevisarExistencia(txt_Nombre.Text)) {
                    MessageBox.Show("Este ingrediente ya existe", "Error");
                } else {
                    int Codigo = logica.StockIngredientes.Count() + 1;
                    Panaderia bebida = new Panaderia(Codigo, txt_Nombre.Text, cantidadminima, PrecioXKg, cantidad);
                    logica.agregarIngredientes(bebida);
                }
                grilla_Panaderia.AutoGenerateColumns = false;
                ActualizarGrilla();
            } else {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }
        private void ActualizarGrilla() {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_Panaderia.DataSource = null;
            grilla_Panaderia.DataSource = logicaIngrediente.LeerPanaderia();
        }

        private void grilla_Panaderia_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int indiceEliminar = UtilidadesGrilla.getIndexColumna(grilla_Panaderia, "Eliminar");
            int indiceEditar = UtilidadesGrilla.getIndexColumna(grilla_Panaderia, "Editar");
            LogicaIngrediente logicaIng = new LogicaIngrediente();

            if (indiceEditar == e.ColumnIndex) {

                foreach (DataGridViewRow columna in grilla_Panaderia.Rows) {
                    var indice = UtilidadesGrilla.getIndexColumna(grilla_Panaderia, "Codigo");
                    string Codigo = grilla_Panaderia.Rows[e.RowIndex].Cells[indice].Value.ToString();
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
                var indiceIdentificador = UtilidadesGrilla.getIndexColumna(grilla_Panaderia, "Codigo");
                string codigoProducto = grilla_Panaderia.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                logica.eliminarIngrediente(codigoProducto);
                ActualizarGrilla();
            }
        }

        private void Form_Panaderia_Load(object sender, EventArgs e) {
            grilla_Panaderia.AutoGenerateColumns = false;
            ActualizarGrilla();
        }
    }
}
