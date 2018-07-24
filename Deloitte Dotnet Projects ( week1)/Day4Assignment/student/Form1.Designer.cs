namespace student
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.cbSem = new System.Windows.Forms.ComboBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbSel = new System.Windows.Forms.ListBox();
            this.cbRoll = new System.Windows.Forms.ComboBox();
            this.studentDBDataSet = new student.StudentDBDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new student.StudentDBDataSetTableAdapters.StudentInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(287, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "StudentProfile";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(75, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Roll No.";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(75, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Name";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Location = new System.Drawing.Point(75, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "DOB";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(75, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Gender";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox6.Location = new System.Drawing.Point(75, 241);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Department";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox7.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox7.Location = new System.Drawing.Point(75, 289);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Course";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox8.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox8.Location = new System.Drawing.Point(75, 338);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Semester";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox9.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox9.Location = new System.Drawing.Point(75, 383);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Address";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox10.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox10.Location = new System.Drawing.Point(75, 427);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "Phone NO";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(265, 71);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(100, 20);
            this.txtRoll.TabIndex = 10;
            this.txtRoll.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(265, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(265, 151);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 12;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.ForeColor = System.Drawing.Color.Black;
            this.rbMale.Location = new System.Drawing.Point(249, 199);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 13;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(365, 199);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Items.AddRange(new object[] {
            "ECE",
            "Mech",
            "CSE",
            "ISE",
            "EEE",
            "IEM"});
            this.cbDept.Location = new System.Drawing.Point(265, 241);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 21);
            this.cbDept.TabIndex = 15;
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "B.Tech",
            "M.tech",
            "Phd"});
            this.cbCourse.Location = new System.Drawing.Point(265, 287);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 21);
            this.cbCourse.TabIndex = 16;
            // 
            // cbSem
            // 
            this.cbSem.FormattingEnabled = true;
            this.cbSem.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh"});
            this.cbSem.Location = new System.Drawing.Point(265, 338);
            this.cbSem.Name = "cbSem";
            this.cbSem.Size = new System.Drawing.Size(121, 21);
            this.cbSem.TabIndex = 17;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(265, 383);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 18;
            // 
            // txtPh
            // 
            this.txtPh.Location = new System.Drawing.Point(265, 427);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(100, 20);
            this.txtPh.TabIndex = 19;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Orange;
            this.btnInsert.Location = new System.Drawing.Point(598, 93);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Lime;
            this.btnSelect.Location = new System.Drawing.Point(598, 152);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdate.Location = new System.Drawing.Point(598, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.HotPink;
            this.btnDelete.Location = new System.Drawing.Point(598, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lbSel
            // 
            this.lbSel.FormattingEnabled = true;
            this.lbSel.Location = new System.Drawing.Point(564, 352);
            this.lbSel.Name = "lbSel";
            this.lbSel.Size = new System.Drawing.Size(120, 95);
            this.lbSel.TabIndex = 24;
            this.lbSel.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbRoll
            // 
            this.cbRoll.DataSource = this.studentInfoBindingSource;
            this.cbRoll.DisplayMember = "Name";
            this.cbRoll.FormattingEnabled = true;
            this.cbRoll.Location = new System.Drawing.Point(402, 72);
            this.cbRoll.Name = "cbRoll";
            this.cbRoll.Size = new System.Drawing.Size(121, 21);
            this.cbRoll.TabIndex = 25;
            this.cbRoll.ValueMember = "RollNo";
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(801, 526);
            this.Controls.Add(this.cbRoll);
            this.Controls.Add(this.lbSel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtPh);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.cbSem);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbSem;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbSel;
        private System.Windows.Forms.ComboBox cbRoll;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentDBDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
    }
}

