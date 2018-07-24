namespace ADOExample
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblShopping = new System.Windows.Forms.Label();
            this.lblCOD = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tXtName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.rbFree = new System.Windows.Forms.RadioButton();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.clbShopping = new System.Windows.Forms.CheckedListBox();
            this.cbCod = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbSelect = new System.Windows.Forms.ListBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDBDataSet = new ADOExample.TrainingDBDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.registerShoppingTableAdapter = new ADOExample.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(84, 114);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(114, 18);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Select Gender";
            this.lblGender.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(88, 176);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(150, 18);
            this.lblMembership.TabIndex = 2;
            this.lblMembership.Text = "Select Membership";
            // 
            // lblShopping
            // 
            this.lblShopping.AutoSize = true;
            this.lblShopping.Location = new System.Drawing.Point(88, 230);
            this.lblShopping.Name = "lblShopping";
            this.lblShopping.Size = new System.Drawing.Size(214, 18);
            this.lblShopping.TabIndex = 3;
            this.lblShopping.Text = "Select Shopping Preference";
            this.lblShopping.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCOD
            // 
            this.lblCOD.AutoSize = true;
            this.lblCOD.Location = new System.Drawing.Point(84, 373);
            this.lblCOD.Name = "lblCOD";
            this.lblCOD.Size = new System.Drawing.Size(90, 18);
            this.lblCOD.TabIndex = 4;
            this.lblCOD.Text = "Prefer COD";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(75, 420);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 18);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Enter Password";
            this.lblPassword.Click += new System.EventHandler(this.label6_Click);
            // 
            // tXtName
            // 
            this.tXtName.Location = new System.Drawing.Point(401, 50);
            this.tXtName.Name = "tXtName";
            this.tXtName.Size = new System.Drawing.Size(121, 26);
            this.tXtName.TabIndex = 6;
            // 
            // cbGender
            // 
            this.cbGender.AllowDrop = true;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Not interested"});
            this.cbGender.Location = new System.Drawing.Point(401, 110);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 26);
            this.cbGender.TabIndex = 7;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // rbFree
            // 
            this.rbFree.AutoSize = true;
            this.rbFree.Location = new System.Drawing.Point(328, 176);
            this.rbFree.Name = "rbFree";
            this.rbFree.Size = new System.Drawing.Size(58, 22);
            this.rbFree.TabIndex = 8;
            this.rbFree.TabStop = true;
            this.rbFree.Text = "Free";
            this.rbFree.UseVisualStyleBackColor = true;
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(534, 180);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(89, 22);
            this.rbPremium.TabIndex = 9;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // clbShopping
            // 
            this.clbShopping.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbShopping.FormattingEnabled = true;
            this.clbShopping.Items.AddRange(new object[] {
            "Apparels",
            "Cosmetics",
            "Shoes",
            "Electronic Gadgets",
            "Kitchenware"});
            this.clbShopping.Location = new System.Drawing.Point(401, 220);
            this.clbShopping.Name = "clbShopping";
            this.clbShopping.Size = new System.Drawing.Size(183, 88);
            this.clbShopping.TabIndex = 10;
            // 
            // cbCod
            // 
            this.cbCod.AutoSize = true;
            this.cbCod.Location = new System.Drawing.Point(380, 373);
            this.cbCod.Name = "cbCod";
            this.cbCod.Size = new System.Drawing.Size(53, 22);
            this.cbCod.TabIndex = 11;
            this.cbCod.Text = "Yes";
            this.cbCod.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(380, 429);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 26);
            this.txtPassword.TabIndex = 12;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegister.Location = new System.Drawing.Point(143, 563);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 38);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.Location = new System.Drawing.Point(380, 563);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 38);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbSelect
            // 
            this.lbSelect.FormattingEnabled = true;
            this.lbSelect.ItemHeight = 18;
            this.lbSelect.Location = new System.Drawing.Point(703, 59);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(120, 148);
            this.lbSelect.TabIndex = 15;
            // 
            // cbID
            // 
            this.cbID.AllowDrop = true;
            this.cbID.DataSource = this.registerShoppingBindingSource;
            this.cbID.DisplayMember = "Name";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(401, 3);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 26);
            this.cbID.TabIndex = 16;
            this.cbID.ValueMember = "Id";
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(637, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1075, 638);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbCod);
            this.Controls.Add(this.clbShopping);
            this.Controls.Add(this.rbPremium);
            this.Controls.Add(this.rbFree);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tXtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCOD);
            this.Controls.Add(this.lblShopping);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblShopping;
        private System.Windows.Forms.Label lblCOD;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tXtName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.RadioButton rbFree;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.CheckedListBox clbShopping;
        private System.Windows.Forms.CheckBox cbCod;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lbSelect;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btnDelete;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
    }
}

