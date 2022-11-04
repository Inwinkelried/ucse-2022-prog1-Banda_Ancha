namespace Forms_Inicio
{
    partial class Form_Verduras
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
            this.btn_Volver_Verduras = new System.Windows.Forms.Button();
            this.txtbx_cantminima_verdura = new System.Windows.Forms.TextBox();
            this.txtbx_Precio_unitario_verdura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_Cantidad_verdura = new System.Windows.Forms.TextBox();
            this.textbx_Nombre_verdura = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver_Verduras
            // 
            this.btn_Volver_Verduras.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_Verduras.Name = "btn_Volver_Verduras";
            this.btn_Volver_Verduras.Size = new System.Drawing.Size(149, 42);
            this.btn_Volver_Verduras.TabIndex = 0;
            this.btn_Volver_Verduras.Text = "Volver";
            this.btn_Volver_Verduras.UseVisualStyleBackColor = true;
            this.btn_Volver_Verduras.Click += new System.EventHandler(this.btn_Volver_Verduras_Click);
            // 
            // txtbx_cantminima_verdura
            // 
            this.txtbx_cantminima_verdura.Location = new System.Drawing.Point(12, 329);
            this.txtbx_cantminima_verdura.Name = "txtbx_cantminima_verdura";
            this.txtbx_cantminima_verdura.Size = new System.Drawing.Size(127, 20);
            this.txtbx_cantminima_verdura.TabIndex = 21;
            // 
            // txtbx_Precio_unitario_verdura
            // 
            this.txtbx_Precio_unitario_verdura.Location = new System.Drawing.Point(12, 422);
            this.txtbx_Precio_unitario_verdura.Name = "txtbx_Precio_unitario_verdura";
            this.txtbx_Precio_unitario_verdura.Size = new System.Drawing.Size(127, 20);
            this.txtbx_Precio_unitario_verdura.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Precio Unitario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad Minima";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(12, 504);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(106, 43);
            this.btn_aceptar.TabIndex = 17;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad:";
            // 
            // txtbx_Cantidad_verdura
            // 
            this.txtbx_Cantidad_verdura.Location = new System.Drawing.Point(12, 243);
            this.txtbx_Cantidad_verdura.Name = "txtbx_Cantidad_verdura";
            this.txtbx_Cantidad_verdura.Size = new System.Drawing.Size(127, 20);
            this.txtbx_Cantidad_verdura.TabIndex = 13;
            // 
            // textbx_Nombre_verdura
            // 
            this.textbx_Nombre_verdura.Location = new System.Drawing.Point(12, 164);
            this.textbx_Nombre_verdura.Name = "textbx_Nombre_verdura";
            this.textbx_Nombre_verdura.Size = new System.Drawing.Size(127, 20);
            this.textbx_Nombre_verdura.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Codigo,
            this.Editar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(236, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 500);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingresar una producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre de la verdura:";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad en stock";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Verduras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 591);
            this.Controls.Add(this.txtbx_cantminima_verdura);
            this.Controls.Add(this.txtbx_Precio_unitario_verdura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_Cantidad_verdura);
            this.Controls.Add(this.textbx_Nombre_verdura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Volver_Verduras);
            this.Name = "Form_Verduras";
            this.Text = "Form_Verduras";
            this.Load += new System.EventHandler(this.Form_Verduras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Verduras;
        private System.Windows.Forms.TextBox txtbx_cantminima_verdura;
        private System.Windows.Forms.TextBox txtbx_Precio_unitario_verdura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_Cantidad_verdura;
        private System.Windows.Forms.TextBox textbx_Nombre_verdura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}