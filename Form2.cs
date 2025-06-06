using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace WinABC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data source= DESKTOP-KDR2J27;Initial Catalog=Furniture;Integrated security=true");
            SqlDataAdapter daProveedores = new SqlDataAdapter("Select * from proveedor", cn);
            DataSet dsProductos = new DataSet();


            try
            {

                 daProveedores.Fill(dsProductos, "Proveedores"); //se puede indicar el nombre con el que se identifica el conjunto de datos

              this.tablaProveedor.DataSource = dsProductos.Tables["Proveedores"]; ///se le pasan los datos al controlador dataGridView

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tablaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textRazonS.Text = this.tablaProveedor.CurrentRow.Cells["razonSocial"].Value.ToString();
            this.textRfc.Text = this.tablaProveedor.CurrentRow.Cells["rfc"].Value.ToString();
            this.textAddress.Text = this.tablaProveedor.CurrentRow.Cells["domicilio"].Value.ToString();
        }
    }
}
