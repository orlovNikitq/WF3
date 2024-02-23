using hw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw
{
    public partial class FormTaskFour2 : Form
    {
        Product product = new Product();
        public FormTaskFour2()
        {
            InitializeComponent();
        }
        public void prisv(Product prod)
        {
            product = prod;
            prod.name = textBox1.Text;
            prod.country = textBox2.Text;
            prod.price = textBox3.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                prisv(product);
                this.Close();
            }
            else MessageBox.Show("Введите все значения");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
