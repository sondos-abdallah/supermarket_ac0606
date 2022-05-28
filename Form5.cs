using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0.75";
            textBox2.Text = "1.50";
            textBox3.Text = "2.00";
            textBox4.Text = "4.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                Fruit pinapple = new Fruit();
                pinapple.parseDataToDataBase(Convert.ToDouble(numericUpDown1.Value), Convert.ToDouble(textBox1.Text), "Watermelon");
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0)
            {
                Fruit pinapple = new Fruit();
                pinapple.parseDataToDataBase(Convert.ToDouble(numericUpDown3.Value), Convert.ToDouble(textBox3.Text), "Banana");
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0)
            {
                Fruit pinapple = new Fruit();
                pinapple.parseDataToDataBase(Convert.ToDouble(numericUpDown2.Value), Convert.ToDouble(textBox2.Text), "Kiwi");
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 0)
            {
                Fruit pinapple = new Fruit();
                pinapple.parseDataToDataBase(Convert.ToDouble(numericUpDown4.Value), Convert.ToDouble(textBox4.Text), "Avocado");
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
