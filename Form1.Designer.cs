namespace OlisWork
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drawPanel = new System.Windows.Forms.PictureBox();
            this.menuItem = new System.Windows.Forms.MenuStrip();
            this.setMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setMenu_PenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.setMenu_PenSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip_Circle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Round = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Rect = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).BeginInit();
            this.menuItem.SuspendLayout();
            this.contextMenuStrip_Circle.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.drawPanel.Location = new System.Drawing.Point(0, 0);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(799, 451);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.TabStop = false;
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draw_FirstPoint_Down);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draw_ToNewPoint_Move);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuCircle_Up);
            // 
            // menuItem
            // 
            this.menuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMenu});
            this.menuItem.Location = new System.Drawing.Point(0, 0);
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(800, 24);
            this.menuItem.TabIndex = 1;
            this.menuItem.Text = "menuItem";
            // 
            // setMenu
            // 
            this.setMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMenu_PenColor,
            this.setMenu_PenSize});
            this.setMenu.Name = "setMenu";
            this.setMenu.Size = new System.Drawing.Size(43, 20);
            this.setMenu.Text = "設定";
            // 
            // setMenu_PenColor
            // 
            this.setMenu_PenColor.Name = "setMenu_PenColor";
            this.setMenu_PenColor.Size = new System.Drawing.Size(98, 22);
            this.setMenu_PenColor.Text = "顏色";
            this.setMenu_PenColor.Click += new System.EventHandler(this.SetPenColorItem_Click);
            // 
            // setMenu_PenSize
            // 
            this.setMenu_PenSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.setMenu_PenSize.Name = "setMenu_PenSize";
            this.setMenu_PenSize.Size = new System.Drawing.Size(98, 22);
            this.setMenu_PenSize.Text = "筆寬";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "1";
            // 
            // contextMenuStrip_Circle
            // 
            this.contextMenuStrip_Circle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Round,
            this.ToolStripMenuItem_Rect});
            this.contextMenuStrip_Circle.Name = "contextMenuStrip_Circle";
            this.contextMenuStrip_Circle.Size = new System.Drawing.Size(181, 70);
            // 
            // ToolStripMenuItem_Round
            // 
            this.ToolStripMenuItem_Round.Name = "ToolStripMenuItem_Round";
            this.ToolStripMenuItem_Round.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Round.Text = "圓形";
            this.ToolStripMenuItem_Round.Click += new System.EventHandler(this.ToolStripMenuItem_Round_Click);
            this.ToolStripMenuItem_Round.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuCircle_Up);
            // 
            // ToolStripMenuItem_Rect
            // 
            this.ToolStripMenuItem_Rect.Name = "ToolStripMenuItem_Rect";
            this.ToolStripMenuItem_Rect.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Rect.Text = "方形";
            this.ToolStripMenuItem_Rect.Click += new System.EventHandler(this.ToolStripMenuItem_Rect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuItem);
            this.Controls.Add(this.drawPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draw_FirstPoint_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draw_ToNewPoint_Move);
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).EndInit();
            this.menuItem.ResumeLayout(false);
            this.menuItem.PerformLayout();
            this.contextMenuStrip_Circle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawPanel;
        private System.Windows.Forms.MenuStrip menuItem;
        private System.Windows.Forms.ToolStripMenuItem setMenu;
        private System.Windows.Forms.ToolStripMenuItem setMenu_PenColor;
        private System.Windows.Forms.ToolStripMenuItem setMenu_PenSize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Circle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Round;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Rect;
    }
}

