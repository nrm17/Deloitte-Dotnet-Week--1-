using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace student
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;

        string constr = "Data Source=DESKTOP-9MJ1CJ8;Initial Catalog = StudentDB; Integrated Security = True; Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentDBDataSet.StudentInfo);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int Rollno = int.Parse(txtRoll.Text);
            string Name = txtName.Text;
            DateTime DOB = DateTime.Parse( dtpDOB.Value.ToString());


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


            MessageBox.Show( "Roll no is " + Rollno);

            try
            {
                con = new SqlConnection(constr); // creating connection
                con.Open();

                string query = "insert into StudentInfo values (@rn,@nm,@dob,@gen,@dpt,@cou,@sem,@add,@ph)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rn", Rollno);
                cmd.Parameters.AddWithValue("@nm", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gen", Gender);
                cmd.Parameters.AddWithValue("@dpt", Department);
                cmd.Parameters.AddWithValue("@cou", Course);
                cmd.Parameters.AddWithValue("@sem", Sem);
                cmd.Parameters.AddWithValue("@add", Address);
                cmd.Parameters.AddWithValue("@ph", PhoneNo);


                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                    MessageBox.Show("Data Inserted : " + res);





            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = " select * from StudentInfo";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbSel.Items.Clear();

                while(r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbSel.Items.Add(r[i]);
                        lbSel.Items.Add("************");
                    }
                }
            }
             catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
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

            int Rollno = (int)cbRoll.SelectedValue;
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "update  StudentInfo set Name = @nm, DOB = @dob,Gender = @gen, Department = @dpt, Course = @cou,Semester = @sem, Address = @add, PhoneNo = @ph where RollNo = @rol"; // table name = @
                cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@rol", Rollno);
                cmd.Parameters.AddWithValue("@nm", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gen", Gender);
                cmd.Parameters.AddWithValue("@dpt", Department);
                cmd.Parameters.AddWithValue("@cou", Course);
                cmd.Parameters.AddWithValue("@sem", Sem);
                cmd.Parameters.AddWithValue("@add", Address);
                cmd.Parameters.AddWithValue("@ph", PhoneNo);

                int res = cmd.ExecuteNonQuery();
                if(res > 0 )
                {
                    MessageBox.Show("Data updated");
                }


            }
             catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
