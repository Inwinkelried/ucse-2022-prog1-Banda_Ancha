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
            this.AgregarProdcuto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_NuevaReceta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cena = new System.Windows.Forms.RadioButton();
            this.merienda = new System.Windows.Forms.RadioButton();
            this.desayuno = new System.Windows.Forms.RadioButton();
            this.almuerzo = new System.Windows.Forms.RadioButton();
            this.chkBox_EsSaludable = new System.Windows.Forms.CheckBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_momentoDelDia = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btnver_Recetas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillla_IngredientesRecetas)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.AgregarProdcuto,
            this.Cantidad,
            this.Codigo,
            this.Nombre});
            this.grillla_IngredientesRecetas.Location = new System.Drawing.Point(297, 11);
            this.grillla_IngredientesRecetas.Margin = new System.Windows.Forms.Padding(2);
            this.grillla_IngredientesRecetas.Name = "grillla_IngredientesRecetas";
            this.grillla_IngredientesRecetas.RowHeadersWidth = 51;
            this.grillla_IngredientesRecetas.RowTemplate.Height = 24;
            this.grillla_IngredientesRecetas.Size = new System.Drawing.Size(451, 346);
            this.grillla_IngredientesRecetas.TabIndex = 8;
            // 
            // AgregarProdcuto
            // 
            this.AgregarProdcuto.HeaderText = "Agregar Producto";
            this.AgregarProdcuto.Name = "AgregarProdcuto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cena);
            this.groupBox1.Controls.Add(this.merienda);
            this.groupBox1.Controls.Add(this.desayuno);
            this.groupBox1.Controls.Add(this.almuerzo);
            this.groupBox1.Location = new System.Drawing.Point(126, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Location = new System.Drawing.Point(7, 88);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(50, 17);
            this.cena.TabIndex = 3;
            this.cena.TabStop = true;
            this.cena.Text = "Cena";
            this.cena.UseVisualStyleBackColor = true;
            // 
            // merienda
            // 
            this.merienda.AutoSize = true;
            this.merienda.Location = new System.Drawing.Point(6, 65);
            this.merienda.Name = "merienda";
            this.merienda.Size = new System.Drawing.Size(69, 17);
            this.merienda.TabIndex = 2;
            this.merienda.TabStop = true;
            this.merienda.Text = "Merienda";
            this.merienda.UseVisualStyleBackColor = true;
            // 
            // desayuno
            // 
            this.desayuno.AutoSize = true;
            this.desayuno.Location = new System.Drawing.Point(7, 42);
            this.desayuno.Name = "desayuno";
            this.desayuno.Size = new System.Drawing.Size(73, 17);
            this.desayuno.TabIndex = 1;
            this.desayuno.TabStop = true;
            this.desayuno.Text = "Desayuno";
            this.desayuno.UseVisualStyleBackColor = true;
            // 
            // almuerzo
            // 
            this.almuerzo.AutoSize = true;
            this.almuerzo.Location = new System.Drawing.Point(7, 20);
            this.almuerzo.Name = "almuerzo";
            this.almuerzo.Size = new System.Drawing.Size(68, 17);
            this.almuerzo.TabIndex = 0;
            this.almuerzo.TabStop = true;
            this.almuerzo.Text = "Almuerzo";
            this.almuerzo.UseVisualStyleBackColor = true;
            // 
            // chkBox_EsSaludable
            // 
            this.chkBox_EsSaludable.AutoSize = true;
            this.chkBox_EsSaludable.Location = new System.Drawing.Point(38, 270);
            this.chkBox_EsSaludable.Margin = new System.Windows.Forms.Padding(2);
            this.chkBox_EsSaludable.Name = "chkBox_EsSaludable";
            this.chkBox_EsSaludable.Size = new System.Drawing.Size(98, 17);
            this.chkBox_EsSaludable.TabIndex = 15;
            this.chkBox_EsSaludable.Text = "¿Es saludable?";
            this.chkBox_EsSaludable.UseVisualStyleBackColor = true;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(126, 109);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(107, 20);
            this.Txt_nombre.TabIndex = 14;
            // 
            // lbl_momentoDelDia
            // 
            this.lbl_momentoDelDia.AutoSize = true;
            this.lbl_momentoDelDia.Location = new System.Drawing.Point(30, 152);
            this.lbl_momentoDelDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_momentoDelDia.Name = "lbl_momentoDelDia";
            this.lbl_momentoDelDia.Size = new System.Drawing.Size(87, 13);
            this.lbl_momentoDelDia.TabIndex = 13;
            this.lbl_momentoDelDia.Text = "Momento del día";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(30, 112);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 12;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // btnver_Recetas
            // 
            this.btnver_Recetas.AutoSize = true;
            this.btnver_Recetas.Location = new System.Drawing.Point(646, 383);
            this.btnver_Recetas.Margin = new System.Windows.Forms.Padding(2);
            this.btnver_Recetas.Name = "btnver_Recetas";
            this.btnver_Recetas.Size = new System.Drawing.Size(102, 41);
            this.btnver_Recetas.TabIndex = 17;
            this.btnver_Recetas.Text = "Mis recetas";
            this.btnver_Recetas.UseVisualStyleBackColor = true;
            this.btnver_Recetas.Click += new System.EventHandler(this.btnver_Recetas_Click);
            // 
            // Form_Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnver_Recetas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkBox_EsSaludable);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.lbl_momentoDelDia);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_NuevaReceta);
            this.Controls.Add(this.grillla_IngredientesRecetas);
            this.Controls.Add(this.btn_Volver_Recetas);
            this.Name = "Form_Recetas";
            this.Text = "Form_Recetas";
            this.Load += new System.EventHandler(this.Form_Recetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillla_IngredientesRecetas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Recetas;
        private System.Windows.Forms.DataGridView grillla_IngredientesRecetas;
        private System.Windows.Forms.Button btn_NuevaReceta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cena;
        private System.Windows.Forms.RadioButton merienda;
        private System.Windows.Forms.RadioButton desayuno;
        private System.Windows.Forms.RadioButton almuerzo;
        private System.Windows.Forms.CheckBox chkBox_EsSaludable;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label lbl_momentoDelDia;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AgregarProdcuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnver_Recetas;
    }
}