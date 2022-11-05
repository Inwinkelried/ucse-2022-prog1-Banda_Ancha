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
            this.btn_FiltroHarina = new System.Windows.Forms.Button();
            this.btn_FiltroTipo = new System.Windows.Forms.Button();
            this.btn_FiltroReceta = new System.Windows.Forms.Button();
            this.FiltroFecha = new System.Windows.Forms.Button();
            this.dtp_Fechamenor = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fechamayor = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.grilla_Comidas.Size = new System.Drawing.Size(440, 301);
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
            // btn_FiltroHarina
            // 
            this.btn_FiltroHarina.Location = new System.Drawing.Point(655, 357);
            this.btn_FiltroHarina.Name = "btn_FiltroHarina";
            this.btn_FiltroHarina.Size = new System.Drawing.Size(133, 38);
            this.btn_FiltroHarina.TabIndex = 1;
            this.btn_FiltroHarina.Text = "Filtro sin harina";
            this.btn_FiltroHarina.UseVisualStyleBackColor = true;
            this.btn_FiltroHarina.Click += new System.EventHandler(this.btn_FiltroHarina_Click);
            // 
            // btn_FiltroTipo
            // 
            this.btn_FiltroTipo.Location = new System.Drawing.Point(500, 357);
            this.btn_FiltroTipo.Name = "btn_FiltroTipo";
            this.btn_FiltroTipo.Size = new System.Drawing.Size(133, 38);
            this.btn_FiltroTipo.TabIndex = 2;
            this.btn_FiltroTipo.Text = "Filtrar por tipo";
            this.btn_FiltroTipo.UseVisualStyleBackColor = true;
            // 
            // btn_FiltroReceta
            // 
            this.btn_FiltroReceta.Location = new System.Drawing.Point(348, 357);
            this.btn_FiltroReceta.Name = "btn_FiltroReceta";
            this.btn_FiltroReceta.Size = new System.Drawing.Size(133, 38);
            this.btn_FiltroReceta.TabIndex = 3;
            this.btn_FiltroReceta.Text = "Filtro Receta";
            this.btn_FiltroReceta.UseVisualStyleBackColor = true;
            // 
            // FiltroFecha
            // 
            this.FiltroFecha.Location = new System.Drawing.Point(31, 275);
            this.FiltroFecha.Name = "FiltroFecha";
            this.FiltroFecha.Size = new System.Drawing.Size(133, 38);
            this.FiltroFecha.TabIndex = 4;
            this.FiltroFecha.Text = "Filtrar por fecha";
            this.FiltroFecha.UseVisualStyleBackColor = true;
            this.FiltroFecha.Click += new System.EventHandler(this.FiltroFecha_Click);
            // 
            // dtp_Fechamenor
            // 
            this.dtp_Fechamenor.Location = new System.Drawing.Point(31, 344);
            this.dtp_Fechamenor.Name = "dtp_Fechamenor";
            this.dtp_Fechamenor.Size = new System.Drawing.Size(133, 20);
            this.dtp_Fechamenor.TabIndex = 5;
            // 
            // dtp_Fechamayor
            // 
            this.dtp_Fechamayor.Location = new System.Drawing.Point(31, 402);
            this.dtp_Fechamayor.Name = "dtp_Fechamayor";
            this.dtp_Fechamayor.Size = new System.Drawing.Size(133, 20);
            this.dtp_Fechamayor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha menor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha mayor";
            // 
            // VisualizarComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Fechamayor);
            this.Controls.Add(this.dtp_Fechamenor);
            this.Controls.Add(this.FiltroFecha);
            this.Controls.Add(this.btn_FiltroReceta);
            this.Controls.Add(this.btn_FiltroTipo);
            this.Controls.Add(this.btn_FiltroHarina);
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
        private System.Windows.Forms.Button btn_FiltroHarina;
        private System.Windows.Forms.Button btn_FiltroTipo;
        private System.Windows.Forms.Button btn_FiltroReceta;
        private System.Windows.Forms.Button FiltroFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrereceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoReceta;
        private System.Windows.Forms.DateTimePicker dtp_Fechamenor;
        private System.Windows.Forms.DateTimePicker dtp_Fechamayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}