namespace Forms_Inicio
{
    partial class Form_Recetas
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
            this.btn_Volver_Recetas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Volver_Recetas
            // 
            this.btn_Volver_Recetas.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_Recetas.Name = "btn_Volver_Recetas";
            this.btn_Volver_Recetas.Size = new System.Drawing.Size(102, 42);
            this.btn_Volver_Recetas.TabIndex = 7;
            this.btn_Volver_Recetas.Text = "Volver";
            this.btn_Volver_Recetas.UseVisualStyleBackColor = true;
            this.btn_Volver_Recetas.Click += new System.EventHandler(this.btn_Volver_Recetas_Click_1);
            // 
            // Form_Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Volver_Recetas);
            this.Name = "Form_Recetas";
            this.Text = "Form_Recetas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Recetas;
    }
}