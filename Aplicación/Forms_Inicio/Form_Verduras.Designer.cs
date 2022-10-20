namespace Forms_Inicio
{
    partial class Form_Verduras
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
            this.btn_Volver_Verduras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Volver_Verduras
            // 
            this.btn_Volver_Verduras.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_Verduras.Name = "btn_Volver_Verduras";
            this.btn_Volver_Verduras.Size = new System.Drawing.Size(149, 42);
            this.btn_Volver_Verduras.TabIndex = 0;
            this.btn_Volver_Verduras.Text = "Volver";
            this.btn_Volver_Verduras.UseVisualStyleBackColor = true;
            this.btn_Volver_Verduras.Click += new System.EventHandler(this.btn_Volver_Verduras_Click);
            // 
            // Form_Verduras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Volver_Verduras);
            this.Name = "Form_Verduras";
            this.Text = "Form_Verduras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Verduras;
    }
}