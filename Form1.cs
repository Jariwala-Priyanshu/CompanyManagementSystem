using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Product ps = new Product();

            ps.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client ct = new Client();

            ct.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff sf = new Staff();

            sf.Show();
        }

        private void btnIntern_Click(object sender, EventArgs e)
        {
            Intern In = new Intern();

            In.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();

            ds.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
