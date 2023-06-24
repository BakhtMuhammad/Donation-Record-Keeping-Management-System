
namespace Smart_Donation
{
    partial class BackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRestore));
            this.pictureBoxBackup = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestore = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackup
            // 
            this.pictureBoxBackup.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackup.Image")));
            this.pictureBoxBackup.Location = new System.Drawing.Point(74, 63);
            this.pictureBoxBackup.Name = "pictureBoxBackup";
            this.pictureBoxBackup.Size = new System.Drawing.Size(151, 144);
            this.pictureBoxBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackup.TabIndex = 0;
            this.pictureBoxBackup.TabStop = false;
            this.pictureBoxBackup.Click += new System.EventHandler(this.pictureBoxBackup_Click);
            // 
            // pictureBoxRestore
            // 
            this.pictureBoxRestore.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestore.Image")));
            this.pictureBoxRestore.Location = new System.Drawing.Point(240, 63);
            this.pictureBoxRestore.Name = "pictureBoxRestore";
            this.pictureBoxRestore.Size = new System.Drawing.Size(151, 144);
            this.pictureBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestore.TabIndex = 0;
            this.pictureBoxRestore.TabStop = false;
            this.pictureBoxRestore.Click += new System.EventHandler(this.pictureBoxRestore_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(418, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimise.Image")));
            this.btnMinimise.Location = new System.Drawing.Point(379, 1);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(43, 39);
            this.btnMinimise.TabIndex = 4;
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 274);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.pictureBoxRestore);
            this.Controls.Add(this.pictureBoxBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupRestore";
            this.Load += new System.EventHandler(this.BackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackup;
        private System.Windows.Forms.PictureBox pictureBoxRestore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimise;
    }
}