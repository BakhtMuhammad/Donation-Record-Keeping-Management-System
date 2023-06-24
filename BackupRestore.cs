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
    public partial class BackupRestore : System.Windows.Forms.Form
    {
        public BackupRestore()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBoxBackup_Click(object sender, EventArgs e)
        {
            try
            {
                //if(MessageBox.Show("Are you sure to take the database backup at, D:\\Complete_Database_Backup.bak?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                //{ 
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                // con.ConnectionString = str;
                string database = "DMS";
                #region
                //string path = txt1Location.Text;
                //string database = con.Database.ToString();
                //if(txt1Location.Text==string.Empty)
                //{
                //    //MessageBox.Show("Please select file location.");

                //}
                //else
                //{
                #endregion
                if (MessageBox.Show("Do you want to take the backup? Backup file will be located at D:\\SoftwareDatabaseBackupFile.bak.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region
                    //string cmd = @"BACKUP DATABASE [" + database + "] TO DISK '" + txt1Location.Text + "\\" + "Database_BakUp" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    //string cmd = "BACKUP DATABASE [" + database + "] TO DISK = 'D:\\Database_Backup.bak'";
                    #endregion
                    int i;

                    //progressBar1.Minimum = 0;
                    //progressBar1.Maximum = 100;

                    //for (i = 0; i <= 100; i++)
                    //{
                    //    progressBar1.Value = i;
                    //}
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK= 'D:\\SoftwareDatabaseBackupFile.bak' with Format";


                    //BACKUP DATABASE [SQLTestDB]  TO DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Backup\SQLTestDB.bak'
                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("You have successfully created a database backup file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnBackup.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxRestore_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            //  con.ConnectionString = str;
            //string database = con.Database.ToString();
            string database = "IMS";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //try
            //{
                if (MessageBox.Show("Do you want to restore the database backup? Backup file is located at D:\\SoftwareDatabaseBackupFile.bak.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region
                    //string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    //SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                    //bu2.ExecuteNonQuery();
                    #endregion
                    int i;


                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = 'D:\\SoftwareDatabaseBackupFile.bak' WITH REPLACE";
                    SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                    bu3.ExecuteNonQuery();
                    #region
                    //string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    //SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                    //bu4.ExecuteNonQuery();
                    #endregion
                    MessageBox.Show("You have successfully restored the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void BackupRestore_Load(object sender, EventArgs e)
        {

        }
    }
}
