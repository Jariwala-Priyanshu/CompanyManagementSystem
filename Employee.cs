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

namespace CompanyManagementSystem
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into emptab values(@EmployeeId,@EmployeeName,@Gender,@Phone,@Address,@Salary,@Position)", con);

            cnn.Parameters.AddWithValue("@EmployeeId", textBox1.Text);

            cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);

            cnn.Parameters.AddWithValue("@Address", textBox4.Text);

            cnn.Parameters.AddWithValue("@Salary", textBox5.Text);

            cnn.Parameters.AddWithValue("@Position", comboBox2.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved Successfully");
        }

        private void tnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from emptab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("update emptab set employeename=@EmployeeName,gender=@Gender,phone=@Phone,address=@Address,salary=@Salary,position=@position where employeeid=@employeeid", con);

            cnn.Parameters.AddWithValue("@EmployeeId", textBox1.Text);

            cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);

            cnn.Parameters.AddWithValue("@Address", textBox4.Text);

            cnn.Parameters.AddWithValue("@Salary", textBox5.Text);

            cnn.Parameters.AddWithValue("@Position", comboBox2.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete emptab where employeeid=@employeeid", con);

            cnn.Parameters.AddWithValue("@EmployeeId", textBox1.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted Successfully");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from emptab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from emptab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
