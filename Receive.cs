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
    public partial class Receive : System.Windows.Forms.Form
    {
        public Receive()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        int ID;
        int rowID;

        private void Receive_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from receiveDonation", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            con.Open();

            comboBoxReceiver.Items.Clear();
            cmd = new SqlCommand("Select recipName from registerRecipient", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    comboBoxReceiver.Items.Add(dr.GetString(i));

                }

            }

            dr.Close();
            con.Close();

            dataGridViewReceive.DataSource = ds.Tables[0];



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into receiveDonation values(@receiverName,@receiverPhone,@receiverItem,@receiverQuantity,@receiverDescription,@receiverDate)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@receiverName", comboBoxReceiver.Text);
            cmd.Parameters.AddWithValue("@receiverPhone", txtRPhone.Text);
            cmd.Parameters.AddWithValue("@receiverItem", txtItem.Text);
            cmd.Parameters.AddWithValue("@receiverQuantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@receiverDescription", txtDescrip.Text);
            cmd.Parameters.AddWithValue("@receiverDate", dateTimePicker1.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Receive_Load(this, null);
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                SqlCommand cmd = new SqlCommand("Update receiveDonation set receiverName=@receiverName,receiverPhone=@receiverPhone,receiverItem=@receiverItem,receiverQuantity=@receiverQuantity,receiverDescription=@receiverDescription,receiverDate=@receiverDate", con);

                con.Open();
                // cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@receiverName", comboBoxReceiver.Text);
                cmd.Parameters.AddWithValue("@receiverPhone", txtRPhone.Text);
                cmd.Parameters.AddWithValue("@receiverItem", txtItem.Text);
                cmd.Parameters.AddWithValue("@receiverQuantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@receiverDescription", txtDescrip.Text);
                cmd.Parameters.AddWithValue("@receiverDate", dateTimePicker1.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Receive_Load(this, null);
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
                    SqlCommand cmd = new SqlCommand("Delete from receiveDonation where receiverID='" + ID + "'");
                    cmd.Connection = con;

                    MessageBox.Show("Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    Receive_Load(this, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            comboBoxReceiver.SelectedIndex = -1;
            txtRPhone.Clear();
            txtItem.Clear();
            txtQuantity.Clear();
            txtDescrip.Clear();


        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridViewReceive_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewReceive.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void comboBoxReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxReceiver.Text != "")
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                    SqlCommand cmd = new SqlCommand("Select * from registerRecipient where recipName='" + comboBoxReceiver.SelectedItem.ToString() + "'");
                    cmd.Connection = con;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        txtRPhone.Text = dr[3].ToString();
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

      

        private void dataGridViewReceive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewReceive.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID = int.Parse(dataGridViewReceive.Rows[e.RowIndex].Cells[1].Value.ToString());
                }

                // con.Open();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                SqlCommand cmd = new SqlCommand("Select * from receiveDonation where receiverID= '" + ID + "'");
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                // con.Close();
                rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                //Filling the table data in the respective text boxes
                //usrID = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                comboBoxReceiver.Text = ds.Tables[0].Rows[0][1].ToString();
                txtRPhone.Text = ds.Tables[0].Rows[0][2].ToString();
                txtItem.Text = ds.Tables[0].Rows[0][3].ToString();
                txtQuantity.Text = ds.Tables[0].Rows[0][4].ToString();
                txtDescrip.Text = ds.Tables[0].Rows[0][5].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewReceive_RowPostPaint(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewReceive.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void comboBoxReceiver_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
