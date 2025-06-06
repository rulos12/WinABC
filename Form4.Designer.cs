namespace WinABC
{
    partial class Form4
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
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subT2 = new System.Windows.Forms.Label();
            this.textDest = new System.Windows.Forms.TextBox();
            this.subT1 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.tituloProve = new System.Windows.Forms.Label();
            this.tablaProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(893, 269);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(120, 33);
            this.cantidad.TabIndex = 30;
            this.cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboProveedor
            // 
            this.cboProveedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(765, 390);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(121, 34);
            this.cboProveedor.TabIndex = 29;
            // 
            // cboMarca
            // 
            this.cboMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(191, 394);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 34);
            this.cboMarca.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Proveedor";
            // 
            // subT2
            // 
            this.subT2.AutoSize = true;
            this.subT2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subT2.Location = new System.Drawing.Point(47, 391);
            this.subT2.Name = "subT2";
            this.subT2.Size = new System.Drawing.Size(116, 35);
            this.subT2.TabIndex = 25;
            this.subT2.Text = "Marca ";
            // 
            // textDest
            // 
            this.textDest.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDest.Location = new System.Drawing.Point(53, 265);
            this.textDest.Name = "textDest";
            this.textDest.Size = new System.Drawing.Size(575, 33);
            this.textDest.TabIndex = 24;
            // 
            // subT1
            // 
            this.subT1.AutoSize = true;
            this.subT1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subT1.Location = new System.Drawing.Point(47, 212);
            this.subT1.Name = "subT1";
            this.subT1.Size = new System.Drawing.Size(194, 35);
            this.subT1.TabIndex = 23;
            this.subT1.Text = "Descripción";
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.LightGreen;
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.Location = new System.Drawing.Point(53, 525);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(151, 54);
            this.enviar.TabIndex = 22;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = false;
            // 
            // tituloProve
            // 
            this.tituloProve.AutoSize = true;
            this.tituloProve.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloProve.Location = new System.Drawing.Point(39, 57);
            this.tituloProve.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tituloProve.Name = "tituloProve";
            this.tituloProve.Size = new System.Drawing.Size(325, 79);
            this.tituloProve.TabIndex = 21;
            this.tituloProve.Text = "Producto";
            // 
            // tablaProducto
            // 
            this.tablaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProducto.Location = new System.Drawing.Point(637, 519);
            this.tablaProducto.Name = "tablaProducto";
            this.tablaProducto.Size = new System.Drawing.Size(548, 166);
            this.tablaProducto.TabIndex = 31;
            this.tablaProducto.DoubleClick += new System.EventHandler(this.tablaProducto_DoubleClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tablaProducto);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subT2);
            this.Controls.Add(this.textDest);
            this.Controls.Add(this.subT1);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.tituloProve);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subT2;
        private System.Windows.Forms.TextBox textDest;
        private System.Windows.Forms.Label subT1;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label tituloProve;
        private System.Windows.Forms.DataGridView tablaProducto;
    }
}