
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void button3_Click(object sender, EventArgs e) //Cancel Booking
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(selectedIndex);

                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

                conn = book.getCon();
                conn.Open();
                cmd = new SqlCommand("DELETE FROM bookingTable WHERE bookingID = " + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int selectedIndex = e.RowIndex;

                dataGridView1.Rows.RemoveAt(selectedIndex);

                conn = book.getCon();
                conn.Open();
                cmd = new SqlCommand("DELETE FROM bookingTable WHERE CONCAT (firstName, lastName, address, phoneNum, emailAdd, checkInDate, checkOutDate, roomType, adultsNum, childrenNum, paymentOpt, totalPayment) LIKE '%" + textBox1.Text + "%'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void Database_Load_1(object sender, EventArgs e)
        {
            
            this.bookingTableTableAdapter.Fill(this.checkInnDataSet.bookingTable);

        }
        private void button4_Click(object sender, EventArgs e) //Update
        {
            
        }



        private void button2_Click(object sender, EventArgs e) //Check Out
        {
            // Retrieve the selected row in the DataGridView
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Set the ReadOnly property of the row to true
            selectedRow.ReadOnly = true;
        }

        private void edit_button_Click(object sender, EventArgs e) //Edit
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Please select a cell to edit");
            }
        }
    }
}
