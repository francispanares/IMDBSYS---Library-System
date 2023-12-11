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

namespace Library_System_Management
{
    public partial class addAuthorUI : Form
    {
        string connectionString = @"Data Source=LAPTOP-AN5C6GCV\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";

        public addAuthorUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtNationality.Clear();
            txtEmail.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into authorDB values (@authorID,@authorFName,@authorLName,@authorNationality,@authorEmail)",con);
            cmd.Parameters.AddWithValue("@authorID", txtID.Text);
            cmd.Parameters.AddWithValue("@authorFName", txtFName.Text);
            cmd.Parameters.AddWithValue("@authorLName", txtLName.Text);
            cmd.Parameters.AddWithValue("@authorNationality", txtNationality.Text);
            cmd.Parameters.AddWithValue("@authorEmail", txtEmail.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Added");
        }
    }
}
