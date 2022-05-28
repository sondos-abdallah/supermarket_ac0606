using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SuperMarket
{

    public class Fruit
    {
        OleDbConnection cn = new OleDbConnection(@" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Desktop\Soso\SuperMarket\supermarket.accdb ");
        OleDbDataAdapter Da;
        DataTable Dt = new DataTable();
        OleDbCommand cmd;
        private double quantity, price;
        private string fruitName;

   
        public void parseDataToDataBase(double quantity,double price,string fruitName) 
        {
          
            double subTotal = quantity * price;
            cmd = new OleDbCommand("Insert Into prod Values('" + fruitName + "','" + price + "','" + quantity + "','" + subTotal + "')", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
           

           

        }

       

    }
}
