namespace OlisWork
{
    partial class WebCam_form
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
            this.vspShow = new AForge.Controls.VideoSourcePlayer();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vspShow
            // 
            this.vspShow.Location = new System.Drawing.Point(42, 35);
            this.vspShow.Name = "vspShow";
            this.vspShow.Size = new System.Drawing.Size(539, 206);
            this.vspShow.TabIndex = 0;
            this.vspShow.Text = "videoSourcePlayer1";
            this.vspShow.VideoSource = null;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(101, 276);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // cboResolution
            // 
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Location = new System.Drawing.Point(101, 327);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(121, 20);
            this.cboResolution.TabIndex = 2;
            this.cboResolution.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(101, 362);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPicture.TabIndex = 3;
            this.btnPicture.Text = "Pic";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btn_Pic_Click);
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(28, 287);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(53, 12);
            this.lblOpen.TabIndex = 4;
            this.lblOpen.Text = "開啟鏡頭";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(28, 327);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(41, 12);
            this.lblResolution.TabIndex = 5;
            this.lblResolution.Text = "解析度";
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(28, 362);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(29, 12);
            this.lblPicture.TabIndex = 6;
            this.lblPicture.Text = "拍照";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.cboResolution);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.vspShow);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.webCam_Closed);
            this.Load += new System.EventHandler(this.webCam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vspShow;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblPicture;
    }
}