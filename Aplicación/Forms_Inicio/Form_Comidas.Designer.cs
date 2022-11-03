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
            this.btn_Volver_Comidas = new System.Windows.Forms.Button();
            this.grilla_Comidas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecetaPreparada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Comidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver_Comidas
            // 
            this.btn_Volver_Comidas.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver_Comidas.Name = "btn_Volver_Comidas";
            this.btn_Volver_Comidas.Size = new System.Drawing.Size(115, 43);
            this.btn_Volver_Comidas.TabIndex = 1;
            this.btn_Volver_Comidas.Text = "Volver";
            this.btn_Volver_Comidas.UseVisualStyleBackColor = true;
            this.btn_Volver_Comidas.Click += new System.EventHandler(this.btn_Volver_Comidas_Click);
            // 
            // grilla_Comidas
            // 
            this.grilla_Comidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_Comidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.RecetaPreparada});
            this.grilla_Comidas.Location = new System.Drawing.Point(435, 12);
            this.grilla_Comidas.Name = "grilla_Comidas";
            this.grilla_Comidas.Size = new System.Drawing.Size(241, 434);
            this.grilla_Comidas.TabIndex = 2;
            this.grilla_Comidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_Comidas_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // RecetaPreparada
            // 
            this.RecetaPreparada.HeaderText = "Receta Preparada";
            this.RecetaPreparada.Name = "RecetaPreparada";
            // 
            // Form_Comidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 458);
            this.Controls.Add(this.grilla_Comidas);
            this.Controls.Add(this.btn_Volver_Comidas);
            this.Name = "Form_Comidas";
            this.Text = "Form_Comidas";
            this.Load += new System.EventHandler(this.Form_Comidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_Comidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver_Comidas;
        private System.Windows.Forms.DataGridView grilla_Comidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecetaPreparada;
    }
}