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

namespace FinalProject
{
    public partial class Database : Form
    {
        bookingConnect book = new bookingConnect();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rd;
        public Database()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e) //Search
        {
            conn = book.getCon();
            conn.Open();
            String query = "select * from bookingTable where firstName like '%'+@SearchTerm+'%' or lastName like '%'+@SearchTerm+'%' or address like '%'+@SearchTerm+'%' or phoneNum like '%'+@SearchTerm+'%' or emailAdd like '%'+@SearchTerm+'%' or checkInDate like '%'+@SearchTerm+'%' or checkOutDate like '%'+@SearchTerm+'%' or roomType like '%'+@SearchTerm+'%' or adultsNum like '%'+@SearchTerm+'%' or childrenNum like '%'+@SearchTerm+'%' or paymentOpt like '%'+@SearchTerm+'%' or totalPayment like '%'+@SearchTerm+'%'";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@SearchTerm", textBox1.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e) //List All
        {
            conn = book.getCon();
            conn.Open();
            cmd = new SqlCommand("select * from bookingTable", conn);
            rd = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rd.Read())
            {
                object[] rowValues = new object[rd.FieldCount];
                rd.GetValues(rowValues);
                dataGridView1.Rows.Add(rowValues);
            }
            cmd.Dispose();
            rd.Close();
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e) //Cancel
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            selectedRow.Cells["Total"].Value = "CANCELLED";
            cmd = new SqlCommand("update bookingTable SET totalPayment = 'CANCELLED' where"); 
                
                
        }
    }
}
