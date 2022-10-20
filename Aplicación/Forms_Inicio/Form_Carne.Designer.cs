namespace Forms_Inicio
{
    partial class Form_Carne
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
            this.btn_volver_Carnes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volver_Carnes
            // 
            this.btn_volver_Carnes.Location = new System.Drawing.Point(26, 31);
            this.btn_volver_Carnes.Name = "btn_volver_Carnes";
            this.btn_volver_Carnes.Size = new System.Drawing.Size(120, 45);
            this.btn_volver_Carnes.TabIndex = 0;
            this.btn_volver_Carnes.Text = "Volver";
            this.btn_volver_Carnes.UseVisualStyleBackColor = true;
            this.btn_volver_Carnes.Click += new System.EventHandler(this.btn_volver_Carnes_Click);
            // 
            // Form_Carne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver_Carnes);
            this.Name = "Form_Carne";
            this.Text = "Form_Carne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_Carnes;
    }
}