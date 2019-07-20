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
using System.Text.RegularExpressions;



namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CM233FB\\SQLEXPRESS;Initial Catalog=preparation;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (name.Text != "" && fname.Text != "" && cnic.Text != "")
                {
                    if (RegExp(@"^([\w]+)@([\w]+)\.([\w]+)$", email, "Email: "))
                    //RegExp(@"^[A-Za-z\s]{1,40}$", textBoxofName, "Name: ");
                    // RegExp(@"[0-3]{1}[0-9]{1}\-[0-1]{1}[0-9]{1}\-[0-9]{4}$", textBoxOfDOB,"D.O.B.");
                    //RegExp(@"^[A-Za-z]{1}[A-Za-z0-9]{7,19}$", textBoxofPassword, "Password: ");
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Insert into student values('" + name.Text + "','" + fname.Text + "','" + cnic.Text + "')";
                        //     cmd.Parameters.Add(new SqlParameter("reg", regText.Text));
                        //cmd.Parameters.AddWithValue("reg", regText.Text);
                        //cmd.Parameters.Add(new SqlParameter("name", nameText.Text));
                        //cmd.Parameters.Add(new SqlParameter("class", classText.Text));

                        // cmd.CommandText = "enterdata";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
               // cmd.CommandText = "Select *from student";
                

                cmd.CommandText = "showData";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("recevingData", name.Text);
                cmd.CommandText = "delData";
                cmd.ExecuteNonQuery();
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Boolean RegExp(string regex, TextBox tb, string s)
        {
            Regex a = new Regex(regex);
            if (a.IsMatch(tb.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
