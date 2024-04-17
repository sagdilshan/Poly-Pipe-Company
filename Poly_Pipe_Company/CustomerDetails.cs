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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=PolyPipe;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from CustomerDetail where [Customer ID] = '" + int.Parse(textBox2.Text) + "' ";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully deleted all the details!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=PolyPipe;Integrated Security=True";

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from CustomerDetail", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection();

                con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=PolyPipe;Integrated Security=True";

                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into CustomerDetail values ('" + textBox4.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value + "','" + textBox7.Text + "')";

                cmd.ExecuteReader();

                con.Close();

                MessageBox.Show("Successfully added all the details!");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox2.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
