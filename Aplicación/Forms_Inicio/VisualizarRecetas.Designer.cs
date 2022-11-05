namespace Forms_Inicio
{
    partial class VisualizarRecetas
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
            this.grilla_Recetas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Volver_VisualizarRecetas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Recetas)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_Recetas
            // 
            this.grilla_Recetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_Recetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Codigo,
            this.Editar,
            this.Eliminar});
            this.grilla_Recetas.Location = new System.Drawing.Point(192, 12);
            this.grilla_Recetas.Name = "grilla_Recetas";
            this.grilla_Recetas.Size = new System.Drawing.Size(442, 390);
            this.grilla_Recetas.TabIndex = 0;
            this.grilla_Recetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_Recetas_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IDRECETA";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // btn_Volver_VisualizarRecetas
            // 
            this.btn_Volver_VisualizarRecetas.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_VisualizarRecetas.Name = "btn_Volver_VisualizarRecetas";
            this.btn_Volver_VisualizarRecetas.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver_VisualizarRecetas.TabIndex = 1;
            this.btn_Volver_VisualizarRecetas.Text = "Volver";
            this.btn_Volver_VisualizarRecetas.UseVisualStyleBackColor = true;
            // 
            // VisualizarRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Volver_VisualizarRecetas);
            this.Controls.Add(this.grilla_Recetas);
            this.Name = "VisualizarRecetas";
            this.Text = "VisualizarRecetas";
            this.Load += new System.EventHandler(this.VisualizarRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Recetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_Recetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button btn_Volver_VisualizarRecetas;
    }
}