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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompanyManagementSystem
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into stafftab values(@Id,@Name,@Age,@Gender,@Salary)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Salary", textBox4.Text);
           

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved Successfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from stafftab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update stafftab set name=@Name,age=@Age,gender=@Gender,salary=@Salary where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Salary", textBox4.Text);


            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete stafftab where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted Successfully");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from stafftab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from stafftab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
