using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Donation
{
    public partial class Register : System.Windows.Forms.Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text != "" && txtUserName.Text != "" && txtPassword.Text != ""  && txtRetype.Text != "")
                {
                    if (txtPassword.Text != txtRetype.Text)
                    {
                        MessageBox.Show("Password doesn't match. Please type again.");
                    }
                    else
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                        SqlCommand cmd = new SqlCommand("insert into users (fullName, userName, userPassword) values ('" + txtFullName.Text + "', '" + txtUserName.Text + "','" + Encrypt(txtPassword.Text) + "')", con);
                        cmd.Connection = con;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("User Registered Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                        txtFullName.Clear();
                        txtPassword.Clear();
                        txtRetype.Clear();
                        txtUserName.Clear();

                    }
                }

                else
                {
                    MessageBox.Show("Please make sure all fields are completed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
