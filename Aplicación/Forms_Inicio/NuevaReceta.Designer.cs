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
            this.comboBox_momentoDelDia = new System.Windows.Forms.ComboBox();
            this.chkBox_EsSaludable = new System.Windows.Forms.CheckBox();
            this.grilla_SelectIngredientes = new System.Windows.Forms.DataGridView();
            this.lbl_IngredientesNecesarios = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_SelectIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirmarReceta
            // 
            this.btn_confirmarReceta.Location = new System.Drawing.Point(496, 323);
            this.btn_confirmarReceta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(95, 33);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Volver_NuevaReceta
            // 
            this.btn_Volver_NuevaReceta.Location = new System.Drawing.Point(9, 10);
            this.btn_Volver_NuevaReceta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lbl_Nombre.Location = new System.Drawing.Point(17, 100);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_momentoDelDia
            // 
            this.lbl_momentoDelDia.AutoSize = true;
            this.lbl_momentoDelDia.Location = new System.Drawing.Point(17, 133);
            this.lbl_momentoDelDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_momentoDelDia.Name = "lbl_momentoDelDia";
            this.lbl_momentoDelDia.Size = new System.Drawing.Size(87, 13);
            this.lbl_momentoDelDia.TabIndex = 4;
            this.lbl_momentoDelDia.Text = "Momento del día";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(102, 97);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(107, 20);
            this.Txt_nombre.TabIndex = 5;
            // 
            // comboBox_momentoDelDia
            // 
            this.comboBox_momentoDelDia.FormattingEnabled = true;
            this.comboBox_momentoDelDia.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.comboBox_momentoDelDia.Location = new System.Drawing.Point(102, 131);
            this.comboBox_momentoDelDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_momentoDelDia.Name = "comboBox_momentoDelDia";
            this.comboBox_momentoDelDia.Size = new System.Drawing.Size(102, 21);
            this.comboBox_momentoDelDia.TabIndex = 6;
            this.comboBox_momentoDelDia.SelectedIndexChanged += new System.EventHandler(this.comboBox_momentoDelDia_SelectedIndexChanged);
            // 
            // chkBox_EsSaludable
            // 
            this.chkBox_EsSaludable.AutoSize = true;
            this.chkBox_EsSaludable.Location = new System.Drawing.Point(20, 179);
            this.chkBox_EsSaludable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.Check,
            this.Cantidad});
            this.grilla_SelectIngredientes.Location = new System.Drawing.Point(236, 70);
            this.grilla_SelectIngredientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grilla_SelectIngredientes.Name = "grilla_SelectIngredientes";
            this.grilla_SelectIngredientes.ReadOnly = true;
            this.grilla_SelectIngredientes.RowHeadersWidth = 51;
            this.grilla_SelectIngredientes.RowTemplate.Height = 24;
            this.grilla_SelectIngredientes.Size = new System.Drawing.Size(353, 205);
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
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Ingrediente";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // NuevaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbl_IngredientesNecesarios);
            this.Controls.Add(this.grilla_SelectIngredientes);
            this.Controls.Add(this.chkBox_EsSaludable);
            this.Controls.Add(this.comboBox_momentoDelDia);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.lbl_momentoDelDia);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Volver_NuevaReceta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_confirmarReceta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NuevaReceta";
            this.Text = "NuevaReceta";
            this.Load += new System.EventHandler(this.NuevaReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_SelectIngredientes)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_momentoDelDia;
        private System.Windows.Forms.CheckBox chkBox_EsSaludable;
        private System.Windows.Forms.DataGridView grilla_SelectIngredientes;
        private System.Windows.Forms.Label lbl_IngredientesNecesarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}