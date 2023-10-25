
using System;
using System.Data;
using System.Data.SqlClient;
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

        private void search_button_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = book.getCon();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM bookingTable WHERE CONCAT (firstName, lastName, address, phoneNum, emailAdd, checkInDate, checkOutDate, roomType, adultsNum, childrenNum, paymentOpt, totalPayment) LIKE '%" + textBox1.Text + "%'", conn);

            rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString(), rd[11].ToString(), rd[12].ToString());
            }
            rd.Close();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = book.getCon();
            conn.Open();

            cmd = new SqlCommand("select * from bookingTable", conn);
            rd = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (rd.Read())
            {
                dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString());
            }
            cmd.Dispose();
            rd.Close();
            conn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = book.getCon();
            conn.Open();
            cmd = new SqlCommand("DELETE * FROM bookingTable WHERE CONCAT (firstName, lastName, address, phoneNum, emailAdd, checkInDate, checkOutDate, roomType, adultsNum, childrenNum, paymentOpt, totalPayment) LIKE '%" + textBox1.Text + "%'", conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString(), rd[11].ToString(), rd[12].ToString());
            }
            rd.Close();
            conn.Close();

        }


        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Database_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'checkInnDataSet.bookingTable' table. You can move, or remove it, as needed.
            this.bookingTableTableAdapter.Fill(this.checkInnDataSet.bookingTable);

        }
    }
}
