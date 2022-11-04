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
    public partial class Form_Recetas : Form
    {
        string CodigoReceta = "";
        public Form_Recetas()
        {
            InitializeComponent();

        }
        public Form_Recetas(string codreceta)
        {
            InitializeComponent();
            CodigoReceta = codreceta;
        }

        private void ActualizarGrilla()
        {
            LogicaIngrediente logicaIngrediente = new LogicaIngrediente();
            grillla_IngredientesRecetas.DataSource = null;
            grillla_IngredientesRecetas.DataSource = logicaIngrediente.LeerIngredientes();
        }
        private void btn_Volver_Recetas_Click(object sender, EventArgs e) {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }

        private void btn_Volver_Recetas_Click_1(object sender, EventArgs e) {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Hide();
        }

        private void btn_NuevaReceta_Click(object sender, EventArgs e) {
            
            
                bool band = true;
                ArchivosRecetas receta = new ArchivosRecetas();
                LogicaReceta logica = new LogicaReceta();
                if (Txt_nombre.Text != null && Txt_nombre.Text != string.Empty && (desayuno.Checked || almuerzo.Checked || merienda.Checked || cena.Checked))
                {

                    foreach (Receta receta1 in logica.Recetas)
                    {
                        if (receta1.Nombre.ToLower() == Txt_nombre.Text.ToLower())
                        {
                            band = false;
                            break;
                        }
                    }
                    if (band == true)
                    {
                        int CodeReceta = logica.Recetas.Count;
                        Tipo_Receta tipo_receta = new Tipo_Receta();
                        if (desayuno.Checked)
                        {
                            tipo_receta = Tipo_Receta.Desayuno;
                        }
                        else if (almuerzo.Checked)
                        {
                            tipo_receta = Tipo_Receta.Almuerzo;
                        }
                        else if (merienda.Checked)
                        {
                            tipo_receta = Tipo_Receta.Merienda;
                        }
                        else if (cena.Checked)
                        {
                            tipo_receta = Tipo_Receta.Cena;
                        }
                        bool saludable = false;
                        if (chkBox_EsSaludable.Checked)
                        {
                            saludable = true;
                        }
                        receta.TipoDeReceta = tipo_receta;
                        receta.Saludable = saludable;
                        receta.Ingredientes = new List<Ingrediente>();
                        receta.CodigosIngredientes = new List<string>();

                        foreach (DataGridViewRow row in grillla_IngredientesRecetas.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                            {
                                if (int.Parse(row.Cells[1].Value.ToString()) > 0)
                                {

                                    LogicaIngrediente logicaing = new LogicaIngrediente();
                                    Ingrediente ingrediente = logicaing.ObtenerProducto(row.Cells[2].Value.ToString());
                                    receta.Nombre = Txt_nombre.Text;
                                    receta.IDRECETA = logica.LeerRecetas().Count();
                                    receta.Ingredientes.Add(ingrediente);
                                    receta.CantidadesIngredientes.Add(Convert.ToInt32(row.Cells[1].Value));
                                    receta.CodigosIngredientes.Add(ingrediente.Codigo.ToString());
                                }
                            }
                        }
                        if (receta.CodigosIngredientes.Count > 0 && receta.Ingredientes.Count > 0 && receta.CodigosIngredientes.Count() == receta.Ingredientes.Count() && band == true)
                        {
                            logica.ActualizarRecetas(receta);
                        }
                    }
                MessageBox.Show("Carga correcta");
                Txt_nombre.Text = String.Empty;
                
                } 
                else
                    {
                MessageBox.Show("Error, debe llenar todos los campos");
                    }
        }
        private void Form_Recetas_Load(object sender, EventArgs e)
        {
            grillla_IngredientesRecetas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        
    }
}
