namespace Forms_Inicio
{
    partial class Form_Despensa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Despensa));
            this.btn_bebidas = new System.Windows.Forms.Button();
            this.btn_Frutas = new System.Windows.Forms.Button();
            this.btn_Carnes = new System.Windows.Forms.Button();
            this.btn_Pescado = new System.Windows.Forms.Button();
            this.btn_pan = new System.Windows.Forms.Button();
            this.btn_Verduras = new System.Windows.Forms.Button();
            this.btn_Volver_Despensa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bebidas
            // 
            this.btn_bebidas.Image = ((System.Drawing.Image)(resources.GetObject("btn_bebidas.Image")));
            this.btn_bebidas.Location = new System.Drawing.Point(160, 108);
            this.btn_bebidas.Name = "btn_bebidas";
            this.btn_bebidas.Size = new System.Drawing.Size(146, 146);
            this.btn_bebidas.TabIndex = 0;
            this.btn_bebidas.UseVisualStyleBackColor = true;
            this.btn_bebidas.Click += new System.EventHandler(this.btn_bebidas_Click);
            // 
            // btn_Frutas
            // 
            this.btn_Frutas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Frutas.Image")));
            this.btn_Frutas.Location = new System.Drawing.Point(367, 281);
            this.btn_Frutas.Name = "btn_Frutas";
            this.btn_Frutas.Size = new System.Drawing.Size(146, 146);
            this.btn_Frutas.TabIndex = 1;
            this.btn_Frutas.UseVisualStyleBackColor = true;
            this.btn_Frutas.Click += new System.EventHandler(this.btn_Frutas_Click);
            // 
            // btn_Carnes
            // 
            this.btn_Carnes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Carnes.Image")));
            this.btn_Carnes.Location = new System.Drawing.Point(367, 108);
            this.btn_Carnes.Name = "btn_Carnes";
            this.btn_Carnes.Size = new System.Drawing.Size(146, 146);
            this.btn_Carnes.TabIndex = 2;
            this.btn_Carnes.UseVisualStyleBackColor = true;
            this.btn_Carnes.Click += new System.EventHandler(this.btn_Carnes_Click);
            // 
            // btn_Pescado
            // 
            this.btn_Pescado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pescado.Image")));
            this.btn_Pescado.Location = new System.Drawing.Point(592, 108);
            this.btn_Pescado.Name = "btn_Pescado";
            this.btn_Pescado.Size = new System.Drawing.Size(152, 146);
            this.btn_Pescado.TabIndex = 3;
            this.btn_Pescado.UseVisualStyleBackColor = true;
            this.btn_Pescado.Click += new System.EventHandler(this.btn_Pescado_Click);
            // 
            // btn_pan
            // 
            this.btn_pan.Image = ((System.Drawing.Image)(resources.GetObject("btn_pan.Image")));
            this.btn_pan.Location = new System.Drawing.Point(160, 292);
            this.btn_pan.Name = "btn_pan";
            this.btn_pan.Size = new System.Drawing.Size(146, 146);
            this.btn_pan.TabIndex = 4;
            this.btn_pan.UseVisualStyleBackColor = true;
            this.btn_pan.Click += new System.EventHandler(this.btn_pan_Click);
            // 
            // btn_Verduras
            // 
            this.btn_Verduras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Verduras.Image")));
            this.btn_Verduras.Location = new System.Drawing.Point(592, 281);
            this.btn_Verduras.Name = "btn_Verduras";
            this.btn_Verduras.Size = new System.Drawing.Size(146, 146);
            this.btn_Verduras.TabIndex = 5;
            this.btn_Verduras.UseVisualStyleBackColor = true;
            this.btn_Verduras.Click += new System.EventHandler(this.btn_Verduras_Click);
            // 
            // btn_Volver_Despensa
            // 
            this.btn_Volver_Despensa.Location = new System.Drawing.Point(12, 108);
            this.btn_Volver_Despensa.Name = "btn_Volver_Despensa";
            this.btn_Volver_Despensa.Size = new System.Drawing.Size(102, 42);
            this.btn_Volver_Despensa.TabIndex = 6;
            this.btn_Volver_Despensa.Text = "Volver";
            this.btn_Volver_Despensa.UseVisualStyleBackColor = true;
            this.btn_Volver_Despensa.Click += new System.EventHandler(this.btn_Volver_Despensa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 68);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Despensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Volver_Despensa);
            this.Controls.Add(this.btn_Verduras);
            this.Controls.Add(this.btn_pan);
            this.Controls.Add(this.btn_Pescado);
            this.Controls.Add(this.btn_Carnes);
            this.Controls.Add(this.btn_Frutas);
            this.Controls.Add(this.btn_bebidas);
            this.Name = "Form_Despensa";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bebidas;
        private System.Windows.Forms.Button btn_Frutas;
        private System.Windows.Forms.Button btn_Carnes;
        private System.Windows.Forms.Button btn_Pescado;
        private System.Windows.Forms.Button btn_pan;
        private System.Windows.Forms.Button btn_Verduras;
        private System.Windows.Forms.Button btn_Volver_Despensa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}