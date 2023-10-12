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


namespace Assign2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static string Username = "";
        public static string Password = "";

        private void button1_Click_1(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-O31QORP\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
            Username = textBox1.Text;
            Password = textBox2.Text;
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                var datasource = @"DESKTOP-T0EEFH0\SQLEXPRESS"; var database = "Northwind";
                var thisUsername = Username; var thisPassword = Password;

                string connString = @"Data Source=" + datasource +
                    ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername +
                    ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    conn.Open();

                    Form1 frm1 = new Form1();
                    frm1.Show();
                    //this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}