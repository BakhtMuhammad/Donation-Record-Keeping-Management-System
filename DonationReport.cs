using CrystalDecisions.CrystalReports.Engine;
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
    public partial class DonationReport : System.Windows.Forms.Form
    {
        public DonationReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        ReportDocument rd;

        private void DonationReport_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                SqlCommand cmd = new SqlCommand("select * from donate", con);

                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                rd = new ReportDocument();

                rd.Load(Application.StartupPath + "\\Reports\\CrystalReportDonation.rpt");
                rd.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                if (rd != null)
                {
                    rd.Close();
                }
            }
        }

        private void DonationReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }
    }
}
