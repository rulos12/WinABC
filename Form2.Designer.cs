namespace WinABC
{
    partial class Form2
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
            this.tituloProve = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.subT1 = new System.Windows.Forms.Label();
            this.textRazonS = new System.Windows.Forms.TextBox();
            this.subT2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textRfc = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.tablaProveedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloProve
            // 
            this.tituloProve.AutoSize = true;
            this.tituloProve.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloProve.Location = new System.Drawing.Point(112, 69);
            this.tituloProve.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tituloProve.Name = "tituloProve";
            this.tituloProve.Size = new System.Drawing.Size(441, 79);
            this.tituloProve.TabIndex = 0;
            this.tituloProve.Text = "Proveedores";
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.LightGreen;
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.Location = new System.Drawing.Point(130, 476);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(151, 54);
            this.enviar.TabIndex = 1;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = false;
            // 
            // subT1
            // 
            this.subT1.AutoSize = true;
            this.subT1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subT1.Location = new System.Drawing.Point(120, 207);
            this.subT1.Name = "subT1";
            this.subT1.Size = new System.Drawing.Size(208, 35);
            this.subT1.TabIndex = 4;
            this.subT1.Text = "Razon social";
            // 
            // textRazonS
            // 
            this.textRazonS.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRazonS.Location = new System.Drawing.Point(126, 260);
            this.textRazonS.Margin = new System.Windows.Forms.Padding(5);
            this.textRazonS.Name = "textRazonS";
            this.textRazonS.Size = new System.Drawing.Size(518, 33);
            this.textRazonS.TabIndex = 5;
            // 
            // subT2
            // 
            this.subT2.AutoSize = true;
            this.subT2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subT2.Location = new System.Drawing.Point(766, 207);
            this.subT2.Name = "subT2";
            this.subT2.Size = new System.Drawing.Size(75, 35);
            this.subT2.TabIndex = 6;
            this.subT2.Text = "RFC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Domicilio";
            // 
            // textRfc
            // 
            this.textRfc.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRfc.Location = new System.Drawing.Point(772, 257);
            this.textRfc.Margin = new System.Windows.Forms.Padding(5);
            this.textRfc.Name = "textRfc";
            this.textRfc.Size = new System.Drawing.Size(381, 33);
            this.textRfc.TabIndex = 8;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(126, 384);
            this.textAddress.Margin = new System.Windows.Forms.Padding(5);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(575, 33);
            this.textAddress.TabIndex = 9;
            // 
            // tablaProveedor
            // 
            this.tablaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProveedor.Location = new System.Drawing.Point(494, 485);
            this.tablaProveedor.Name = "tablaProveedor";
            this.tablaProveedor.Size = new System.Drawing.Size(492, 196);
            this.tablaProveedor.TabIndex = 10;
            this.tablaProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProveedor_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tablaProveedor);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textRfc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subT2);
            this.Controls.Add(this.textRazonS);
            this.Controls.Add(this.subT1);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.tituloProve);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloProve;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label subT1;
        private System.Windows.Forms.TextBox textRazonS;
        private System.Windows.Forms.Label subT2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRfc;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.DataGridView tablaProveedor;
    }
}