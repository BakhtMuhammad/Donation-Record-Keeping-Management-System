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
    public partial class Donate : System.Windows.Forms.Form
    {
        public Donate()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        int ID;
        int rowID;

        private void Donate_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from donate", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            con.Open();

            comboBoxDonor.Items.Clear();
            cmd = new SqlCommand("Select donorName from registerDonor", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    comboBoxDonor.Items.Add(dr.GetString(i));

                }

            }

            dr.Close();
            con.Close();

            dataGridViewDonate.DataSource = ds.Tables[0];



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into donate values(@donorName,@donorPhone,@donateItem,@donateQuantity,@donateDescription,@donateDate)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@donorName", comboBoxDonor.Text);
            cmd.Parameters.AddWithValue("@donorPhone", txtDPhone.Text);
            cmd.Parameters.AddWithValue("@donateItem", txtItem.Text);
            cmd.Parameters.AddWithValue("@donateQuantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@donateDescription", txtDescrip.Text);
            cmd.Parameters.AddWithValue("@donateDate", dateTimePicker1.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Donation record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Donate_Load(this, null);
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                SqlCommand cmd = new SqlCommand("Update donate set donorName=@donorName,donorPhone=@donorPhone,donateItem=@donateItem,donateQuantity=@donateQuantity,donateDescription=@donateDescription,donateDate=@donateDate", con);

                con.Open();
                // cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@donorName", comboBoxDonor.Text);
                cmd.Parameters.AddWithValue("@donorPhone", txtDPhone.Text);
                cmd.Parameters.AddWithValue("@donateItem", txtItem.Text);
                cmd.Parameters.AddWithValue("@donateQuantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@donateDescription", txtDescrip.Text);
                cmd.Parameters.AddWithValue("@donateDate", dateTimePicker1.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Donation record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Donate_Load(this, null);
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
                    SqlCommand cmd = new SqlCommand("Delete from donate where donateID='" + ID + "'");
                    cmd.Connection = con;

                    MessageBox.Show("Donation Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    Donate_Load(this, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            comboBoxDonor.SelectedIndex = -1 ;
            txtDPhone.Clear();
            txtItem.Clear();
            txtQuantity.Clear();
            txtDescrip.Clear();
            

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridViewDonate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewDonate.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void comboBoxDonor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDonor.Text != "")
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                    SqlCommand cmd = new SqlCommand("Select * from registerDonor where donorName='" + comboBoxDonor.SelectedItem.ToString() + "'");
                    cmd.Connection = con;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        txtDPhone.Text = dr[2].ToString();
                    }

                    //Populating the phone textbox

                    //        SqlCommand cmd1 = new SqlCommand();
                    //        cmd1.Connection = con;
                    //        con.Open();
                    //        cmd1.CommandText = "Select * from employee where empPhone='" + cbCNIC.SelectedItem.ToString() + "'";

                    //        cmd1.ExecuteNonQuery();
                    //        con.Close();
                    //        DataTable dt1 = new DataTable();
                    //        SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                    //        sda.Fill(dt1);

                    //        foreach (DataRow dr1 in dt1.Rows)
                    //        {
                    //            txtPhone.Text = dr1[2].ToString();
                    //        }
                    //    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDonate_RowPostPaint(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewDonate.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void dataGridViewDonate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewDonate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID = int.Parse(dataGridViewDonate.Rows[e.RowIndex].Cells[1].Value.ToString());
                }

                // con.Open();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                SqlCommand cmd = new SqlCommand("Select * from donate where donateID= '" + ID + "'");
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                // con.Close();
                rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                //Filling the table data in the respective text boxes
                //usrID = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                comboBoxDonor.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDPhone.Text = ds.Tables[0].Rows[0][2].ToString();
                txtItem.Text = ds.Tables[0].Rows[0][3].ToString();
                txtQuantity.Text = ds.Tables[0].Rows[0][4].ToString();
                txtDescrip.Text = ds.Tables[0].Rows[0][5].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
