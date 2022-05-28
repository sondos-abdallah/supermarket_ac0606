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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form6 f6 = new Form6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(f6);
            f3.SendToBack();
            f6.BringToFront();
            f6.Show();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form3 f3 = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.panel1.Controls.Add(f3);
            f1.SendToBack();
            f3.BringToFront();
            f3.Show();

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form3 f3 = new Form3();
            Form4 f4 = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.panel1.Controls.Add(f4);
            f1.SendToBack();
            f3.SendToBack();
            f4.BringToFront();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            UserName.Text = Form1.username;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form5 f5 = new Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(f5);
            f3.SendToBack();

            f5.BringToFront();
            f5.Show();
        }
    }
}
