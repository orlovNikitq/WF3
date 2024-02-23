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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTaskOne form = new FormTaskOne();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTaskTwo form = new FormTaskTwo();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTaskThree form = new FormTaskThree();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTaskFour1 form = new FormTaskFour1();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
