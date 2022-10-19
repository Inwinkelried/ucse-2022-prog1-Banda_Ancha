namespace Forms_Inicio
{
    partial class Form_Menú
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
            this.btn_Despensa = new System.Windows.Forms.Button();
            this.btn_Recetas = new System.Windows.Forms.Button();
            this.btn_Super = new System.Windows.Forms.Button();
            this.btn_Comidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Despensa
            // 
            this.btn_Despensa.Location = new System.Drawing.Point(121, 65);
            this.btn_Despensa.Name = "btn_Despensa";
            this.btn_Despensa.Size = new System.Drawing.Size(154, 136);
            this.btn_Despensa.TabIndex = 0;
            this.btn_Despensa.Text = "button1";
            this.btn_Despensa.UseVisualStyleBackColor = true;
            this.btn_Despensa.Click += new System.EventHandler(this.btn_Despensa_Click);
            // 
            // btn_Recetas
            // 
            this.btn_Recetas.Location = new System.Drawing.Point(383, 65);
            this.btn_Recetas.Name = "btn_Recetas";
            this.btn_Recetas.Size = new System.Drawing.Size(154, 136);
            this.btn_Recetas.TabIndex = 1;
            this.btn_Recetas.Text = "button2";
            this.btn_Recetas.UseVisualStyleBackColor = true;
            this.btn_Recetas.Click += new System.EventHandler(this.btn_Recetas_Click);
            // 
            // btn_Super
            // 
            this.btn_Super.Location = new System.Drawing.Point(121, 261);
            this.btn_Super.Name = "btn_Super";
            this.btn_Super.Size = new System.Drawing.Size(154, 136);
            this.btn_Super.TabIndex = 2;
            this.btn_Super.Text = "button3";
            this.btn_Super.UseVisualStyleBackColor = true;
            this.btn_Super.Click += new System.EventHandler(this.btn_Super_Click);
            // 
            // btn_Comidas
            // 
            this.btn_Comidas.Location = new System.Drawing.Point(383, 261);
            this.btn_Comidas.Name = "btn_Comidas";
            this.btn_Comidas.Size = new System.Drawing.Size(154, 136);
            this.btn_Comidas.TabIndex = 3;
            this.btn_Comidas.Text = "button4";
            this.btn_Comidas.UseVisualStyleBackColor = true;
            this.btn_Comidas.Click += new System.EventHandler(this.btn_Comidas_Click);
            // 
            // Form_Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 473);
            this.Controls.Add(this.btn_Comidas);
            this.Controls.Add(this.btn_Super);
            this.Controls.Add(this.btn_Recetas);
            this.Controls.Add(this.btn_Despensa);
            this.Name = "Form_Menú";
            this.Text = "Form_Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Despensa;
        private System.Windows.Forms.Button btn_Recetas;
        private System.Windows.Forms.Button btn_Super;
        private System.Windows.Forms.Button btn_Comidas;
    }
}