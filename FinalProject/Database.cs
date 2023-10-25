
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


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
        public void showData()
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
        private void button4_Click(object sender, EventArgs e) //Update
        {
            conn = book.getCon();
            conn.Open();

            String selectedRoom = "";
            if (singleRoom.Checked)
                selectedRoom = singleRoom.Text;
            else if (twinRoom.Checked)
                selectedRoom = twinRoom.Text;
            else if (familyRoom.Checked)
                selectedRoom = familyRoom.Text;
            String selectedPayOpt = "";
            if (drcrcard.Checked)
                selectedPayOpt = drcrcard.Text;
            else if (gcash.Checked)
                selectedPayOpt = gcash.Text;

            SqlCommand cmd = new SqlCommand("UPDATE bookingTable SET firstName='" + fNameTextbox.Text + "', lastName='" + lNameTextbox.Text + "', address='" + addTextbox.Text + "', phoneNum='" + phoneTextbox.Text + "', emailAdd='" + emailTextbox.Text + "', checkInDate=@checkIn, checkOutDate=@checkOut, roomType ='" + selectedRoom +"', adultsNum='" + adultsTextbox.Text + "', childrenNum='" + childrenTextbox.Text + "', paymentOpt='"+selectedPayOpt+"', totalPayment='" + totalAmountText.Text + "' WHERE bookingID=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(idTextbox.Text));
            cmd.Parameters.AddWithValue("@checkIn", checkinDate.Value);
            cmd.Parameters.AddWithValue("@checkOut", checkoutDate.Value);
       
            cmd.ExecuteNonQuery();
            conn.Close();
            showData();

            idTextbox.Text = "";
            fNameTextbox.Text = "";
            lNameTextbox.Text = "";
            addTextbox.Text = "";
            phoneTextbox.Text = "";
            emailTextbox.Text = "";
            adultsTextbox.Text = "";
            childrenTextbox.Text = "";
            totalAmountText.Text = "";

            singleRoom.Checked = false;
            twinRoom.Checked = false;
            familyRoom.Checked = false;
            drcrcard.Checked = false;
            gcash.Checked = false;
            checkinDate.Value = DateTime.Today;
            checkoutDate.Value = DateTime.Today;

        }



        private void button2_Click(object sender, EventArgs e) //Check Out
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(selectedIndex);

                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {
            int numNights = (int)(checkoutDate.Value - checkinDate.Value).TotalDays;

            int nightlyRate = 0;
            if (singleRoom.Checked)
            {
                nightlyRate = 2000;
            }
            else if (twinRoom.Checked)
            {
                nightlyRate = 2800;
            }
            else if (familyRoom.Checked)
            {
                nightlyRate = 4000;
            }
            int totalRentalFee = numNights * nightlyRate;


            int numAdults = 0;
            int numChildren = 0;
            int.TryParse(adultsTextbox.Text, out numAdults);
            int.TryParse(childrenTextbox.Text, out numChildren);
            int adultFee = 0;
            int childrenFee = 0;
            if (numAdults > 2)
            {
                adultFee = 500 * (numAdults - 2);
            }
            else if (numChildren > 2)
            {
                childrenFee = 500 * (numChildren - 2);
            }
            else if (singleRoom.Checked)
            {
                if (numAdults > 1 & numChildren >= 1)
                {
                    childrenFee = 500 * (numChildren - 1);
                    adultFee = 500 * (numAdults - 1);
                }
            }
            int additionalGuestFee = adultFee + childrenFee;
            int totalAmountDue = totalRentalFee + additionalGuestFee;
            totalAmountText.Text = totalAmountDue.ToString();

        }
    }
}
