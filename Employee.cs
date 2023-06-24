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
    public partial class Employee : System.Windows.Forms.Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        int ID;
        int rowID;

        private void Employee_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from employee", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dgvEmployee.DataSource = ds.Tables[0];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into employee values(@empName,@empPhone,@empEmail,@empAddress,@empPosition)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@empName", txtName.Text);
            cmd.Parameters.AddWithValue("@empPhone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@empEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@empAddress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@empPosition", txtPosition.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Employee record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Employee_Load(this, null);
            clear();
        }
        private void clear()
        {

            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
          
          
            txtPosition.Clear();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Update employee set empName=@empName,empPhone=@empPhone,empEmail=@empEmail,empAddress=@empAddress,empPosition=@empPosition where empID= '" + ID + "'", con);

            con.Open();
            // cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@empName", txtName.Text);
            cmd.Parameters.AddWithValue("@empPhone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@empEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@empAddress", txtAddress.Text);
            
            cmd.Parameters.AddWithValue("@empPosition", txtPosition.Text);
            
            //cmd.Parameters.AddWithValue("@stulivingstatus", cbLivingStatus.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Employee record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Employee_Load(this, null);
        }

        private void dgvEmployee_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvEmployee.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete the selected record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    SqlCommand cmd = new SqlCommand("Delete from employee where empID='" + ID + "'");
                    cmd.Connection = con;

                    MessageBox.Show("Employee Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    Employee_Load(this, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtSearch.Text != "")
        //        {
        //            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        //            SqlCommand cmd = new SqlCommand("Select * from employee where empCNIC LIKE '" + txtSearch.Text + "%'", con);
        //            cmd.Connection = con;

        //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //            DataSet ds = new DataSet();
        //            sda.Fill(ds);

        //            dgvEmployee.DataSource = ds.Tables[0];
        //            //Products_Load(this, null);

        //        }
        //        else
        //        {

        //            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        //            SqlCommand cmd = new SqlCommand("Select * from employee", con);
        //            cmd.Connection = con;


        //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //            DataSet ds = new DataSet();
        //            sda.Fill(ds);
        //            dgvEmployee.DataSource = ds.Tables[0];
        //            //Products_Load(this, null);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID = int.Parse(dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString());
                }

                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                SqlCommand cmd = new SqlCommand("Select * from employee where empID= '" + ID + "'");
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtPhone.Text = ds.Tables[0].Rows[0][2].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                txtPosition.Text = ds.Tables[0].Rows[0][5].ToString();
       

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    All_Employees_Record_Report empRe = new All_Employees_Record_Report();
        //    empRe.Show();
        //}


    }
}
