namespace Forms_Inicio
{
    partial class Form_Frutas
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
            this.btn_volver_frutas = new System.Windows.Forms.Button();
            this.textbx_Nombre_fruta = new System.Windows.Forms.TextBox();
            this.txtbx_Cantidad_fruta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grillafrutas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_Precio_unitario_fruta = new System.Windows.Forms.TextBox();
            this.txtbx_cantminima_fruta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillafrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver_frutas
            // 
            this.btn_volver_frutas.Location = new System.Drawing.Point(12, 12);
            this.btn_volver_frutas.Name = "btn_volver_frutas";
            this.btn_volver_frutas.Size = new System.Drawing.Size(129, 45);
            this.btn_volver_frutas.TabIndex = 0;
            this.btn_volver_frutas.Text = "Volver";
            this.btn_volver_frutas.UseVisualStyleBackColor = true;
            this.btn_volver_frutas.Click += new System.EventHandler(this.btn_volver_frutas_Click);
            // 
            // textbx_Nombre_fruta
            // 
            this.textbx_Nombre_fruta.Location = new System.Drawing.Point(26, 171);
            this.textbx_Nombre_fruta.Name = "textbx_Nombre_fruta";
            this.textbx_Nombre_fruta.Size = new System.Drawing.Size(127, 20);
            this.textbx_Nombre_fruta.TabIndex = 1;
            // 
            // txtbx_Cantidad_fruta
            // 
            this.txtbx_Cantidad_fruta.Location = new System.Drawing.Point(26, 250);
            this.txtbx_Cantidad_fruta.Name = "txtbx_Cantidad_fruta";
            this.txtbx_Cantidad_fruta.Size = new System.Drawing.Size(127, 20);
            this.txtbx_Cantidad_fruta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " Cantidad: (unidades)";
            // 
            // grillafrutas
            // 
            this.grillafrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillafrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Codigo,
            this.Editar,
            this.Eliminar});
            this.grillafrutas.Location = new System.Drawing.Point(186, 31);
            this.grillafrutas.Name = "grillafrutas";
            this.grillafrutas.RowHeadersWidth = 51;
            this.grillafrutas.Size = new System.Drawing.Size(542, 523);
            this.grillafrutas.TabIndex = 6;
            this.grillafrutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillafrutas_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(26, 511);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(106, 43);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio Unitario";
            // 
            // txtbx_Precio_unitario_fruta
            // 
            this.txtbx_Precio_unitario_fruta.Location = new System.Drawing.Point(26, 429);
            this.txtbx_Precio_unitario_fruta.Name = "txtbx_Precio_unitario_fruta";
            this.txtbx_Precio_unitario_fruta.Size = new System.Drawing.Size(127, 20);
            this.txtbx_Precio_unitario_fruta.TabIndex = 10;
            // 
            // txtbx_cantminima_fruta
            // 
            this.txtbx_cantminima_fruta.Location = new System.Drawing.Point(26, 336);
            this.txtbx_cantminima_fruta.Name = "txtbx_cantminima_fruta";
            this.txtbx_cantminima_fruta.Size = new System.Drawing.Size(127, 20);
            this.txtbx_cantminima_fruta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ingresar una fruta:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre de la fruta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad Minima";
            // 
            // Form_Frutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 590);
            this.Controls.Add(this.txtbx_cantminima_fruta);
            this.Controls.Add(this.txtbx_Precio_unitario_fruta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.grillafrutas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_Cantidad_fruta);
            this.Controls.Add(this.textbx_Nombre_fruta);
            this.Controls.Add(this.btn_volver_frutas);
            this.Name = "Form_Frutas";
            this.Text = "Form_Frutas";
            this.Load += new System.EventHandler(this.Form_Frutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillafrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_frutas;
        private System.Windows.Forms.TextBox textbx_Nombre_fruta;
        private System.Windows.Forms.TextBox txtbx_Cantidad_fruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grillafrutas;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_Precio_unitario_fruta;
        private System.Windows.Forms.TextBox txtbx_cantminima_fruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}