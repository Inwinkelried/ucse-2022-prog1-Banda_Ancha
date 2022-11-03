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
            this.Boton_acpetar_bebidas = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBebidaColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.text_cantminima = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_precioUnitario = new System.Windows.Forms.TextBox();
            this.typebeb_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_bebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver_Bebidas
            // 
            this.btn_volver_Bebidas.Location = new System.Drawing.Point(12, 12);
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
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la bebida";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresar una bebida";
            
            // 
            // Lector_Cantidad
            // 
            this.Lector_Cantidad.Location = new System.Drawing.Point(12, 177);
            this.Lector_Cantidad.Name = "Lector_Cantidad";
            this.Lector_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Lector_Cantidad.TabIndex = 4;
            
            // 
            // Lector_Nombre
            // 
            this.Lector_Nombre.Location = new System.Drawing.Point(12, 111);
            this.Lector_Nombre.Name = "Lector_Nombre";
            this.Lector_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Lector_Nombre.TabIndex = 5;
            // 
            // typebeb_grpbx
            // 
            this.typebeb_grpbx.Controls.Add(this.altaenazucares);
            this.typebeb_grpbx.Controls.Add(this.noalcoholica);
            this.typebeb_grpbx.Controls.Add(this.alcoholica);
            this.typebeb_grpbx.Location = new System.Drawing.Point(12, 224);
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
            
            // 
            // grilla_bebidas
            // 
            this.grilla_bebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Nombre,
            this.TipoBebidaColumna,
            this.Editar,
            this.Eliminar,
            this.Codigo});
            this.grilla_bebidas.Location = new System.Drawing.Point(154, 29);
            this.grilla_bebidas.Name = "grilla_bebidas";
            this.grilla_bebidas.Size = new System.Drawing.Size(543, 439);
            this.grilla_bebidas.TabIndex = 9;
            this.grilla_bebidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_bebidas_CellClick);
            // 
            // Boton_acpetar_bebidas
            // 
            this.Boton_acpetar_bebidas.Location = new System.Drawing.Point(12, 500);
            this.Boton_acpetar_bebidas.Name = "Boton_acpetar_bebidas";
            this.Boton_acpetar_bebidas.Size = new System.Drawing.Size(75, 23);
            this.Boton_acpetar_bebidas.TabIndex = 10;
            this.Boton_acpetar_bebidas.Text = "ACEPTAR";
            this.Boton_acpetar_bebidas.UseVisualStyleBackColor = true;
            this.Boton_acpetar_bebidas.Click += new System.EventHandler(this.Boton_acpetar_bebidas_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Articulo";
            this.Nombre.Name = "Nombre";
            // 
            // TipoBebidaColumna
            // 
            this.TipoBebidaColumna.DataPropertyName = "Tipo";
            this.TipoBebidaColumna.HeaderText = "Tipo Bebida";
            this.TipoBebidaColumna.Name = "TipoBebidaColumna";
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
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad Minima";
            // 
            // text_cantminima
            // 
            this.text_cantminima.Location = new System.Drawing.Point(12, 360);
            this.text_cantminima.Name = "text_cantminima";
            this.text_cantminima.Size = new System.Drawing.Size(111, 20);
            this.text_cantminima.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio por unidad";
            // 
            // text_precioUnitario
            // 
            this.text_precioUnitario.Location = new System.Drawing.Point(13, 448);
            this.text_precioUnitario.Name = "text_precioUnitario";
            this.text_precioUnitario.Size = new System.Drawing.Size(100, 20);
            this.text_precioUnitario.TabIndex = 15;
            // 
            // Form_Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 567);
            this.Controls.Add(this.text_precioUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_cantminima);
            this.Controls.Add(this.label4);
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
            this.Load += new System.EventHandler(this.Form_Bebidas_Load);
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
        private System.Windows.Forms.Button Boton_acpetar_bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBebidaColumna;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_cantminima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_precioUnitario;
    }
}