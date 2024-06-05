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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into clienttab values(@ClientName,@Age,@Gender,@Phone,@Address,@Email,@Feedback)", con);

            cnn.Parameters.AddWithValue("@ClientName", textBox1.Text);

            cnn.Parameters.AddWithValue("@Age", textBox2.Text);

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);

            cnn.Parameters.AddWithValue("@Address", textBox4.Text);

            cnn.Parameters.AddWithValue("@Email", textBox5.Text);

            cnn.Parameters.AddWithValue("@Feedback", comboBox2.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved Successfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from clienttab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update clienttab set age=@Age,gender=@Gender,phone=@Phone,address=@Address,email=@Email,feedback=@Feedback where clientname=@clientname", con);

            cnn.Parameters.AddWithValue("@ClientName", textBox1.Text);

            cnn.Parameters.AddWithValue("@Age", textBox2.Text);

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);

            cnn.Parameters.AddWithValue("@Address", textBox4.Text);

            cnn.Parameters.AddWithValue("@Email", textBox5.Text);

            cnn.Parameters.AddWithValue("@Feedback", comboBox2.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete clienttab where clientname=@clientname", con);

            cnn.Parameters.AddWithValue("@ClientName", textBox1.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted Successfully");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from clienttab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from clienttab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
