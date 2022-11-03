namespace Forms_Inicio
{
    partial class Form_Recetas
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
            this.btn_Volver_Recetas = new System.Windows.Forms.Button();
            this.grillla_IngredientesRecetas = new System.Windows.Forms.DataGridView();
            this.btn_NuevaReceta = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarIng = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillla_IngredientesRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver_Recetas
            // 
            this.btn_Volver_Recetas.Location = new System.Drawing.Point(10, 11);
            this.btn_Volver_Recetas.Name = "btn_Volver_Recetas";
            this.btn_Volver_Recetas.Size = new System.Drawing.Size(102, 42);
            this.btn_Volver_Recetas.TabIndex = 7;
            this.btn_Volver_Recetas.Text = "Volver";
            this.btn_Volver_Recetas.UseVisualStyleBackColor = true;
            this.btn_Volver_Recetas.Click += new System.EventHandler(this.btn_Volver_Recetas_Click_1);
            // 
            // grillla_IngredientesRecetas
            // 
            this.grillla_IngredientesRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillla_IngredientesRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Codigo,
            this.agregarIng});
            this.grillla_IngredientesRecetas.Location = new System.Drawing.Point(270, 11);
            this.grillla_IngredientesRecetas.Margin = new System.Windows.Forms.Padding(2);
            this.grillla_IngredientesRecetas.Name = "grillla_IngredientesRecetas";
            this.grillla_IngredientesRecetas.RowHeadersWidth = 51;
            this.grillla_IngredientesRecetas.RowTemplate.Height = 24;
            this.grillla_IngredientesRecetas.Size = new System.Drawing.Size(483, 346);
            this.grillla_IngredientesRecetas.TabIndex = 8;
            this.grillla_IngredientesRecetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillla_IngredientesRecetas_CellContentClick);
            // 
            // btn_NuevaReceta
            // 
            this.btn_NuevaReceta.AutoSize = true;
            this.btn_NuevaReceta.Location = new System.Drawing.Point(126, 11);
            this.btn_NuevaReceta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NuevaReceta.Name = "btn_NuevaReceta";
            this.btn_NuevaReceta.Size = new System.Drawing.Size(102, 41);
            this.btn_NuevaReceta.TabIndex = 9;
            this.btn_NuevaReceta.Text = "Nueva receta";
            this.btn_NuevaReceta.UseVisualStyleBackColor = true;
            this.btn_NuevaReceta.Click += new System.EventHandler(this.btn_NuevaReceta_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // agregarIng
            // 
            this.agregarIng.HeaderText = "Agregar Ingrediente";
            this.agregarIng.Name = "agregarIng";
            // 
            // Form_Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NuevaReceta);
            this.Controls.Add(this.grillla_IngredientesRecetas);
            this.Controls.Add(this.btn_Volver_Recetas);
            this.Name = "Form_Recetas";
            this.Text = "Form_Recetas";
            ((System.ComponentModel.ISupportInitialize)(this.grillla_IngredientesRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Recetas;
        private System.Windows.Forms.DataGridView grillla_IngredientesRecetas;
        private System.Windows.Forms.Button btn_NuevaReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn agregarIng;
    }
}