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
    public partial class Register_Recipient : System.Windows.Forms.Form
    {
        public Register_Recipient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        int ID;
        int rowID;
        private void Register_Recipient_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from registerRecipient", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridViewRecip.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into registerRecipient values(@recipName,@recipFather,@recipPhone,@recipAddress,@recipStatus)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@recipName", txtName.Text);
            cmd.Parameters.AddWithValue("@recipFather", txtFather.Text);
            cmd.Parameters.AddWithValue("@recipPhone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@recipAddress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@recipStatus", txtStatus.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Recipient record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Register_Recipient_Load(this, null);
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                SqlCommand cmd = new SqlCommand("Update registerRecipient set recipName=@recipName,recipFather=@recipFather,recipPhone=@recipPhone,recipAddress=@recipAddress,recipStatus=@recipStatus", con);

                con.Open();
                // cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@recipName", txtName.Text);
                cmd.Parameters.AddWithValue("@recipFather", txtFather.Text);
                cmd.Parameters.AddWithValue("@recipPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@recipAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@recipStatus", txtStatus.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Recipient record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Register_Recipient_Load(this, null);
            }
            catch (Exception ex)
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
                    SqlCommand cmd = new SqlCommand("Delete from registerRecipient where recipID='" + ID + "'");
                    cmd.Connection = con;

                    MessageBox.Show("Recipient Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    Register_Recipient_Load(this, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewRecip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewRecip.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID = int.Parse(dataGridViewRecip.Rows[e.RowIndex].Cells[1].Value.ToString());
                }

                // con.Open();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                SqlCommand cmd = new SqlCommand("Select * from registerRecipient where recipID= '" + ID + "'");
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                // con.Close();
                rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                //Filling the table data in the respective text boxes
                //usrID = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                txtPhone.Text = ds.Tables[0].Rows[0][3].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                txtStatus.Text = ds.Tables[0].Rows[0][5].ToString();


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
            txtFather.Clear();
            txtAddress.Clear();
            txtStatus.Clear();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();       
        }

        private void dataGridViewRecip_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewRecip.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
