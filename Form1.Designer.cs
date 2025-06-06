namespace WinABC
{
    partial class FormProd
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
            this.enviar = new System.Windows.Forms.Button();
            this.tituloProve = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.LightGreen;
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.Location = new System.Drawing.Point(176, 263);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(254, 134);
            this.enviar.TabIndex = 11;
            this.enviar.Text = "Agregar Producto";
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // tituloProve
            // 
            this.tituloProve.AutoSize = true;
            this.tituloProve.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloProve.Location = new System.Drawing.Point(529, 88);
            this.tituloProve.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tituloProve.Name = "tituloProve";
            this.tituloProve.Size = new System.Drawing.Size(359, 79);
            this.tituloProve.TabIndex = 10;
            this.tituloProve.Text = "Productos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(563, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 134);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar marcar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(954, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 134);
            this.button2.TabIndex = 17;
            this.button2.Text = "Agregar proveedor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.tituloProve);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormProd";
            this.Text = "Producto";
//            this.Load += new System.EventHandler(this.FormProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label tituloProve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

