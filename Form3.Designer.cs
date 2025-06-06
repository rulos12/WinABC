namespace WinABC
{
    partial class Marca
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
            this.textName = new System.Windows.Forms.TextBox();
            this.subT2 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.tituloMarca = new System.Windows.Forms.Label();
            this.tablaMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(336, 366);
            this.textName.Margin = new System.Windows.Forms.Padding(5);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(314, 33);
            this.textName.TabIndex = 14;
            // 
            // subT2
            // 
            this.subT2.AutoSize = true;
            this.subT2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subT2.Location = new System.Drawing.Point(330, 301);
            this.subT2.Name = "subT2";
            this.subT2.Size = new System.Drawing.Size(136, 35);
            this.subT2.TabIndex = 13;
            this.subT2.Text = "Nombre";
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.LightGreen;
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.Location = new System.Drawing.Point(336, 528);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(151, 54);
            this.enviar.TabIndex = 10;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = false;
            // 
            // tituloMarca
            // 
            this.tituloMarca.AutoSize = true;
            this.tituloMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMarca.Location = new System.Drawing.Point(322, 71);
            this.tituloMarca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tituloMarca.Name = "tituloMarca";
            this.tituloMarca.Size = new System.Drawing.Size(229, 79);
            this.tituloMarca.TabIndex = 9;
            this.tituloMarca.Text = "Marca";
            // 
            // tablaMarca
            // 
            this.tablaMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMarca.Location = new System.Drawing.Point(809, 326);
            this.tablaMarca.Name = "tablaMarca";
            this.tablaMarca.Size = new System.Drawing.Size(321, 130);
            this.tablaMarca.TabIndex = 15;
            this.tablaMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMarca_CellContentClick);
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tablaMarca);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.subT2);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.tituloMarca);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Marca";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label subT2;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label tituloMarca;
        private System.Windows.Forms.DataGridView tablaMarca;
    }
}