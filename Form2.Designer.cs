namespace OlisWork
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workDataControl_StudentDataSet = new OlisWork.WorkDataControl_StudentDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_StuID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.checkBox_Mar = new System.Windows.Forms.CheckBox();
            this.comboBox_Grade = new System.Windows.Forms.ComboBox();
            this.studentTableAdapter = new OlisWork.WorkDataControl_StudentDataSetTableAdapters.StudentTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.workDataControl_StudentDataSet1 = new OlisWork.WorkDataControl_StudentDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDataControl_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDataControl_StudentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(279, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(485, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // workDataControl_StudentDataSet
            // 
            this.workDataControl_StudentDataSet.DataSetName = "WorkDataControl_StudentDataSet";
            this.workDataControl_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.workDataControl_StudentDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "學號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "年級";
            // 
            // textBox_StuID
            // 
            this.textBox_StuID.Location = new System.Drawing.Point(108, 51);
            this.textBox_StuID.Name = "textBox_StuID";
            this.textBox_StuID.Size = new System.Drawing.Size(100, 22);
            this.textBox_StuID.TabIndex = 5;
            this.textBox_StuID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_StuID_KeyDown);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(108, 108);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 6;
            // 
            // checkBox_Mar
            // 
            this.checkBox_Mar.AutoSize = true;
            this.checkBox_Mar.Location = new System.Drawing.Point(108, 220);
            this.checkBox_Mar.Name = "checkBox_Mar";
            this.checkBox_Mar.Size = new System.Drawing.Size(43, 16);
            this.checkBox_Mar.TabIndex = 7;
            this.checkBox_Mar.Text = "Mar";
            this.checkBox_Mar.UseVisualStyleBackColor = true;
            // 
            // comboBox_Grade
            // 
            this.comboBox_Grade.FormattingEnabled = true;
            this.comboBox_Grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_Grade.Location = new System.Drawing.Point(108, 177);
            this.comboBox_Grade.Name = "comboBox_Grade";
            this.comboBox_Grade.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Grade.TabIndex = 8;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(45, 341);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 38);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "新增";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(153, 341);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(89, 38);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "編輯";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(279, 341);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 38);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "刪除";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // workDataControl_StudentDataSet1
            // 
            this.workDataControl_StudentDataSet1.DataSetName = "WorkDataControl_StudentDataSet";
            this.workDataControl_StudentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox_Grade);
            this.Controls.Add(this.checkBox_Mar);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_StuID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDataControl_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDataControl_StudentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private WorkDataControl_StudentDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_StuID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.CheckBox checkBox_Mar;
        private System.Windows.Forms.ComboBox comboBox_Grade;
        private WorkDataControl_StudentDataSet workDataControl_StudentDataSet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        public WorkDataControl_StudentDataSet workDataControl_StudentDataSet1;
    }
}