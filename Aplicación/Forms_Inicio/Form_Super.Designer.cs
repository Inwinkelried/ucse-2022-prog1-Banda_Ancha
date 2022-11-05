namespace Forms_Inicio
{
    partial class Form_Super
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
            this.btn_Volver_Super = new System.Windows.Forms.Button();
            this.btn_GeneraCarrito = new System.Windows.Forms.Button();
            this.grilla_Super = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioKG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadComprar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FiltroLacteos = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.visor_Total = new System.Windows.Forms.TextBox();
            this.btn_filtrocarniceria = new System.Windows.Forms.Button();
            this.btn_FiltroPrecio = new System.Windows.Forms.Button();
            this.txt_FiltroPrecio = new System.Windows.Forms.TextBox();
            this.btn_FiltroVerduleria = new System.Windows.Forms.Button();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.radioButton_Panaderia = new System.Windows.Forms.RadioButton();
            this.radioButton_Bebidas = new System.Windows.Forms.RadioButton();
            this.radioButton_Lacteos = new System.Windows.Forms.RadioButton();
            this.radioButton_Quesos = new System.Windows.Forms.RadioButton();
            this.radioButton_pescados = new System.Windows.Forms.RadioButton();
            this.radioButton_Carnes = new System.Windows.Forms.RadioButton();
            this.radioButton_Frutas = new System.Windows.Forms.RadioButton();
            this.radioButton_Verduras = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Super)).BeginInit();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Volver_Super
            // 
            this.btn_Volver_Super.Location = new System.Drawing.Point(12, 19);
            this.btn_Volver_Super.Name = "btn_Volver_Super";
            this.btn_Volver_Super.Size = new System.Drawing.Size(115, 43);
            this.btn_Volver_Super.TabIndex = 0;
            this.btn_Volver_Super.Text = "Volver";
            this.btn_Volver_Super.UseVisualStyleBackColor = true;
            this.btn_Volver_Super.Click += new System.EventHandler(this.btn_Volver_Super_Click);
            // 
            // btn_GeneraCarrito
            // 
            this.btn_GeneraCarrito.Location = new System.Drawing.Point(12, 438);
            this.btn_GeneraCarrito.Name = "btn_GeneraCarrito";
            this.btn_GeneraCarrito.Size = new System.Drawing.Size(147, 43);
            this.btn_GeneraCarrito.TabIndex = 1;
            this.btn_GeneraCarrito.Text = "Generar carrito de supermercado";
            this.btn_GeneraCarrito.UseVisualStyleBackColor = true;
            this.btn_GeneraCarrito.Click += new System.EventHandler(this.btn_GeneraCarrito_Click);
            // 
            // grilla_Super
            // 
            this.grilla_Super.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_Super.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.CantidadActual,
            this.CantidadMinima,
            this.PrecioUnitarioKG,
            this.CantidadComprar,
            this.Comprar});
            this.grilla_Super.Location = new System.Drawing.Point(12, 116);
            this.grilla_Super.Name = "grilla_Super";
            this.grilla_Super.Size = new System.Drawing.Size(636, 263);
            this.grilla_Super.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // CantidadActual
            // 
            this.CantidadActual.DataPropertyName = "Cantidad";
            this.CantidadActual.HeaderText = "Cantidad Actual";
            this.CantidadActual.Name = "CantidadActual";
            this.CantidadActual.ReadOnly = true;
            // 
            // CantidadMinima
            // 
            this.CantidadMinima.DataPropertyName = "CantMinima";
            this.CantidadMinima.HeaderText = "Cantidad Minima";
            this.CantidadMinima.Name = "CantidadMinima";
            this.CantidadMinima.ReadOnly = true;
            // 
            // PrecioUnitarioKG
            // 
            this.PrecioUnitarioKG.DataPropertyName = "Precio";
            this.PrecioUnitarioKG.HeaderText = "Precio";
            this.PrecioUnitarioKG.Name = "PrecioUnitarioKG";
            // 
            // CantidadComprar
            // 
            this.CantidadComprar.DataPropertyName = "Codigo";
            this.CantidadComprar.HeaderText = "Codigo";
            this.CantidadComprar.Name = "CantidadComprar";
            // 
            // Comprar
            // 
            this.Comprar.HeaderText = "Comprar";
            this.Comprar.Name = "Comprar";
            // 
            // FiltroLacteos
            // 
            this.FiltroLacteos.Location = new System.Drawing.Point(491, 385);
            this.FiltroLacteos.Name = "FiltroLacteos";
            this.FiltroLacteos.Size = new System.Drawing.Size(139, 43);
            this.FiltroLacteos.TabIndex = 3;
            this.FiltroLacteos.Text = "Filtrar por Lacteos";
            this.FiltroLacteos.UseVisualStyleBackColor = true;
            this.FiltroLacteos.Click += new System.EventHandler(this.FiltroLacteos_Click);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(133, 19);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(139, 43);
            this.btn_total.TabIndex = 4;
            this.btn_total.Text = "Calcular total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // visor_Total
            // 
            this.visor_Total.Location = new System.Drawing.Point(133, 84);
            this.visor_Total.Name = "visor_Total";
            this.visor_Total.ReadOnly = true;
            this.visor_Total.Size = new System.Drawing.Size(139, 20);
            this.visor_Total.TabIndex = 5;
            // 
            // btn_filtrocarniceria
            // 
            this.btn_filtrocarniceria.Location = new System.Drawing.Point(12, 385);
            this.btn_filtrocarniceria.Name = "btn_filtrocarniceria";
            this.btn_filtrocarniceria.Size = new System.Drawing.Size(147, 43);
            this.btn_filtrocarniceria.TabIndex = 6;
            this.btn_filtrocarniceria.Text = "Filtro Carnes";
            this.btn_filtrocarniceria.UseVisualStyleBackColor = true;
            this.btn_filtrocarniceria.Click += new System.EventHandler(this.btn_filtrocarniceria_Click);
            // 
            // btn_FiltroPrecio
            // 
            this.btn_FiltroPrecio.Location = new System.Drawing.Point(319, 385);
            this.btn_FiltroPrecio.Name = "btn_FiltroPrecio";
            this.btn_FiltroPrecio.Size = new System.Drawing.Size(166, 43);
            this.btn_FiltroPrecio.TabIndex = 7;
            this.btn_FiltroPrecio.Text = "Filtrar por precio";
            this.btn_FiltroPrecio.UseVisualStyleBackColor = true;
            this.btn_FiltroPrecio.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_FiltroPrecio
            // 
            this.txt_FiltroPrecio.Location = new System.Drawing.Point(319, 438);
            this.txt_FiltroPrecio.Name = "txt_FiltroPrecio";
            this.txt_FiltroPrecio.Size = new System.Drawing.Size(166, 20);
            this.txt_FiltroPrecio.TabIndex = 9;
            // 
            // btn_FiltroVerduleria
            // 
            this.btn_FiltroVerduleria.Location = new System.Drawing.Point(166, 385);
            this.btn_FiltroVerduleria.Name = "btn_FiltroVerduleria";
            this.btn_FiltroVerduleria.Size = new System.Drawing.Size(147, 43);
            this.btn_FiltroVerduleria.TabIndex = 10;
            this.btn_FiltroVerduleria.Text = "Filtro Verduleria";
            this.btn_FiltroVerduleria.UseVisualStyleBackColor = true;
            this.btn_FiltroVerduleria.Click += new System.EventHandler(this.btn_FiltroVerduleria_Click);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.radioButton_Panaderia);
            this.groupbox.Controls.Add(this.radioButton_Bebidas);
            this.groupbox.Controls.Add(this.radioButton_Lacteos);
            this.groupbox.Controls.Add(this.radioButton_Quesos);
            this.groupbox.Controls.Add(this.radioButton_pescados);
            this.groupbox.Controls.Add(this.radioButton_Carnes);
            this.groupbox.Controls.Add(this.radioButton_Frutas);
            this.groupbox.Controls.Add(this.radioButton_Verduras);
            this.groupbox.Location = new System.Drawing.Point(448, 10);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(200, 100);
            this.groupbox.TabIndex = 11;
            this.groupbox.TabStop = false;
            // 
            // radioButton_Panaderia
            // 
            this.radioButton_Panaderia.AutoSize = true;
            this.radioButton_Panaderia.Location = new System.Drawing.Point(97, 77);
            this.radioButton_Panaderia.Name = "radioButton_Panaderia";
            this.radioButton_Panaderia.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Panaderia.TabIndex = 7;
            this.radioButton_Panaderia.TabStop = true;
            this.radioButton_Panaderia.Text = "Panaderia";
            this.radioButton_Panaderia.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bebidas
            // 
            this.radioButton_Bebidas.AutoSize = true;
            this.radioButton_Bebidas.Location = new System.Drawing.Point(97, 54);
            this.radioButton_Bebidas.Name = "radioButton_Bebidas";
            this.radioButton_Bebidas.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Bebidas.TabIndex = 6;
            this.radioButton_Bebidas.TabStop = true;
            this.radioButton_Bebidas.Text = "Bebidas";
            this.radioButton_Bebidas.UseVisualStyleBackColor = true;
            // 
            // radioButton_Lacteos
            // 
            this.radioButton_Lacteos.AutoSize = true;
            this.radioButton_Lacteos.Location = new System.Drawing.Point(97, 32);
            this.radioButton_Lacteos.Name = "radioButton_Lacteos";
            this.radioButton_Lacteos.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Lacteos.TabIndex = 5;
            this.radioButton_Lacteos.TabStop = true;
            this.radioButton_Lacteos.Text = "Lacteos";
            this.radioButton_Lacteos.UseVisualStyleBackColor = true;
            // 
            // radioButton_Quesos
            // 
            this.radioButton_Quesos.AutoSize = true;
            this.radioButton_Quesos.Location = new System.Drawing.Point(97, 9);
            this.radioButton_Quesos.Name = "radioButton_Quesos";
            this.radioButton_Quesos.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Quesos.TabIndex = 4;
            this.radioButton_Quesos.TabStop = true;
            this.radioButton_Quesos.Text = "Quesos";
            this.radioButton_Quesos.UseVisualStyleBackColor = true;
            // 
            // radioButton_pescados
            // 
            this.radioButton_pescados.AutoSize = true;
            this.radioButton_pescados.Location = new System.Drawing.Point(6, 77);
            this.radioButton_pescados.Name = "radioButton_pescados";
            this.radioButton_pescados.Size = new System.Drawing.Size(72, 17);
            this.radioButton_pescados.TabIndex = 3;
            this.radioButton_pescados.TabStop = true;
            this.radioButton_pescados.Text = "Pescados";
            this.radioButton_pescados.UseVisualStyleBackColor = true;
            // 
            // radioButton_Carnes
            // 
            this.radioButton_Carnes.AutoSize = true;
            this.radioButton_Carnes.Location = new System.Drawing.Point(6, 54);
            this.radioButton_Carnes.Name = "radioButton_Carnes";
            this.radioButton_Carnes.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Carnes.TabIndex = 2;
            this.radioButton_Carnes.TabStop = true;
            this.radioButton_Carnes.Text = "Carnes";
            this.radioButton_Carnes.UseVisualStyleBackColor = true;
            // 
            // radioButton_Frutas
            // 
            this.radioButton_Frutas.AutoSize = true;
            this.radioButton_Frutas.Location = new System.Drawing.Point(6, 32);
            this.radioButton_Frutas.Name = "radioButton_Frutas";
            this.radioButton_Frutas.Size = new System.Drawing.Size(54, 17);
            this.radioButton_Frutas.TabIndex = 1;
            this.radioButton_Frutas.TabStop = true;
            this.radioButton_Frutas.Text = "Frutas";
            this.radioButton_Frutas.UseVisualStyleBackColor = true;
            // 
            // radioButton_Verduras
            // 
            this.radioButton_Verduras.AutoSize = true;
            this.radioButton_Verduras.Location = new System.Drawing.Point(6, 9);
            this.radioButton_Verduras.Name = "radioButton_Verduras";
            this.radioButton_Verduras.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Verduras.TabIndex = 0;
            this.radioButton_Verduras.TabStop = true;
            this.radioButton_Verduras.Text = "Verduras";
            this.radioButton_Verduras.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Super
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.btn_FiltroVerduleria);
            this.Controls.Add(this.txt_FiltroPrecio);
            this.Controls.Add(this.btn_FiltroPrecio);
            this.Controls.Add(this.btn_filtrocarniceria);
            this.Controls.Add(this.visor_Total);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.FiltroLacteos);
            this.Controls.Add(this.grilla_Super);
            this.Controls.Add(this.btn_GeneraCarrito);
            this.Controls.Add(this.btn_Volver_Super);
            this.Name = "Form_Super";
            this.Text = "Form_Super";
            this.Load += new System.EventHandler(this.Form_Super_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Super)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Super;
        private System.Windows.Forms.Button btn_GeneraCarrito;
        private System.Windows.Forms.DataGridView grilla_Super;
        private System.Windows.Forms.Button FiltroLacteos;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.TextBox visor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioKG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadComprar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Comprar;
        private System.Windows.Forms.Button btn_filtrocarniceria;
        private System.Windows.Forms.Button btn_FiltroPrecio;
        private System.Windows.Forms.TextBox txt_FiltroPrecio;
        private System.Windows.Forms.Button btn_FiltroVerduleria;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.RadioButton radioButton_Panaderia;
        private System.Windows.Forms.RadioButton radioButton_Bebidas;
        private System.Windows.Forms.RadioButton radioButton_Lacteos;
        private System.Windows.Forms.RadioButton radioButton_Quesos;
        private System.Windows.Forms.RadioButton radioButton_pescados;
        private System.Windows.Forms.RadioButton radioButton_Carnes;
        private System.Windows.Forms.RadioButton radioButton_Frutas;
        private System.Windows.Forms.RadioButton radioButton_Verduras;
        private System.Windows.Forms.Button button1;
    }
}