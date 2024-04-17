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

namespace Poly_Pipe_Company
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard da = new Dashboard();
            da.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1 : Create a Sql Connection 
                SqlConnection con = new SqlConnection();

                //step 2 : set the database address to the sql connection
                con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=PolyPipe;Integrated Security=True";

                //step 3: Open the connection
                con.Open();

                //step 4: Create the Sql Command
                SqlCommand cmd = new SqlCommand();

                //step 5 : Set the sql connection to the sql command
                cmd.Connection = con;

                //step 6 : Define the sql query type
                cmd.CommandType = CommandType.Text;

                //step 7 : Assign the Sql query
                cmd.CommandText = "insert into Employee values ('" + int.Parse(textBox3.Text) + "','" + textBox4.Text + "','" + int.Parse(textBox6.Text) + "','" + textBox5.Text + "','" + dateTimePicker1.Value + "','" + int.Parse(textBox7.Text) + "')";

                //step 8 : Execute the Sql Command
                cmd.ExecuteReader();

                //step 9 : Close the sql connection
                con.Close();

                //step 10 : Display a successfull message
                MessageBox.Show("Successfully added all the details!");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=PolyPipe;Integrated Security=True";

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Employee", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=PolyPipe;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Employee where [Employee ID] = '" + int.Parse(textBox2.Text) + "' ";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully deleted all the details!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
