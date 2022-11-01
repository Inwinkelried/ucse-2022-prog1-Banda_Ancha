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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_IngredientesNecesarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirmarReceta
            // 
            this.btn_confirmarReceta.Location = new System.Drawing.Point(661, 397);
            this.btn_confirmarReceta.Name = "btn_confirmarReceta";
            this.btn_confirmarReceta.Size = new System.Drawing.Size(127, 41);
            this.btn_confirmarReceta.TabIndex = 0;
            this.btn_confirmarReceta.Text = "Confirmar";
            this.btn_confirmarReceta.UseVisualStyleBackColor = true;
            this.btn_confirmarReceta.Click += new System.EventHandler(this.btn_confirmarReceta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(528, 397);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(127, 41);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Volver_NuevaReceta
            // 
            this.btn_Volver_NuevaReceta.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_NuevaReceta.Name = "btn_Volver_NuevaReceta";
            this.btn_Volver_NuevaReceta.Size = new System.Drawing.Size(105, 30);
            this.btn_Volver_NuevaReceta.TabIndex = 2;
            this.btn_Volver_NuevaReceta.Text = "Volver";
            this.btn_Volver_NuevaReceta.UseVisualStyleBackColor = true;
            this.btn_Volver_NuevaReceta.Click += new System.EventHandler(this.btn_Volver_NuevaReceta_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(246, 39);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_momentoDelDia
            // 
            this.lbl_momentoDelDia.AutoSize = true;
            this.lbl_momentoDelDia.Location = new System.Drawing.Point(23, 164);
            this.lbl_momentoDelDia.Name = "lbl_momentoDelDia";
            this.lbl_momentoDelDia.Size = new System.Drawing.Size(107, 16);
            this.lbl_momentoDelDia.TabIndex = 4;
            this.lbl_momentoDelDia.Text = "Momento del día";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(308, 36);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(141, 22);
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
            this.comboBox_momentoDelDia.Location = new System.Drawing.Point(136, 161);
            this.comboBox_momentoDelDia.Name = "comboBox_momentoDelDia";
            this.comboBox_momentoDelDia.Size = new System.Drawing.Size(134, 24);
            this.comboBox_momentoDelDia.TabIndex = 6;
            // 
            // chkBox_EsSaludable
            // 
            this.chkBox_EsSaludable.AutoSize = true;
            this.chkBox_EsSaludable.Location = new System.Drawing.Point(26, 220);
            this.chkBox_EsSaludable.Name = "chkBox_EsSaludable";
            this.chkBox_EsSaludable.Size = new System.Drawing.Size(122, 20);
            this.chkBox_EsSaludable.TabIndex = 8;
            this.chkBox_EsSaludable.Text = "¿Es saludable?";
            this.chkBox_EsSaludable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 152);
            this.dataGridView1.TabIndex = 9;
            // 
            // lbl_IngredientesNecesarios
            // 
            this.lbl_IngredientesNecesarios.AutoSize = true;
            this.lbl_IngredientesNecesarios.Location = new System.Drawing.Point(504, 164);
            this.lbl_IngredientesNecesarios.Name = "lbl_IngredientesNecesarios";
            this.lbl_IngredientesNecesarios.Size = new System.Drawing.Size(151, 16);
            this.lbl_IngredientesNecesarios.TabIndex = 10;
            this.lbl_IngredientesNecesarios.Text = "Ingredientes necesarios";
            // 
            // NuevaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_IngredientesNecesarios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkBox_EsSaludable);
            this.Controls.Add(this.comboBox_momentoDelDia);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.lbl_momentoDelDia);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Volver_NuevaReceta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_confirmarReceta);
            this.Name = "NuevaReceta";
            this.Text = "NuevaReceta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_IngredientesNecesarios;
    }
}