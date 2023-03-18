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

namespace VendorMachine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //get path of qr code (this is just an example code)
            var path = Path.Combine(Directory.GetCurrentDirectory(), "QR_Code_Example.png");
            pQR.ImageLocation = path;
            pQR.SizeMode = PictureBoxSizeMode.StretchImage;
            pQR.Load();
        }
        //if click ok the ticket will issued and app end
        private void bOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchase Successful, Please Take Your Ticket.");
            Application.Exit();
        }
        //if click cancel the app will return to previous form
        private void bCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchase Canceled");
            this.Close();
        }
    }
}
