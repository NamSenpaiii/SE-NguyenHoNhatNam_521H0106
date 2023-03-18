using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VendorMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Read a txt File to add available destination
        public void addDestination()
        {
            //get path
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Destination.txt");
            string[] lines = File.ReadAllLines(path);
            //add to combo box
            foreach(string line in lines)
            {
                cbDes.Items.Add(line);
            }
            //is there are too many destination
            //passenger can search and there will be a suggestion
            //if there are any available destination
            cbDes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        //Read a txt File to add available type of payment
        public void addPayment()
        {
            //get path
            var path = Path.Combine(Directory.GetCurrentDirectory(), "TypeOfPayment.txt");
            string[] lines = File.ReadAllLines(path);
            //add to combo box
            foreach (string line in lines)
            {
                cbPay.Items.Add(line);
            }
            //is there are too many type of payment
            //passenger can search and there will be a suggestion
            //if there are any available type of payment
            cbPay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPay.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            addDestination();
            addPayment();
        }
        //Check combo box if they are empty or not
        public bool checkCB()
        {
            if(cbDes.SelectedItem == null || cbPay.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Destination and Type of Payment.");
                    return false;
            }
            return true;
        }
        //Buy button
        private void bBuy_Click(object sender, EventArgs e)
        {
            //if combo box not empty we go to next step
            if (checkCB() == true)
            {
                //if pay by card passenger will requested to insert card and confirm payment
                if (cbPay.Text == "Credit Card")
                {
                    //if purchase successfully the app will message passenger and end
                    if (MessageBox.Show("Insert Card and Click OK to Pay.", "Transaction", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show("Purchase Successful, Please Take Your Ticket.");
                        Application.Exit();
                    }
                    //if cancel the app will return to previous form
                    else
                    {
                        MessageBox.Show("Purchase Canceled");
                    }
                }
                // if not pay by card passenger will requested to scan qr code and confirm
                else
                {
                    MessageBox.Show("Please Scan QR code to confirm payment.");
                    //move to new form that got qr code
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
            }
        }
    }
}
