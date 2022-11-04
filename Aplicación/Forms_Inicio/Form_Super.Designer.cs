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
            this.addToCarrito = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.visor_Total = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioKG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadComprar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Super)).BeginInit();
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
            this.btn_GeneraCarrito.Location = new System.Drawing.Point(198, 385);
            this.btn_GeneraCarrito.Name = "btn_GeneraCarrito";
            this.btn_GeneraCarrito.Size = new System.Drawing.Size(180, 69);
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
            this.grilla_Super.Location = new System.Drawing.Point(12, 87);
            this.grilla_Super.Name = "grilla_Super";
            this.grilla_Super.Size = new System.Drawing.Size(636, 263);
            this.grilla_Super.TabIndex = 2;
            this.grilla_Super.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_Super_CellContentClick);
            // 
            // addToCarrito
            // 
            this.addToCarrito.Location = new System.Drawing.Point(384, 385);
            this.addToCarrito.Name = "addToCarrito";
            this.addToCarrito.Size = new System.Drawing.Size(180, 69);
            this.addToCarrito.TabIndex = 3;
            this.addToCarrito.Text = "Agregar al carrito";
            this.addToCarrito.UseVisualStyleBackColor = true;
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(12, 385);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(180, 69);
            this.btn_total.TabIndex = 4;
            this.btn_total.Text = "Calcular total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // visor_Total
            // 
            this.visor_Total.Location = new System.Drawing.Point(12, 461);
            this.visor_Total.Name = "visor_Total";
            this.visor_Total.ReadOnly = true;
            this.visor_Total.Size = new System.Drawing.Size(180, 20);
            this.visor_Total.TabIndex = 5;
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
            // Form_Super
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 493);
            this.Controls.Add(this.visor_Total);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.addToCarrito);
            this.Controls.Add(this.grilla_Super);
            this.Controls.Add(this.btn_GeneraCarrito);
            this.Controls.Add(this.btn_Volver_Super);
            this.Name = "Form_Super";
            this.Text = "Form_Super";
            this.Load += new System.EventHandler(this.Form_Super_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Super)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Super;
        private System.Windows.Forms.Button btn_GeneraCarrito;
        private System.Windows.Forms.DataGridView grilla_Super;
        private System.Windows.Forms.Button addToCarrito;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.TextBox visor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioKG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadComprar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Comprar;
    }
}