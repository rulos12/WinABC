using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WinABC
{
    public partial class FormProd : Form
    {
        Form4 formProduc;
        Marca formMarca;
        Form2 formProvee;
        public FormProd()
        {
            InitializeComponent();
            
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics(); //se puede acceder a los metodos de dibujo 

            Pen lapiz = new Pen(Color.Black, 5);
            
            g.DrawEllipse(lapiz,100,100,200,100);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 

            Pen lapiz = new Pen(Color.DarkGreen, 5);

            g.DrawEllipse(lapiz, 100, 250, 200, 100);
        }*/

      /*private void button1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Hola ");
        }*/

        

        private void enviar_Click(object sender, EventArgs e)
        {
            // form2.Show();

            formProduc = new Form4();
            formProduc.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formMarca = new Marca();
            formMarca.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formProvee = new Form2();
            formProvee.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

       
    }
}
