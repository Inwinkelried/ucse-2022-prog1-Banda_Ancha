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
            // Form_Panaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver_Panaderia);
            this.Name = "Form_Panaderia";
            this.Text = "Form_Panaderia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_Panaderia;
    }
}