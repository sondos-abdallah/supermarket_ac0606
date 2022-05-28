using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5.00";
            textBox2.Text = "3.50";
            textBox3.Text = "2.00";
            textBox4.Text = "2.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0) {  Fruit pinapple = new Fruit();
            pinapple.parseDataToDataBase(Convert.ToDouble(numericUpDown1.Value), Convert.ToDouble(textBox1.Text), "Pinapple");
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
               Fruit apple = new Fruit();
            apple.parseDataToDataBase(Convert.ToDouble(numericUpDown3.Value), Convert.ToDouble(textBox3.Text), "Apple");
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
                Fruit Peach = new Fruit();
                Peach.parseDataToDataBase(Convert.ToDouble(numericUpDown2.Value), Convert.ToDouble(textBox2.Text), "Peach");
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
                Fruit Orange = new Fruit();
                Orange.parseDataToDataBase(Convert.ToDouble(numericUpDown4.Value), Convert.ToDouble(textBox4.Text), "Orange");

                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
