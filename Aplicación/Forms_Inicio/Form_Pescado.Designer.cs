namespace Forms_Inicio
{
    partial class Form_Pescado
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
            this.btn_volver_Pescado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_nomprod_pescado = new System.Windows.Forms.TextBox();
            this.txtbx_Cantidad_Pescado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Pescado = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pescado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver_Pescado
            // 
            this.btn_volver_Pescado.Location = new System.Drawing.Point(23, 22);
            this.btn_volver_Pescado.Name = "btn_volver_Pescado";
            this.btn_volver_Pescado.Size = new System.Drawing.Size(104, 41);
            this.btn_volver_Pescado.TabIndex = 0;
            this.btn_volver_Pescado.Text = "Volver";
            this.btn_volver_Pescado.UseVisualStyleBackColor = true;
            this.btn_volver_Pescado.Click += new System.EventHandler(this.btn_volver_Pescado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un producto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // txtbx_nomprod_pescado
            // 
            this.txtbx_nomprod_pescado.Location = new System.Drawing.Point(23, 208);
            this.txtbx_nomprod_pescado.Name = "txtbx_nomprod_pescado";
            this.txtbx_nomprod_pescado.Size = new System.Drawing.Size(100, 20);
            this.txtbx_nomprod_pescado.TabIndex = 4;
            // 
            // txtbx_Cantidad_Pescado
            // 
            this.txtbx_Cantidad_Pescado.Location = new System.Drawing.Point(23, 281);
            this.txtbx_Cantidad_Pescado.Name = "txtbx_Cantidad_Pescado";
            this.txtbx_Cantidad_Pescado.Size = new System.Drawing.Size(100, 20);
            this.txtbx_Cantidad_Pescado.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "KG";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Pescado
            // 
            this.dataGridView_Pescado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pescado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Nombre});
            this.dataGridView_Pescado.Location = new System.Drawing.Point(250, 22);
            this.dataGridView_Pescado.Name = "dataGridView_Pescado";
            this.dataGridView_Pescado.Size = new System.Drawing.Size(243, 519);
            this.dataGridView_Pescado.TabIndex = 8;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad en stock";
            this.Cantidad.Name = "Cantidad";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Form_Pescado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 553);
            this.Controls.Add(this.dataGridView_Pescado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_Cantidad_Pescado);
            this.Controls.Add(this.txtbx_nomprod_pescado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volver_Pescado);
            this.Name = "Form_Pescado";
            this.Text = "Form_Pescado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pescado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver_Pescado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_nomprod_pescado;
        private System.Windows.Forms.TextBox txtbx_Cantidad_Pescado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Pescado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}