
namespace Smart_Donation
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProtection = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDonationReport = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRegisterDonor = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimise);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 161);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1461, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimise.Image")));
            this.btnMinimise.Location = new System.Drawing.Point(1408, 0);
            this.btnMinimise.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(57, 48);
            this.btnMinimise.TabIndex = 4;
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1104, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donation Data Keeping Software";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1511, 461);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lime;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnEmployee, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProtection, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDonationReport, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReceive, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDonate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRegisterDonor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1511, 461);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployee.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Yellow;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.Location = new System.Drawing.Point(4, 310);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(369, 147);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProtection
            // 
            this.btnProtection.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnProtection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProtection.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProtection.ForeColor = System.Drawing.Color.Yellow;
            this.btnProtection.Image = ((System.Drawing.Image)(resources.GetObject("btnProtection.Image")));
            this.btnProtection.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProtection.Location = new System.Drawing.Point(1135, 157);
            this.btnProtection.Margin = new System.Windows.Forms.Padding(4);
            this.btnProtection.Name = "btnProtection";
            this.btnProtection.Size = new System.Drawing.Size(372, 145);
            this.btnProtection.TabIndex = 7;
            this.btnProtection.Text = "Data Protection";
            this.btnProtection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProtection.UseVisualStyleBackColor = false;
            this.btnProtection.Click += new System.EventHandler(this.btnProtection_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Maroon;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.Location = new System.Drawing.Point(758, 157);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(369, 145);
            this.button7.TabIndex = 6;
            this.button7.Text = "Received Report";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnDonationReport
            // 
            this.btnDonationReport.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDonationReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDonationReport.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonationReport.Image = ((System.Drawing.Image)(resources.GetObject("btnDonationReport.Image")));
            this.btnDonationReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonationReport.Location = new System.Drawing.Point(381, 157);
            this.btnDonationReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonationReport.Name = "btnDonationReport";
            this.btnDonationReport.Size = new System.Drawing.Size(369, 145);
            this.btnDonationReport.TabIndex = 5;
            this.btnDonationReport.Text = "Donation Report";
            this.btnDonationReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonationReport.UseVisualStyleBackColor = false;
            this.btnDonationReport.Click += new System.EventHandler(this.btnDonationReport_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.Navy;
            this.btnReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReceive.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnReceive.Image")));
            this.btnReceive.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReceive.Location = new System.Drawing.Point(4, 157);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(369, 145);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "Receive";
            this.btnReceive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDonate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDonate.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.Image = ((System.Drawing.Image)(resources.GetObject("btnDonate.Image")));
            this.btnDonate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonate.Location = new System.Drawing.Point(1135, 4);
            this.btnDonate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(372, 145);
            this.btnDonate.TabIndex = 3;
            this.btnDonate.Text = "DONATE";
            this.btnDonate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.Location = new System.Drawing.Point(758, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 145);
            this.button3.TabIndex = 2;
            this.button3.Text = "Register Recipient";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btmRegisterRecip_Click);
            // 
            // btnRegisterDonor
            // 
            this.btnRegisterDonor.BackColor = System.Drawing.Color.MintCream;
            this.btnRegisterDonor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegisterDonor.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterDonor.ForeColor = System.Drawing.Color.Brown;
            this.btnRegisterDonor.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterDonor.Image")));
            this.btnRegisterDonor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegisterDonor.Location = new System.Drawing.Point(381, 4);
            this.btnRegisterDonor.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterDonor.Name = "btnRegisterDonor";
            this.btnRegisterDonor.Size = new System.Drawing.Size(369, 145);
            this.btnRegisterDonor.TabIndex = 1;
            this.btnRegisterDonor.Text = "Register Donor";
            this.btnRegisterDonor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegisterDonor.UseVisualStyleBackColor = false;
            this.btnRegisterDonor.Click += new System.EventHandler(this.btnRegisterDonor_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.Location = new System.Drawing.Point(4, 4);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(369, 145);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1511, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRegisterDonor;
        private System.Windows.Forms.Button btnProtection;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnDonationReport;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnEmployee;
    }
}

