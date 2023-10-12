using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            richTextBox1.Text = "Inserting Record..."; command.Connection = connection;
            command.CommandText = "insert into Customers (CustomerID, CompanyName) values('" + textBox1.Text + "','" + textBox2.Text + "')"; command.ExecuteNonQuery();
            richTextBox1.Text = "Record Inserted..."; connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Debug.WriteLine("Form1_Load() called..."); richTextBox1.Text = "Startup..."; try
                {
                    System.Diagnostics.Debug.WriteLine("within the try");
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=Northwind;Integrated Security=True");
                    connection.Open();
                    richTextBox1.Text = "Connection Successful"; connection.Close();
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = "Error, " + ex;
                }

            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=Northwind;Integrated Security=True"); connection.Open();
            richTextBox1.Text = "Counting Records..."; command.Connection = connection;
            command.CommandText = "select count(*) from Customers"; int count = (int)command.ExecuteScalar();
            richTextBox1.Text = "Number of records: " + count; connection.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            richTextBox1.Text = "Retrieving Records..."; command.Connection = connection;
            command.CommandText = "select * from Customers"; SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); da.Fill(dt);
            dataGridView1.DataSource = dt;
            richTextBox1.Text = "Retrieval Successful!";
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
