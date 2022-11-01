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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_NuevaReceta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver_Recetas
            // 
            this.btn_Volver_Recetas.Location = new System.Drawing.Point(13, 13);
            this.btn_Volver_Recetas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Volver_Recetas.Name = "btn_Volver_Recetas";
            this.btn_Volver_Recetas.Size = new System.Drawing.Size(136, 52);
            this.btn_Volver_Recetas.TabIndex = 7;
            this.btn_Volver_Recetas.Text = "Volver";
            this.btn_Volver_Recetas.UseVisualStyleBackColor = true;
            this.btn_Volver_Recetas.Click += new System.EventHandler(this.btn_Volver_Recetas_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 311);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_NuevaReceta
            // 
            this.btn_NuevaReceta.AutoSize = true;
            this.btn_NuevaReceta.Location = new System.Drawing.Point(168, 14);
            this.btn_NuevaReceta.Name = "btn_NuevaReceta";
            this.btn_NuevaReceta.Size = new System.Drawing.Size(136, 50);
            this.btn_NuevaReceta.TabIndex = 9;
            this.btn_NuevaReceta.Text = "Nueva receta";
            this.btn_NuevaReceta.UseVisualStyleBackColor = true;
            this.btn_NuevaReceta.Click += new System.EventHandler(this.btn_NuevaReceta_Click);
            // 
            // Form_Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_NuevaReceta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Volver_Recetas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Recetas";
            this.Text = "Form_Recetas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Recetas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_NuevaReceta;
    }
}