namespace OlisWork
{
    partial class Json
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
            this.txtJWrite = new System.Windows.Forms.TextBox();
            this.txtJRead = new System.Windows.Forms.TextBox();
            this.lblWrite = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWrite.Location = new System.Drawing.Point(0, 0);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(800, 450);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "寫入Json";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtJWrite
            // 
            this.txtJWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtJWrite.Location = new System.Drawing.Point(0, 0);
            this.txtJWrite.Multiline = true;
            this.txtJWrite.Name = "txtJWrite";
            this.txtJWrite.Size = new System.Drawing.Size(800, 141);
            this.txtJWrite.TabIndex = 1;
            // 
            // txtJRead
            // 
            this.txtJRead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtJRead.Location = new System.Drawing.Point(0, 201);
            this.txtJRead.Multiline = true;
            this.txtJRead.Name = "txtJRead";
            this.txtJRead.ReadOnly = true;
            this.txtJRead.Size = new System.Drawing.Size(800, 249);
            this.txtJRead.TabIndex = 2;
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWrite.Location = new System.Drawing.Point(0, 141);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(53, 12);
            this.lblWrite.TabIndex = 3;
            this.lblWrite.Text = "輸入文字";
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRead.Location = new System.Drawing.Point(745, 141);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(55, 12);
            this.lblRead.TabIndex = 4;
            this.lblRead.Text = "讀取JSON";
            // 
            // Json
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.lblWrite);
            this.Controls.Add(this.txtJRead);
            this.Controls.Add(this.txtJWrite);
            this.Controls.Add(this.btnWrite);
            this.Name = "Json";
            this.Text = "Form6_Json";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtJWrite;
        private System.Windows.Forms.TextBox txtJRead;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.Label lblRead;
    }
}