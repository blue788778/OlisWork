namespace OlisWork
{
    partial class Form6_Json
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxJWrite = new System.Windows.Forms.TextBox();
            this.textBoxJRead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 450);
            this.button1.TabIndex = 0;
            this.button1.Text = "寫入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxJWrite
            // 
            this.textBoxJWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxJWrite.Location = new System.Drawing.Point(0, 0);
            this.textBoxJWrite.Multiline = true;
            this.textBoxJWrite.Name = "textBoxJWrite";
            this.textBoxJWrite.Size = new System.Drawing.Size(800, 141);
            this.textBoxJWrite.TabIndex = 1;
            // 
            // textBoxJRead
            // 
            this.textBoxJRead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxJRead.Location = new System.Drawing.Point(0, 201);
            this.textBoxJRead.Multiline = true;
            this.textBoxJRead.Name = "textBoxJRead";
            this.textBoxJRead.ReadOnly = true;
            this.textBoxJRead.Size = new System.Drawing.Size(800, 249);
            this.textBoxJRead.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(745, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "讀取JSON";
            // 
            // Form6_Json
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJRead);
            this.Controls.Add(this.textBoxJWrite);
            this.Controls.Add(this.button1);
            this.Name = "Form6_Json";
            this.Text = "Form6_Json";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxJWrite;
        private System.Windows.Forms.TextBox textBoxJRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}