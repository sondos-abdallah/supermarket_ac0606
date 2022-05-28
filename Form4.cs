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

    public partial class Form4 : Form
    {
        OleDbConnection cn = new OleDbConnection(@" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Desktop\Soso\SuperMarket\supermarket.accdb ");
        OleDbDataAdapter Da;
        DataTable Dt = new DataTable();
        OleDbCommand cmd;

        public Form4()
        {
            InitializeComponent();
            FillDatagridView();
        }
        void FillDatagridView()
        {
            Dt.Clear();
            Da = new OleDbDataAdapter("Select * From prod", cn);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;

        }
        private void Form4_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text);
            cmd = new OleDbCommand("Insert Into prod Values('" + textBox1.Text + "','" + Convert.ToDouble(textBox2.Text) + "','" + Convert.ToDouble(textBox3.Text) + "','" + x + "')", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            FillDatagridView();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text);
            cmd = new OleDbCommand("Update prod set [Price] ='" + Convert.ToString(textBox2.Text) + "', [Quantitity] ='" + Convert.ToInt32(textBox3.Text) + "',[SubTotal] ='" + Convert.ToString(x) + "'Where [Product] =@na", cn);
            cmd.Parameters.Add("na", OleDbType.VarChar).Value = textBox1.Text;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            FillDatagridView();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("Updated Successfully ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            cmd = new OleDbCommand("Delete From prod WHERE Product =?", cn);
            cmd.Parameters.Add("Param1", OleDbType.VarChar).Value = textBox1.Text;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            FillDatagridView();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("Deleted Successfully ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

  /*  public class User
    {
        public User(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        private string name, id;

        public string getName()
        {
            return name;
        }

        public string getId()
        {
            return id;
        }
    }
  */
  
}
