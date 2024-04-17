using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poly_Pipe_Company
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails();
            cd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InstallationType it = new InstallationType();
            it.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EquipmentType et = new EquipmentType();
            et.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Installation tt = new Installation();
            tt.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmployeeType et = new EmployeeType();
            et.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Payments pa = new Payments();
            pa.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Facilities ff = new Facilities();
            ff.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nn = new Form1();
            nn.Show();
            this.Hide();
            MessageBox.Show("Loggin Out");
        }
    }
}
