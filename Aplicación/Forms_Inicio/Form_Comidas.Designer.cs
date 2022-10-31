namespace Forms_Inicio
{
    partial class Form_Comidas
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
            this.btn_Volver_comidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Volver_comidas
            // 
            this.btn_Volver_comidas.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_comidas.Name = "btn_Volver_comidas";
            this.btn_Volver_comidas.Size = new System.Drawing.Size(106, 37);
            this.btn_Volver_comidas.TabIndex = 0;
            this.btn_Volver_comidas.Text = "Volver";
            this.btn_Volver_comidas.UseVisualStyleBackColor = true;
            this.btn_Volver_comidas.Click += new System.EventHandler(this.btn_Volver_comidas_Click);
            // 
            // Form_Comidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Volver_comidas);
            this.Name = "Form_Comidas";
            this.Text = "Form_Comidas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_comidas;
    }
}