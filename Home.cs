using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Donation
{
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            Users users = new Users();
            users.Show();
            //this.Hide();
        }

        private void btnRegisterDonor_Click(object sender, EventArgs e)
        {
            Register_Donor rd = new Register_Donor();
            rd.Show();

        }

        private void btmRegisterRecip_Click(object sender, EventArgs e)
        {
            Register_Recipient rr = new Register_Recipient();
            rr.Show();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Donate d = new Donate();
            d.Show();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            Receive r = new Receive();
            r.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnDonationReport_Click(object sender, EventArgs e)
        {
            DonationReport dp = new DonationReport();
            dp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReceiveDonationReport rdr = new ReceiveDonationReport();
            rdr.Show();
        }

        private void btnProtection_Click(object sender, EventArgs e)
        {
            BackupRestore br = new BackupRestore();
            br.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }
    }
}
