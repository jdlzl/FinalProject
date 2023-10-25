using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class Login_Form : Form
    {
        bookingConnect book = new bookingConnect();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rd;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox2.Text == "1234")
            {
                // Create a new instance of the Database form
                conn = book.getCon();
                conn.Open();
                Database db = new Database();

                // Clear datasource of DataGridView to prevent error
                db.dataGridView1.DataSource = null;

                // Clear and refresh the rows of the DataGridView control
                db.dataGridView1.Rows.Clear();
                db.dataGridView1.Refresh();

                // Retrieve all the records from the bookingTable and add them one by one as new rows to the DataGridView control
                conn = book.getCon();
                conn.Open();
                cmd = new SqlCommand("select * from bookingTable", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    object[] rowValues = new object[rd.FieldCount];
                    rd.GetValues(rowValues);
                    db.dataGridView1.Rows.Add(rowValues);
                }
                cmd.Dispose();
                rd.Close();
                conn.Close();

                // Show the Database form and hide the Booking form
                db.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Wrong password!");
            }
        }
    }
}
