namespace OlisWork
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.tlpShow = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picThree = new System.Windows.Forms.PictureBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            this.tlpShow.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).BeginInit();
            this.SuspendLayout();
            // 
            // picTwo
            // 
            this.picTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTwo.Image = ((System.Drawing.Image)(resources.GetObject("picTwo.Image")));
            this.picTwo.Location = new System.Drawing.Point(355, 3);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(522, 154);
            this.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTwo.TabIndex = 1;
            this.picTwo.TabStop = false;
            // 
            // picOne
            // 
            this.picOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picOne.Image = ((System.Drawing.Image)(resources.GetObject("picOne.Image")));
            this.picOne.Location = new System.Drawing.Point(3, 3);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(346, 154);
            this.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOne.TabIndex = 0;
            this.picOne.TabStop = false;
            // 
            // tlpShow
            // 
            this.tlpShow.ColumnCount = 2;
            this.tlpShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpShow.Controls.Add(this.picOne, 0, 0);
            this.tlpShow.Controls.Add(this.picTwo, 1, 0);
            this.tlpShow.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tlpShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShow.Location = new System.Drawing.Point(0, 0);
            this.tlpShow.Name = "tlpShow";
            this.tlpShow.RowCount = 2;
            this.tlpShow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpShow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpShow.Size = new System.Drawing.Size(880, 536);
            this.tlpShow.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.picThree, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnOne, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTwo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnThree, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFour, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 370);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // picThree
            // 
            this.picThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picThree.Image = ((System.Drawing.Image)(resources.GetObject("picThree.Image")));
            this.picThree.Location = new System.Drawing.Point(3, 299);
            this.picThree.Name = "picThree";
            this.picThree.Size = new System.Drawing.Size(340, 68);
            this.picThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThree.TabIndex = 0;
            this.picThree.TabStop = false;
            // 
            // btnOne
            // 
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.Location = new System.Drawing.Point(3, 3);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(340, 68);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "button1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.Location = new System.Drawing.Point(3, 77);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(340, 68);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "button2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Location = new System.Drawing.Point(3, 151);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(340, 68);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "button3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.Location = new System.Drawing.Point(3, 225);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(340, 68);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "button4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 536);
            this.Controls.Add(this.tlpShow);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            this.tlpShow.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.TableLayoutPanel tlpShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox picThree;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
    }
}