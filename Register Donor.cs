using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Donation
{
    public partial class Register_Donor : System.Windows.Forms.Form
    {
        public Register_Donor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        int ID;
        int rowID;
        private void Register_Donor_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(250, 90); //280 [Left, Right], 120 [Up, Down]



            //SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from registerDonor", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridViewDonor.DataSource = ds.Tables[0];

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        
        private void btnSave_Click(object sender, EventArgs e) 
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into registerDonor values(@donorName,@donorPhone,@donorEmail,@donorAddress,@donorStatus)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@donorName", txtName.Text);
            cmd.Parameters.AddWithValue("@donorPhone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@donorEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@donorAddress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@donorStatus", txtStatus.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Donor record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Register_Donor_Load(this, null);
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                SqlCommand cmd = new SqlCommand("Update registerDonor set donorName=@donorName,donorPhone=@donorPhone,donorEmail=@donorEmail,donorAddress=@donorAddress,donorStatus=@donorStatus where donorID= '" + ID+"'", con);

                con.Open();
                // cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@donorName", txtName.Text);
                cmd.Parameters.AddWithValue("@donorPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@donorEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@donorAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@donorStatus", txtStatus.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Donor record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Register_Donor_Load(this, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete the selected record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    SqlCommand cmd = new SqlCommand("Delete from registerDonor where donorID='" + ID + "'");
                    cmd.Connection = con;

                    MessageBox.Show("Donor Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    Register_Donor_Load(this, null);
            
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridViewDonor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewDonor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID = int.Parse(dataGridViewDonor.Rows[e.RowIndex].Cells[1].Value.ToString());
                }

               // con.Open();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                SqlCommand cmd = new SqlCommand("Select * from registerDonor where donorID= '" + ID + "'");
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
               // con.Close();
                rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());


                //Filling the table data in the respective text boxes
                //usrID = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();

                txtPhone.Text = ds.Tables[0].Rows[0][2].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                txtStatus.Text = ds.Tables[0].Rows[0][5].ToString();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDonor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           // dataGridViewDonor.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void dataGridViewDonor_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewDonor.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }
    }
}
