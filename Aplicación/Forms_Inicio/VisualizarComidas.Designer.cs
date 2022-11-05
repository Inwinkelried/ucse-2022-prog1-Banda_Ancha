namespace Forms_Inicio
{
    partial class VisualizarComidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grilla_Comidas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrereceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltroFecha = new System.Windows.Forms.Button();
            this.dtp_Fechamenor = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fechamayor = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Volver_VisualizarComidas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Comidas)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_Comidas
            // 
            this.grilla_Comidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_Comidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Nombrereceta,
            this.CodigoComida,
            this.CodigoReceta});
            this.grilla_Comidas.Location = new System.Drawing.Point(348, 12);
            this.grilla_Comidas.Name = "grilla_Comidas";
            this.grilla_Comidas.Size = new System.Drawing.Size(440, 367);
            this.grilla_Comidas.TabIndex = 0;
            this.grilla_Comidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaCreacion";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Nombrereceta
            // 
            this.Nombrereceta.DataPropertyName = "NombreRec";
            this.Nombrereceta.HeaderText = "Nombre receta";
            this.Nombrereceta.Name = "Nombrereceta";
            // 
            // CodigoComida
            // 
            this.CodigoComida.DataPropertyName = "Codigo";
            this.CodigoComida.HeaderText = "Codigo comida";
            this.CodigoComida.Name = "CodigoComida";
            // 
            // CodigoReceta
            // 
            this.CodigoReceta.DataPropertyName = "CodigoReceta";
            this.CodigoReceta.HeaderText = "Codigo Receta";
            this.CodigoReceta.Name = "CodigoReceta";
            // 
            // FiltroFecha
            // 
            this.FiltroFecha.Location = new System.Drawing.Point(54, 155);
            this.FiltroFecha.Name = "FiltroFecha";
            this.FiltroFecha.Size = new System.Drawing.Size(133, 38);
            this.FiltroFecha.TabIndex = 4;
            this.FiltroFecha.Text = "Filtrar por fecha";
            this.FiltroFecha.UseVisualStyleBackColor = true;
            this.FiltroFecha.Click += new System.EventHandler(this.FiltroFecha_Click);
            // 
            // dtp_Fechamenor
            // 
            this.dtp_Fechamenor.Location = new System.Drawing.Point(54, 224);
            this.dtp_Fechamenor.Name = "dtp_Fechamenor";
            this.dtp_Fechamenor.Size = new System.Drawing.Size(133, 20);
            this.dtp_Fechamenor.TabIndex = 5;
            // 
            // dtp_Fechamayor
            // 
            this.dtp_Fechamayor.Location = new System.Drawing.Point(54, 282);
            this.dtp_Fechamayor.Name = "dtp_Fechamayor";
            this.dtp_Fechamayor.Size = new System.Drawing.Size(133, 20);
            this.dtp_Fechamayor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha menor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha mayor";
            // 
            // btn_Volver_VisualizarComidas
            // 
            this.btn_Volver_VisualizarComidas.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_VisualizarComidas.Name = "btn_Volver_VisualizarComidas";
            this.btn_Volver_VisualizarComidas.Size = new System.Drawing.Size(96, 44);
            this.btn_Volver_VisualizarComidas.TabIndex = 9;
            this.btn_Volver_VisualizarComidas.Text = "Volver";
            this.btn_Volver_VisualizarComidas.UseVisualStyleBackColor = true;
            this.btn_Volver_VisualizarComidas.Click += new System.EventHandler(this.btn_Volver_VisualizarComidas_Click);
            // 
            // VisualizarComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btn_Volver_VisualizarComidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Fechamayor);
            this.Controls.Add(this.dtp_Fechamenor);
            this.Controls.Add(this.FiltroFecha);
            this.Controls.Add(this.grilla_Comidas);
            this.Name = "VisualizarComidas";
            this.Text = "VisualizarComidas";
            this.Load += new System.EventHandler(this.VisualizarComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Comidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_Comidas;
        private System.Windows.Forms.Button FiltroFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrereceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoReceta;
        private System.Windows.Forms.DateTimePicker dtp_Fechamenor;
        private System.Windows.Forms.DateTimePicker dtp_Fechamayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Volver_VisualizarComidas;
    }
}