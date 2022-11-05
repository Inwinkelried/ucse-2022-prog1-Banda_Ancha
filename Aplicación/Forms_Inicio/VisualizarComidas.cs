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
    public partial class VisualizarComidas : Form
    {
        public VisualizarComidas()
        {
            InitializeComponent();
        }
        private void ActualizarGrilla()
        {
            LogicaComida logica = new LogicaComida();
            grilla_Comidas.DataSource = null;
            grilla_Comidas.DataSource = logica.LeerComidas();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisualizarComidas_Load(object sender, EventArgs e)
        {
            grilla_Comidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void btn_FiltroHarina_Click(object sender, EventArgs e)
        {
            LogicaComida logica = new LogicaComida();
            
            grilla_Comidas.DataSource = null;
            grilla_Comidas.DataSource = logica.FiltroSinHarina();
            ActualizarGrilla();
        }

        private void FiltroFecha_Click(object sender, EventArgs e)
        {
            LogicaComida logica = new LogicaComida();
            DateTime fechamenor = dtp_Fechamenor.Value.Date;
            DateTime fechamayor = dtp_Fechamayor.Value.Date;
            grilla_Comidas.DataSource = null;
            grilla_Comidas.DataSource = logica.FiltroFecha(fechamenor, fechamayor);
            ActualizarGrilla();
        }
    }
}