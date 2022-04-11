namespace OlisWork
{
    partial class Xml
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
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWrite.Location = new System.Drawing.Point(44, 55);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "寫入Xml";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(252, 35);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(293, 134);
            this.txtWrite.TabIndex = 1;
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(252, 196);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.ReadOnly = true;
            this.txtRead.Size = new System.Drawing.Size(293, 183);
            this.txtRead.TabIndex = 2;
            // 
            // Xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.btnWrite);
            this.Name = "Xml";
            this.Text = "Form6_XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.TextBox txtRead;
    }
}