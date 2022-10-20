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
            // Form_Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver_Bebidas);
            this.Name = "Form_Bebidas";
            this.Text = "Form_Bebidas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_Bebidas;
    }
}