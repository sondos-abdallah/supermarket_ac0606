using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public class User
    {
        private string userName;
        private string id;
        User(string userName, string id)
        {
            this.userName = userName;
            this.id = id;
        }
        public string getName()
            {
            return userName;
        }
        public string getId() 
        {
            return id;
        }

        
    }       
}
