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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from protab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into protab values(@ProductId,@ProductName,@Price)", con);

            cnn.Parameters.AddWithValue("@ProductId", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@ProductName", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved Successfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from protab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("update protab set productname=@ProductName,price=@Price where productid=@productid", con);

            cnn.Parameters.AddWithValue("@ProductId", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@ProductName", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete protab where productid=@productid", con);

            cnn.Parameters.AddWithValue("@ProductId", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved Successfully");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from protab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
