namespace Forms_Inicio
{
    partial class Form_Frutas
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
            this.btn_volver_frutas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volver_frutas
            // 
            this.btn_volver_frutas.Location = new System.Drawing.Point(40, 43);
            this.btn_volver_frutas.Name = "btn_volver_frutas";
            this.btn_volver_frutas.Size = new System.Drawing.Size(129, 45);
            this.btn_volver_frutas.TabIndex = 0;
            this.btn_volver_frutas.Text = "Volver";
            this.btn_volver_frutas.UseVisualStyleBackColor = true;
            this.btn_volver_frutas.Click += new System.EventHandler(this.btn_volver_frutas_Click);
            // 
            // Form_Frutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver_frutas);
            this.Name = "Form_Frutas";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_frutas;
    }
}