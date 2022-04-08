namespace OlisWork
{
    partial class Txt
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.lblWrite = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWrite.Location = new System.Drawing.Point(0, 0);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 450);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "寫入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(75, 28);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(725, 156);
            this.txtWrite.TabIndex = 1;
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(75, 211);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.ReadOnly = true;
            this.txtRead.Size = new System.Drawing.Size(725, 239);
            this.txtRead.TabIndex = 2;
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Location = new System.Drawing.Point(82, 10);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(53, 12);
            this.lblWrite.TabIndex = 3;
            this.lblWrite.Text = "輸入文字";
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(81, 196);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(53, 12);
            this.lblRead.TabIndex = 4;
            this.lblRead.Text = "讀取文字";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.lblWrite);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.Label lblRead;
    }
}