namespace Proyecto_Estadistica
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMinimosCuadrados = new System.Windows.Forms.Button();
            this.BrnRegresionLineal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMinimosCuadrados
            // 
            this.BtnMinimosCuadrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimosCuadrados.Location = new System.Drawing.Point(6, 36);
            this.BtnMinimosCuadrados.Name = "BtnMinimosCuadrados";
            this.BtnMinimosCuadrados.Size = new System.Drawing.Size(87, 43);
            this.BtnMinimosCuadrados.TabIndex = 2;
            this.BtnMinimosCuadrados.Text = "Minimos Cuadrados";
            this.BtnMinimosCuadrados.UseVisualStyleBackColor = true;
            this.BtnMinimosCuadrados.Click += new System.EventHandler(this.BtnMinimosCuadrados_Click);
            // 
            // BrnRegresionLineal
            // 
            this.BrnRegresionLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrnRegresionLineal.Location = new System.Drawing.Point(117, 36);
            this.BrnRegresionLineal.Name = "BrnRegresionLineal";
            this.BrnRegresionLineal.Size = new System.Drawing.Size(87, 43);
            this.BrnRegresionLineal.TabIndex = 3;
            this.BrnRegresionLineal.Text = "Regresion Lineal";
            this.BrnRegresionLineal.UseVisualStyleBackColor = true;
            this.BrnRegresionLineal.Click += new System.EventHandler(this.BrnRegresionLineal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "MODELOS DE REGRESION ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMinimosCuadrados);
            this.groupBox1.Controls.Add(this.BrnRegresionLineal);
            this.groupBox1.Location = new System.Drawing.Point(115, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelos de Regresion Simple";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMinimosCuadrados;
        private System.Windows.Forms.Button BrnRegresionLineal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

