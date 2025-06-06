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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data source= DESKTOP-KDR2J27;Initial Catalog=Furniture;Integrated security=true");
            SqlDataAdapter daMarcas = new SqlDataAdapter("Select idMarca, nombre from marca", cn);

            DataSet dsProductos = new DataSet();

            try
            {

                daMarcas.Fill(dsProductos, "Marcas"); //se puede indicar el nombre con el que se identifica el conjunto de datos

                this.tablaMarca.DataSource = dsProductos.Tables["Marcas"]; ///se le pasan los datos al controlador dataGridView
          
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tablaMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textName.Text = this.tablaMarca.CurrentRow.Cells["nombre"].Value.ToString();
        }
    }
}
