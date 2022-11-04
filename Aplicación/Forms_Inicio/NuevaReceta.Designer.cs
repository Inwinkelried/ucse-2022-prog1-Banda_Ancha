namespace Forms_Inicio {
    partial class NuevaReceta {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_confirmarReceta = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Volver_NuevaReceta = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_momentoDelDia = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.chkBox_EsSaludable = new System.Windows.Forms.CheckBox();
            this.grilla_SelectIngredientes = new System.Windows.Forms.DataGridView();
            this.lbl_IngredientesNecesarios = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cena = new System.Windows.Forms.RadioButton();
            this.merienda = new System.Windows.Forms.RadioButton();
            this.desayuno = new System.Windows.Forms.RadioButton();
            this.almuerzo = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_SelectIngredientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_confirmarReceta
            // 
            this.btn_confirmarReceta.Location = new System.Drawing.Point(496, 323);
            this.btn_confirmarReceta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirmarReceta.Name = "btn_confirmarReceta";
            this.btn_confirmarReceta.Size = new System.Drawing.Size(95, 33);
            this.btn_confirmarReceta.TabIndex = 0;
            this.btn_confirmarReceta.Text = "Confirmar";
            this.btn_confirmarReceta.UseVisualStyleBackColor = true;
            this.btn_confirmarReceta.Click += new System.EventHandler(this.btn_confirmarReceta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(396, 323);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(95, 33);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Volver_NuevaReceta
            // 
            this.btn_Volver_NuevaReceta.Location = new System.Drawing.Point(9, 10);
            this.btn_Volver_NuevaReceta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Volver_NuevaReceta.Name = "btn_Volver_NuevaReceta";
            this.btn_Volver_NuevaReceta.Size = new System.Drawing.Size(79, 24);
            this.btn_Volver_NuevaReceta.TabIndex = 2;
            this.btn_Volver_NuevaReceta.Text = "Volver";
            this.btn_Volver_NuevaReceta.UseVisualStyleBackColor = true;
            this.btn_Volver_NuevaReceta.Click += new System.EventHandler(this.btn_Volver_NuevaReceta_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 100);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_momentoDelDia
            // 
            this.lbl_momentoDelDia.AutoSize = true;
            this.lbl_momentoDelDia.Location = new System.Drawing.Point(6, 140);
            this.lbl_momentoDelDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_momentoDelDia.Name = "lbl_momentoDelDia";
            this.lbl_momentoDelDia.Size = new System.Drawing.Size(87, 13);
            this.lbl_momentoDelDia.TabIndex = 4;
            this.lbl_momentoDelDia.Text = "Momento del día";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(102, 97);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(107, 20);
            this.Txt_nombre.TabIndex = 5;
            // 
            // chkBox_EsSaludable
            // 
            this.chkBox_EsSaludable.AutoSize = true;
            this.chkBox_EsSaludable.Location = new System.Drawing.Point(14, 258);
            this.chkBox_EsSaludable.Margin = new System.Windows.Forms.Padding(2);
            this.chkBox_EsSaludable.Name = "chkBox_EsSaludable";
            this.chkBox_EsSaludable.Size = new System.Drawing.Size(98, 17);
            this.chkBox_EsSaludable.TabIndex = 8;
            this.chkBox_EsSaludable.Text = "¿Es saludable?";
            this.chkBox_EsSaludable.UseVisualStyleBackColor = true;
            // 
            // grilla_SelectIngredientes
            // 
            this.grilla_SelectIngredientes.AllowUserToAddRows = false;
            this.grilla_SelectIngredientes.AllowUserToDeleteRows = false;
            this.grilla_SelectIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_SelectIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Codigo,
            this.NombreProducto});
            this.grilla_SelectIngredientes.Location = new System.Drawing.Point(213, 70);
            this.grilla_SelectIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.grilla_SelectIngredientes.Name = "grilla_SelectIngredientes";
            this.grilla_SelectIngredientes.ReadOnly = true;
            this.grilla_SelectIngredientes.RowHeadersWidth = 51;
            this.grilla_SelectIngredientes.RowTemplate.Height = 24;
            this.grilla_SelectIngredientes.Size = new System.Drawing.Size(507, 205);
            this.grilla_SelectIngredientes.TabIndex = 9;
            this.grilla_SelectIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_SelectIngredientes_CellContentClick);
            // 
            // lbl_IngredientesNecesarios
            // 
            this.lbl_IngredientesNecesarios.AutoSize = true;
            this.lbl_IngredientesNecesarios.Location = new System.Drawing.Point(372, 37);
            this.lbl_IngredientesNecesarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IngredientesNecesarios.Name = "lbl_IngredientesNecesarios";
            this.lbl_IngredientesNecesarios.Size = new System.Drawing.Size(119, 13);
            this.lbl_IngredientesNecesarios.TabIndex = 10;
            this.lbl_IngredientesNecesarios.Text = "Ingredientes necesarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cena);
            this.groupBox1.Controls.Add(this.merienda);
            this.groupBox1.Controls.Add(this.desayuno);
            this.groupBox1.Controls.Add(this.almuerzo);
            this.groupBox1.Location = new System.Drawing.Point(102, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // Nombre
            // 
            this.Nombre.HeaderText = "Agregar Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // NuevaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_IngredientesNecesarios);
            this.Controls.Add(this.grilla_SelectIngredientes);
            this.Controls.Add(this.chkBox_EsSaludable);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.lbl_momentoDelDia);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Volver_NuevaReceta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_confirmarReceta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NuevaReceta";
            this.Text = "NuevaReceta";
            ((System.ComponentModel.ISupportInitialize)(this.grilla_SelectIngredientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmarReceta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Volver_NuevaReceta;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_momentoDelDia;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.CheckBox chkBox_EsSaludable;
        private System.Windows.Forms.DataGridView grilla_SelectIngredientes;
        private System.Windows.Forms.Label lbl_IngredientesNecesarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cena;
        private System.Windows.Forms.RadioButton merienda;
        private System.Windows.Forms.RadioButton desayuno;
        private System.Windows.Forms.RadioButton almuerzo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
    }
}