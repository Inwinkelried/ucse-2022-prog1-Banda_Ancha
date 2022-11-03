namespace Forms_Inicio
{
    partial class Form_Panaderia
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
            this.btn_volver_Panaderia = new System.Windows.Forms.Button();
            this.grilla_Panaderia = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Aceptar_Panaderia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PrecioxKG = new System.Windows.Forms.TextBox();
            this.txt_CantMinima = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Panaderia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver_Panaderia
            // 
            this.btn_volver_Panaderia.Location = new System.Drawing.Point(12, 12);
            this.btn_volver_Panaderia.Name = "btn_volver_Panaderia";
            this.btn_volver_Panaderia.Size = new System.Drawing.Size(130, 45);
            this.btn_volver_Panaderia.TabIndex = 0;
            this.btn_volver_Panaderia.Text = "Volver";
            this.btn_volver_Panaderia.UseVisualStyleBackColor = true;
            this.btn_volver_Panaderia.Click += new System.EventHandler(this.btn_volver_Panaderia_Click);
            // 
            // grilla_Panaderia
            // 
            this.grilla_Panaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_Panaderia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Codigo,
            this.Editar,
            this.Eliminar});
            this.grilla_Panaderia.Location = new System.Drawing.Point(202, 12);
            this.grilla_Panaderia.Name = "grilla_Panaderia";
            this.grilla_Panaderia.Size = new System.Drawing.Size(542, 540);
            this.grilla_Panaderia.TabIndex = 1;
            this.grilla_Panaderia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_Panaderia_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar un produccto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(12, 216);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(12, 144);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "KG";
            // 
            // btn_Aceptar_Panaderia
            // 
            this.btn_Aceptar_Panaderia.Location = new System.Drawing.Point(12, 470);
            this.btn_Aceptar_Panaderia.Name = "btn_Aceptar_Panaderia";
            this.btn_Aceptar_Panaderia.Size = new System.Drawing.Size(130, 45);
            this.btn_Aceptar_Panaderia.TabIndex = 8;
            this.btn_Aceptar_Panaderia.Text = "Aceptar";
            this.btn_Aceptar_Panaderia.UseVisualStyleBackColor = true;
            this.btn_Aceptar_Panaderia.Click += new System.EventHandler(this.btn_Cargar_Panaderia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio por KG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad minima";
            // 
            // txt_PrecioxKG
            // 
            this.txt_PrecioxKG.Location = new System.Drawing.Point(16, 298);
            this.txt_PrecioxKG.Name = "txt_PrecioxKG";
            this.txt_PrecioxKG.Size = new System.Drawing.Size(100, 20);
            this.txt_PrecioxKG.TabIndex = 11;
            // 
            // txt_CantMinima
            // 
            this.txt_CantMinima.Location = new System.Drawing.Point(12, 393);
            this.txt_CantMinima.Name = "txt_CantMinima";
            this.txt_CantMinima.Size = new System.Drawing.Size(100, 20);
            this.txt_CantMinima.TabIndex = 12;
            // 
            // Form_Panaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 575);
            this.Controls.Add(this.txt_CantMinima);
            this.Controls.Add(this.txt_PrecioxKG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Aceptar_Panaderia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grilla_Panaderia);
            this.Controls.Add(this.btn_volver_Panaderia);
            this.Name = "Form_Panaderia";
            this.Text = "Form_Panaderia";
            this.Load += new System.EventHandler(this.Form_Panaderia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Panaderia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_Panaderia;
        private System.Windows.Forms.DataGridView grilla_Panaderia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Aceptar_Panaderia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PrecioxKG;
        private System.Windows.Forms.TextBox txt_CantMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}