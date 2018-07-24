using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        StudentDBEntities db = new StudentDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentDBDataSet.StudentInfo);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int Rollno = int.Parse(txtRoll.Text);
            string Name = txtName.Text;
            DateTime DOB = DateTime.Parse(dtpDOB.Value.ToString());


            string Gender = " ";
            if (rbMale.Checked)
                Gender = rbMale.Text;

            if (rbFemale.Checked)
                Gender = rbFemale.Text;

            string Department = cbDept.SelectedItem.ToString();
            string Course = cbCourse.SelectedItem.ToString();
            string Sem = cbSem.SelectedItem.ToString();


            string Address = txtAdd.Text;
            string PhoneNo = txtPh.Text;


            MessageBox.Show("Roll no is " + Rollno);

            StudentInfo si = new StudentInfo();
            si.RollNo = Rollno;
            si.Name = Name;
            si.Gender = Gender;
            si.Department = Department;
            si.Course = Course;
            si.Semester = Sem;
            si.Address = Address;
            si.PhoneNo = PhoneNo;

            db.StudentInfoes.Add(si); // adding the stuff to class

            var res = db.SaveChanges();
            if(res > 0)
            {
                MessageBox.Show("Data inserted");
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lbSel.Items.Clear();

            foreach (var t in db.StudentInfoes)
            {
                lbSel.Items.Add(t.RollNo);
                lbSel.Items.Add(t.Name);
                lbSel.Items.Add(t.DOB);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rn = (int)cbRoll.SelectedValue;

            var del = (from t in db.StudentInfoes
                       where t.RollNo == rn
                       select t).SingleOrDefault();
            db.StudentInfoes.Remove(del);

            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("dATA dELETED");
            this.studentInfoTableAdapter.Fill(this.studentDBDataSet.StudentInfo);
        }
    }
}
