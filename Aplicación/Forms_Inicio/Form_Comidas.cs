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

namespace Forms_Inicio
{
    public partial class Form_Comidas : Form
    {
        public Form_Comidas()
        {
            InitializeComponent();
        }

        private void btn_Volver_Comidas_Click(object sender, EventArgs e) 
        {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }
        private void ActualizarGrilla()
        {
           LogicaReceta logica = new LogicaReceta();
           grilla_RecetasComidas.DataSource = null;
           grilla_RecetasComidas.DataSource = logica.LeerRecetas();
        }
        private void grilla_Comidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Comidas_Load(object sender, EventArgs e)
        {
            grilla_RecetasComidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void CrearComidabtn_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != null && txt_Nombre.Text!= String.Empty)
            {
                LogicaReceta logicaRec = new LogicaReceta();
                LogicaIngrediente logica = new LogicaIngrediente();
                foreach (Receta receta in logicaRec.LeerRecetas())
                {
                    if (receta.Nombre.ToLower() == txt_Nombre.Text.ToLower() && logica.CheckIngredientesReceta(receta))
                    {
                        LogicaComida  logicacom= new LogicaComida();
                        int codigo = logicacom.LeerComidas().Count();
                        DateTime fechahoy = DateTime.Today;
                        Comida comida = new Comida(codigo.ToString(), receta.IDRECETA.ToString(), receta, receta.Nombre, fechahoy);
                        MessageBox.Show("Carga Exitosa", "Error");
                    }
                    else
                    {
                        if (!logica.CheckIngredientesReceta(receta))
                        {
                            MessageBox.Show("Ingredientes insuficientes", "Error");
                        }
                        else
                        {
                            MessageBox.Show("Receta no encontrada", "Error");
                        }
                    }
                    

                    
                }
            }
            

        }

        private void grilla_RecetasComidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
