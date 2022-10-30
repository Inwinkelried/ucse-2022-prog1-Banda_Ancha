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
            this.typebeb_grpbx = new System.Windows.Forms.GroupBox();
            this.altaenazucares = new System.Windows.Forms.RadioButton();
            this.noalcoholica = new System.Windows.Forms.RadioButton();
            this.alcoholica = new System.Windows.Forms.RadioButton();
            this.grilla_bebidas = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBebidaColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boton_acpetar_bebidas = new System.Windows.Forms.Button();
            this.typebeb_grpbx.SuspendLayout();
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
            this.Lector_Cantidad.TextChanged += new System.EventHandler(this.Lector_Cantidad_TextChanged);
            // 
            // Lector_Nombre
            // 
            this.Lector_Nombre.Location = new System.Drawing.Point(25, 187);
            this.Lector_Nombre.Name = "Lector_Nombre";
            this.Lector_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Lector_Nombre.TabIndex = 5;
            // 
            // typebeb_grpbx
            // 
            this.typebeb_grpbx.Controls.Add(this.altaenazucares);
            this.typebeb_grpbx.Controls.Add(this.noalcoholica);
            this.typebeb_grpbx.Controls.Add(this.alcoholica);
            this.typebeb_grpbx.Location = new System.Drawing.Point(27, 323);
            this.typebeb_grpbx.Name = "typebeb_grpbx";
            this.typebeb_grpbx.Size = new System.Drawing.Size(112, 100);
            this.typebeb_grpbx.TabIndex = 8;
            this.typebeb_grpbx.TabStop = false;
            this.typebeb_grpbx.Text = "Tipo de bebida";
            // 
            // altaenazucares
            // 
            this.altaenazucares.AutoSize = true;
            this.altaenazucares.Location = new System.Drawing.Point(7, 77);
            this.altaenazucares.Name = "altaenazucares";
            this.altaenazucares.Size = new System.Drawing.Size(104, 17);
            this.altaenazucares.TabIndex = 2;
            this.altaenazucares.TabStop = true;
            this.altaenazucares.Text = "Alta en azucares";
            this.altaenazucares.UseVisualStyleBackColor = true;
            // 
            // noalcoholica
            // 
            this.noalcoholica.AutoSize = true;
            this.noalcoholica.Location = new System.Drawing.Point(7, 54);
            this.noalcoholica.Name = "noalcoholica";
            this.noalcoholica.Size = new System.Drawing.Size(90, 17);
            this.noalcoholica.TabIndex = 1;
            this.noalcoholica.TabStop = true;
            this.noalcoholica.Text = "No alcoholica";
            this.noalcoholica.UseVisualStyleBackColor = true;
            // 
            // alcoholica
            // 
            this.alcoholica.AutoSize = true;
            this.alcoholica.Location = new System.Drawing.Point(7, 30);
            this.alcoholica.Name = "alcoholica";
            this.alcoholica.Size = new System.Drawing.Size(74, 17);
            this.alcoholica.TabIndex = 0;
            this.alcoholica.TabStop = true;
            this.alcoholica.Text = "Alcoholica";
            this.alcoholica.UseVisualStyleBackColor = true;
            this.alcoholica.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // TipoBebidaColumna
            // 
            this.TipoBebidaColumna.HeaderText = "Tipo Bebida";
            this.TipoBebidaColumna.Name = "TipoBebidaColumna";
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
            // Form_Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 535);
            this.Controls.Add(this.Boton_acpetar_bebidas);
            this.Controls.Add(this.grilla_bebidas);
            this.Controls.Add(this.typebeb_grpbx);
            this.Controls.Add(this.Lector_Nombre);
            this.Controls.Add(this.Lector_Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volver_Bebidas);
            this.Name = "Form_Bebidas";
            this.Text = "Form_Bebidas";
            this.typebeb_grpbx.ResumeLayout(false);
            this.typebeb_grpbx.PerformLayout();
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
        private System.Windows.Forms.GroupBox typebeb_grpbx;
        private System.Windows.Forms.RadioButton altaenazucares;
        private System.Windows.Forms.RadioButton noalcoholica;
        private System.Windows.Forms.RadioButton alcoholica;
        private System.Windows.Forms.DataGridView grilla_bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button Boton_acpetar_bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBebidaColumna;
    }
}