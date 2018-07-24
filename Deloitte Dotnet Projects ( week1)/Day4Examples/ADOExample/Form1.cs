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

namespace ADOExample
{
    public partial class Form1 : Form
    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;


        string constr = "Data Source=DESKTOP-9MJ1CJ8;Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {  
            // text box
            string name = tXtName.Text;
 
            // combo box
            string gender = cbGender.SelectedItem.ToString();

            //radio button

            string membership = " ";
            if (rbFree.Checked)
                membership = rbFree.Text;

            if (rbPremium.Checked)
                membership = rbPremium.Text;

            // checked list box

            string shopping = " ";

            foreach (var d in clbShopping.CheckedItems)
            {
                shopping += d + ",";
            }
            // checkbox
            string cod = "";
            if (cbCod.Checked)
                cod = "Yes";
            else
                cod = "No";

            //Password

            string Pass = txtPassword.Text;


            MessageBox.Show(name + "\n" + gender + "\n" + membership + "\n" + shopping + "\n" + cod + "\n" + Pass);





            try
            {
                con = new SqlConnection(constr);
                con.Open();

                string query = "insert into RegisterShopping values (@nm,@gen,@mem,@pref,@cod,@pwd)"; // parameters to sql query

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm",name);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@pref", shopping);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@pwd", Pass);
                 int res = cmd.ExecuteNonQuery();

                if (res > 0)
                    MessageBox.Show("Data Inserted: " + res);
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);


            }
            catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);
            }
            catch  (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from RegisterShopping";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbSelect.Items.Clear();

                while(r.Read())
                {
                    for ( int i=0;i<r.FieldCount;i++)
                    {
                        lbSelect.Items.Add(r[i]);
                        lbSelect.Items.Add("************");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cbID.SelectedValue;
                MessageBox.Show("ID is  " + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from RegisterShopping where ID = @id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                    MessageBox.Show("Data deleted " + res);

                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

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
