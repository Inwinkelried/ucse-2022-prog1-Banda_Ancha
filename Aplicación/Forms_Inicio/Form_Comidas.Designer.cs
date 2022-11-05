namespace Forms_Inicio
{
    partial class Form_Comidas
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
            this.btn_Volver_Comidas = new System.Windows.Forms.Button();
            this.CrearComidabtn = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grilla_RecetasComidas = new System.Windows.Forms.DataGridView();
            this.NombreReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_RecetasComidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver_Comidas
            // 
            this.btn_Volver_Comidas.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_Comidas.Name = "btn_Volver_Comidas";
            this.btn_Volver_Comidas.Size = new System.Drawing.Size(115, 43);
            this.btn_Volver_Comidas.TabIndex = 1;
            this.btn_Volver_Comidas.Text = "Volver";
            this.btn_Volver_Comidas.UseVisualStyleBackColor = true;
            this.btn_Volver_Comidas.Click += new System.EventHandler(this.btn_Volver_Comidas_Click);
            // 
            // CrearComidabtn
            // 
            this.CrearComidabtn.Location = new System.Drawing.Point(12, 80);
            this.CrearComidabtn.Name = "CrearComidabtn";
            this.CrearComidabtn.Size = new System.Drawing.Size(115, 43);
            this.CrearComidabtn.TabIndex = 3;
            this.CrearComidabtn.Text = "Crear comida";
            this.CrearComidabtn.UseVisualStyleBackColor = true;
            this.CrearComidabtn.Click += new System.EventHandler(this.CrearComidabtn_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(12, 219);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(115, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de la receta";
            // 
            // grilla_RecetasComidas
            // 
            this.grilla_RecetasComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_RecetasComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreReceta,
            this.Seleccionar});
            this.grilla_RecetasComidas.Location = new System.Drawing.Point(202, 12);
            this.grilla_RecetasComidas.Name = "grilla_RecetasComidas";
            this.grilla_RecetasComidas.Size = new System.Drawing.Size(243, 360);
            this.grilla_RecetasComidas.TabIndex = 6;
            this.grilla_RecetasComidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_RecetasComidas_CellContentClick);
            // 
            // NombreReceta
            // 
            this.NombreReceta.DataPropertyName = "Nombre";
            this.NombreReceta.HeaderText = "Nombre Receta";
            this.NombreReceta.Name = "NombreReceta";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Historial comidas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Comidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grilla_RecetasComidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.CrearComidabtn);
            this.Controls.Add(this.btn_Volver_Comidas);
            this.Name = "Form_Comidas";
            this.Text = "Form_Comidas";
            this.Load += new System.EventHandler(this.Form_Comidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_RecetasComidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Comidas;
        private System.Windows.Forms.Button CrearComidabtn;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla_RecetasComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreReceta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button button1;
    }
}