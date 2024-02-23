using hw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw
{
    public partial class FormTaskFour1 : Form
    {
        public FormTaskFour1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            FormTaskFour2 form = new FormTaskFour2();
            form.ShowDialog();
            form.prisv(product);
            listBox1.Items.Add(product.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Product product = new Product();
                FormTaskFour2 form = new FormTaskFour2();
                string element = listBox1.SelectedItem.ToString();
                form.ShowDialog();

                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.Remove(listBox1.SelectedItem);
                form.prisv(product);
                listBox1.Items.Insert(selectedIndex, product.ToString());
            }
            else MessageBox.Show("Выберите элемент");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else MessageBox.Show("Выберите элемент");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "output.txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (object item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                MessageBox.Show("Файл экспортирован");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*)|*.*| Text files(*.txt)|*.txt||";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string filePath = open.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            listBox1.Items.Add(line);
                        }
                    }
                    MessageBox.Show("Данные импортированы из файла");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
