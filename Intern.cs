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
    public partial class Intern : Form
    {
        public Intern()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into interntab values(@InternId,@InternName,@Gender,@Phone,@Address,@Technology,@CollegeName,@StartDate,@EndDate,@Stipend)", con);

            cnn.Parameters.AddWithValue("@InternId", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@InternName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);

            cnn.Parameters.AddWithValue("@Address", textBox4.Text);

            cnn.Parameters.AddWithValue("@Technology", comboBox2.Text);

            cnn.Parameters.AddWithValue("@CollegeName", textBox5.Text);

            cnn.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);

            cnn.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);

            cnn.Parameters.AddWithValue("@Stipend", comboBox3.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved Successfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from interntab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update interntab set internName=@InternName,gender=@Gender,phone=@Phone,address=@Address,technology=@Technology,collegename=@CollegeName,startdate=@StartDate,enddate=@EndDate,stipend=@Stipend where internid=@internid", con);

            cnn.Parameters.AddWithValue("@InternId", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@InternName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);

            cnn.Parameters.AddWithValue("@Phone", textBox3.Text);

            cnn.Parameters.AddWithValue("@Address", textBox4.Text);

            cnn.Parameters.AddWithValue("@Technology", comboBox2.Text);

            cnn.Parameters.AddWithValue("@CollegeName", textBox5.Text);

            cnn.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);

            cnn.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);

            cnn.Parameters.AddWithValue("@Stipend", comboBox3.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete interntab where internid=@internid", con);

            cnn.Parameters.AddWithValue("@InternId", int.Parse(textBox1.Text));

            

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted Successfully");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from interntab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Intern_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=cmsdb;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("select * from interntab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
