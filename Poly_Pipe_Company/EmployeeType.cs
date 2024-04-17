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
    public partial class EmployeeType : Form
    {
        public EmployeeType()
        {
            InitializeComponent();
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

        private void EmployeeType_Load(object sender, EventArgs e)
        {

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

                cmd.CommandText = "insert into EmployeeType values ('" + textBox2.Text + "')";

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
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=PolyPipe;Integrated Security=True";

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from EmployeeType", con);

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
            cmd.CommandText = "delete from EmployeeType where [Empolyee Type ID] = '" + int.Parse(textBox1.Text) + "' ";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully deleted all the details!");
        }
    }
}
