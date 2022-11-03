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
    public partial class NuevaReceta : Form {
        public NuevaReceta() {
            InitializeComponent();
           
        }

        public void VolverARecetas() {
            Form_Recetas recetas = new Form_Recetas();
            recetas.Show();
            this.Hide();
        }
        private void ActualizarGrilla()
        {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grilla_SelectIngredientes.DataSource = null;
            grilla_SelectIngredientes.DataSource = logicaIngrediente.LeerIngredientes();
        }

        private void btn_Volver_NuevaReceta_Click(object sender, EventArgs e) {
            VolverARecetas();
        }

        private void btn_confirmarReceta_Click(object sender, EventArgs e) {
            bool band = true;
            LogicaReceta logica = new LogicaReceta();
            if (Txt_nombre.Text !=null && Txt_nombre.Text !=string.Empty && (desayuno.Checked || almuerzo.Checked || merienda.Checked || cena.Checked))
            {
                
                foreach (Receta receta in logica.Recetas)
                {
                    if (receta.Nombre.ToLower() == Txt_nombre.Text.ToLower())
                    {
                        band = false;
                        break;
                    }
                }
                if (band == true)
                {
                    int CodeReceta = logica.Recetas.Count;
                    Tipo_Receta tipo_receta= new Tipo_Receta();                   
                    if (desayuno.Checked)
                    {
                        tipo_receta = Tipo_Receta.Desayuno;
                    }else if (almuerzo.Checked)
                    {
                        tipo_receta = Tipo_Receta.Almuerzo;
                    }else if (merienda.Checked)
                    {
                        tipo_receta = Tipo_Receta.Merienda;
                    }else if (cena.Checked)
                    {
                        tipo_receta = Tipo_Receta.Cena;
                    }
                    bool saludable = false;
                    if (chkBox_EsSaludable.Checked)
                    {
                        saludable = true;
                    }
                    Receta receta = new Receta(CodeReceta, tipo_receta, Txt_nombre.Text, saludable)


                }
                else throw new Exception("Ya hay una receta registrada con este nombre");
                grilla_SelectIngredientes.AutoGenerateColumns = false;
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) {
            MessageBox.Show("Su receta no se guardó");
            VolverARecetas();

        }

        private void grilla_SelectIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NuevaReceta_Load(object sender, EventArgs e)
        {
            grilla_SelectIngredientes.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void comboBox_momentoDelDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }   
}
