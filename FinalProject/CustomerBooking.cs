using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CustomerBooking : Form
    {
        bookingConnect book = new bookingConnect();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rd;
        public CustomerBooking()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            int.TryParse(adults.Text, out numAdults);
            int.TryParse(children.Text, out numChildren);
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
                if(numAdults > 1 & numChildren >= 1)
                {
                    childrenFee = 500 * (numChildren - 1);
                    adultFee = 500 * (numAdults - 1);
                }
            }

            int additionalGuestFee = adultFee + childrenFee;
            int totalAmountDue = totalRentalFee + additionalGuestFee;
            totalAmount.Text = totalAmountDue.ToString();
        }

        private void Total_Payment_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = book.getCon();
            conn.Open();

            String selectedRoom = "";
            if(singleRoom.Checked)
                selectedRoom = singleRoom.Text;
            else if(twinRoom.Checked)
                selectedRoom = twinRoom.Text;
            else if(familyRoom.Checked)
                selectedRoom = familyRoom.Text;
            String selectedPayOpt = "";
            if(radioButton4.Checked)
                selectedPayOpt = radioButton4.Text;
            else if (radioButton5.Checked)
                selectedPayOpt = radioButton5.Text;

            cmd = new SqlCommand("insert into bookingTable values ('"+textBox1.Text+"','"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"', @SelectedDate1, @SelectedDate2, '"+selectedRoom+"', '"+adults.Text+"', '"+children.Text+"', '"+selectedPayOpt+"', '"+totalAmount.Text+"')", conn);
            cmd.Parameters.AddWithValue("@SelectedDate1", checkinDate.Value);
            cmd.Parameters.AddWithValue("@SelectedDate2", checkoutDate.Value);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            ConfirmMessage confirm = new ConfirmMessage();  
            confirm.Show();
            this.Hide();
        }
    }
}
