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

namespace WinABC
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data source= DESKTOP-KDR2J27;Initial Catalog=Furniture;Integrated security=true");
            SqlDataAdapter daProductos = new SqlDataAdapter("Select p.idProducto, p.descripcion, p.cantidad, m.nombre, pv.razonSocial from producto p join marca m on p.idMarca=m.idMarca join proveedor pv on p.idProveedor = pv.idProveedor", cn);
            SqlDataAdapter daMarcas = new SqlDataAdapter("Select idMarca, nombre from marca", cn);
            SqlDataAdapter daProveedores = new SqlDataAdapter("Select idProveedor, razonSocial from proveedor", cn);

            DataSet dsProductos = new DataSet();

            try
            {

                daProductos.Fill(dsProductos, "Productos"); //se puede indicar el nombre con el que se identifica el conjunto de datos
                daMarcas.Fill(dsProductos, "Marcas"); //se puede indicar el nombre con el que se identifica el conjunto de datos
                daProveedores.Fill(dsProductos, "Proveedores"); //se puede indicar el nombre con el que se identifica el conjunto de datos

                this.tablaProducto.DataSource = dsProductos.Tables["Productos"]; ///se le pasan los datos al controlador dataGridView
                this.cboMarca.DataSource = dsProductos.Tables["Marcas"];
                this.cboMarca.DisplayMember = "nombre";
                this.cboMarca.ValueMember = "idMarca";

                this.cboProveedor.DataSource = dsProductos.Tables["Proveedores"];
                this.cboProveedor.DisplayMember = "razonSocial";
                this.cboProveedor.ValueMember = "idProveedor";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tablaProducto_DoubleClick(object sender, EventArgs e)
        {
            this.textDest.Text = this.tablaProducto.CurrentRow.Cells["descripcion"].Value.ToString();
            this.cantidad.Text = this.tablaProducto.CurrentRow.Cells["cantidad"].Value.ToString();
            this.cboMarca.Text = this.tablaProducto.CurrentRow.Cells["nombre"].Value.ToString();
            this.cboProveedor.Text = this.tablaProducto.CurrentRow.Cells["razonSocial"].Value.ToString();

        }
    }
}
