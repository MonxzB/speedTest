namespace speedTest
{
    partial class Form1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblPing = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(320, 193);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 54);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "GO";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(302, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(142, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(145, 314);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(119, 16);
            this.lblDownload.TabIndex = 2;
            this.lblDownload.Text = "Download: -- Mbps";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(317, 314);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(103, 16);
            this.lblUpload.TabIndex = 3;
            this.lblUpload.Text = "Upload: -- Mbps";
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Location = new System.Drawing.Point(470, 314);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(69, 16);
            this.lblPing.TabIndex = 4;
            this.lblPing.Text = "Ping: -- ms";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(337, 282);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: --";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Label lblStatus;
    }
}

