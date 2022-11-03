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
            this.textbx_Nombre = new System.Windows.Forms.TextBox();
            this.txtbx_Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grillafrutas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_PrecioxKG = new System.Windows.Forms.TextBox();
            this.txtbx_cantminima = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillafrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver_frutas
            // 
            this.btn_volver_frutas.Location = new System.Drawing.Point(40, 43);
            this.btn_volver_frutas.Name = "btn_volver_frutas";
            this.btn_volver_frutas.Size = new System.Drawing.Size(129, 45);
            this.btn_volver_frutas.TabIndex = 0;
            this.btn_volver_frutas.Text = "Volver";
            this.btn_volver_frutas.UseVisualStyleBackColor = true;
            this.btn_volver_frutas.Click += new System.EventHandler(this.btn_volver_frutas_Click);
            // 
            // textbx_Nombre
            // 
            this.textbx_Nombre.Location = new System.Drawing.Point(40, 192);
            this.textbx_Nombre.Name = "textbx_Nombre";
            this.textbx_Nombre.Size = new System.Drawing.Size(127, 20);
            this.textbx_Nombre.TabIndex = 1;
            // 
            // txtbx_Cantidad
            // 
            this.txtbx_Cantidad.Location = new System.Drawing.Point(40, 270);
            this.txtbx_Cantidad.Name = "txtbx_Cantidad";
            this.txtbx_Cantidad.Size = new System.Drawing.Size(127, 20);
            this.txtbx_Cantidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar una fruta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de la fruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Canitdad";
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
            this.grillafrutas.Location = new System.Drawing.Point(176, 12);
            this.grillafrutas.Name = "grillafrutas";
            this.grillafrutas.Size = new System.Drawing.Size(542, 523);
            this.grillafrutas.TabIndex = 6;
            this.grillafrutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillafrutas_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
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
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(40, 476);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(94, 31);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad Minima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio Unitario";
            // 
            // txtbx_PrecioxKG
            // 
            this.txtbx_PrecioxKG.Location = new System.Drawing.Point(40, 432);
            this.txtbx_PrecioxKG.Name = "txtbx_PrecioxKG";
            this.txtbx_PrecioxKG.Size = new System.Drawing.Size(127, 20);
            this.txtbx_PrecioxKG.TabIndex = 10;
            // 
            // txtbx_cantminima
            // 
            this.txtbx_cantminima.Location = new System.Drawing.Point(43, 347);
            this.txtbx_cantminima.Name = "txtbx_cantminima";
            this.txtbx_cantminima.Size = new System.Drawing.Size(127, 20);
            this.txtbx_cantminima.TabIndex = 11;
            // 
            // Form_Frutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 590);
            this.Controls.Add(this.txtbx_cantminima);
            this.Controls.Add(this.txtbx_PrecioxKG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.grillafrutas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_Cantidad);
            this.Controls.Add(this.textbx_Nombre);
            this.Controls.Add(this.btn_volver_frutas);
            this.Name = "Form_Frutas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Frutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillafrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_frutas;
        private System.Windows.Forms.TextBox textbx_Nombre;
        private System.Windows.Forms.TextBox txtbx_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grillafrutas;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_PrecioxKG;
        private System.Windows.Forms.TextBox txtbx_cantminima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}