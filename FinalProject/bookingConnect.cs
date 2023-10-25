using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace FinalProject
{
    class bookingConnect
    {
        SqlConnection conn;
        public SqlConnection getCon() //connection between program and database
        {
            conn = new SqlConnection("Data Source=IjedLuzele\\SQLEXPRESS;Initial Catalog=CheckInn;Integrated Security=True");
            return conn;
        }

    }
}
