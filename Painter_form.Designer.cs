namespace OlisWork
{
    partial class Painter_form
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
            this.panDraw = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.setMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setMenu_PenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.setMenu_PenSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.ctms_Circle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspMenuRound = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMenuRect = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMenuLine = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panDraw)).BeginInit();
            this.menu.SuspendLayout();
            this.ctms_Circle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDraw
            // 
            this.panDraw.BackColor = System.Drawing.Color.White;
            this.panDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panDraw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panDraw.Location = new System.Drawing.Point(0, 0);
            this.panDraw.Name = "panDraw";
            this.panDraw.Size = new System.Drawing.Size(799, 451);
            this.panDraw.TabIndex = 0;
            this.panDraw.TabStop = false;
            this.panDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDraw_firstpoint_Down);
            this.panDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panDraw_tonewpoint_Move);
            this.panDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuShape_Up);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuItem";
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
            this.setMenu_PenColor.Click += new System.EventHandler(this.clgColor_Click);
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
            // ctms_Circle
            // 
            this.ctms_Circle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMenuRound,
            this.tspMenuRect,
            this.tspMenuLine});
            this.ctms_Circle.Name = "contextMenuStrip_Circle";
            this.ctms_Circle.Size = new System.Drawing.Size(99, 70);
            // 
            // tspMenuRound
            // 
            this.tspMenuRound.Name = "tspMenuRound";
            this.tspMenuRound.Size = new System.Drawing.Size(98, 22);
            this.tspMenuRound.Text = "圓形";
            this.tspMenuRound.Click += new System.EventHandler(this.tspMenuRound_Click);
            // 
            // tspMenuRect
            // 
            this.tspMenuRect.Name = "tspMenuRect";
            this.tspMenuRect.Size = new System.Drawing.Size(98, 22);
            this.tspMenuRect.Text = "方形";
            this.tspMenuRect.Click += new System.EventHandler(this.tspMenuRect_Click);
            // 
            // tspMenuLine
            // 
            this.tspMenuLine.Name = "tspMenuLine";
            this.tspMenuLine.Size = new System.Drawing.Size(98, 22);
            this.tspMenuLine.Text = "線條";
            this.tspMenuLine.Click += new System.EventHandler(this.tspMenuLine_Click);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panDraw);
            this.Name = "Painter";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDraw_firstpoint_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panDraw_tonewpoint_Move);
            ((System.ComponentModel.ISupportInitialize)(this.panDraw)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ctms_Circle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox panDraw;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem setMenu;
        private System.Windows.Forms.ToolStripMenuItem setMenu_PenColor;
        private System.Windows.Forms.ToolStripMenuItem setMenu_PenSize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ColorDialog cld;
        private System.Windows.Forms.ContextMenuStrip ctms_Circle;
        private System.Windows.Forms.ToolStripMenuItem tspMenuRound;
        private System.Windows.Forms.ToolStripMenuItem tspMenuRect;
        private System.Windows.Forms.ToolStripMenuItem tspMenuLine;
    }
}

