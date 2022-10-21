namespace Forms_Inicio
{
    partial class Form_Bebidas
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
            this.btn_volver_Bebidas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lector_Cantidad = new System.Windows.Forms.TextBox();
            this.Lector_Nombre = new System.Windows.Forms.TextBox();
            this.Tipobebida = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grilla_bebidas = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boton_acpetar_bebidas = new System.Windows.Forms.Button();
            this.TipoBebidaColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipobebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_bebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver_Bebidas
            // 
            this.btn_volver_Bebidas.Location = new System.Drawing.Point(27, 29);
            this.btn_volver_Bebidas.Name = "btn_volver_Bebidas";
            this.btn_volver_Bebidas.Size = new System.Drawing.Size(112, 40);
            this.btn_volver_Bebidas.TabIndex = 0;
            this.btn_volver_Bebidas.Text = "Volver";
            this.btn_volver_Bebidas.UseVisualStyleBackColor = true;
            this.btn_volver_Bebidas.Click += new System.EventHandler(this.btn_volver_Bebidas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la bebida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresar una bebida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lector_Cantidad
            // 
            this.Lector_Cantidad.Location = new System.Drawing.Point(25, 266);
            this.Lector_Cantidad.Name = "Lector_Cantidad";
            this.Lector_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Lector_Cantidad.TabIndex = 4;
            // 
            // Lector_Nombre
            // 
            this.Lector_Nombre.Location = new System.Drawing.Point(25, 187);
            this.Lector_Nombre.Name = "Lector_Nombre";
            this.Lector_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Lector_Nombre.TabIndex = 5;
            // 
            // Tipobebida
            // 
            this.Tipobebida.Controls.Add(this.radioButton3);
            this.Tipobebida.Controls.Add(this.radioButton2);
            this.Tipobebida.Controls.Add(this.radioButton1);
            this.Tipobebida.Location = new System.Drawing.Point(27, 323);
            this.Tipobebida.Name = "Tipobebida";
            this.Tipobebida.Size = new System.Drawing.Size(112, 100);
            this.Tipobebida.TabIndex = 8;
            this.Tipobebida.TabStop = false;
            this.Tipobebida.Text = "Tipo de bebida";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Alta en azucares";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No alcoholica";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Alcoholica";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grilla_bebidas
            // 
            this.grilla_bebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Nombre,
            this.TipoBebidaColumna});
            this.grilla_bebidas.Location = new System.Drawing.Point(145, 29);
            this.grilla_bebidas.Name = "grilla_bebidas";
            this.grilla_bebidas.Size = new System.Drawing.Size(336, 439);
            this.grilla_bebidas.TabIndex = 9;
            this.grilla_bebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_bebidas_CellContentClick);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Articulo";
            this.Nombre.Name = "Nombre";
            // 
            // Boton_acpetar_bebidas
            // 
            this.Boton_acpetar_bebidas.Location = new System.Drawing.Point(25, 445);
            this.Boton_acpetar_bebidas.Name = "Boton_acpetar_bebidas";
            this.Boton_acpetar_bebidas.Size = new System.Drawing.Size(75, 23);
            this.Boton_acpetar_bebidas.TabIndex = 10;
            this.Boton_acpetar_bebidas.Text = "ACEPTAR";
            this.Boton_acpetar_bebidas.UseVisualStyleBackColor = true;
            this.Boton_acpetar_bebidas.Click += new System.EventHandler(this.Boton_acpetar_bebidas_Click);
            // 
            // TipoBebidaColumna
            // 
            this.TipoBebidaColumna.HeaderText = "Tipo Bebida";
            this.TipoBebidaColumna.Name = "TipoBebidaColumna";
            // 
            // Form_Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 535);
            this.Controls.Add(this.Boton_acpetar_bebidas);
            this.Controls.Add(this.grilla_bebidas);
            this.Controls.Add(this.Tipobebida);
            this.Controls.Add(this.Lector_Nombre);
            this.Controls.Add(this.Lector_Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volver_Bebidas);
            this.Name = "Form_Bebidas";
            this.Text = "Form_Bebidas";
            this.Tipobebida.ResumeLayout(false);
            this.Tipobebida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_bebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_Bebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Lector_Cantidad;
        private System.Windows.Forms.TextBox Lector_Nombre;
        private System.Windows.Forms.GroupBox Tipobebida;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView grilla_bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button Boton_acpetar_bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBebidaColumna;
    }
}