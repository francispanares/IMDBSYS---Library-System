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
    public partial class updateAuthorUI : Form
    {
        string connectionString = @"Data Source=LAPTOP-AN5C6GCV\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";

        public updateAuthorUI()
        {
            InitializeComponent();
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {

            txtFName.Clear();
            txtLName.Clear();
            txtNationality.Clear();
            txtEmail.Clear();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand cm = new SqlCommand("update authorDB set authorFName = @authorFName, authorLName = @authorLName, authorNationality = @authorNationality, authorEmail=@authorEmail", cn);
            cm.Parameters.AddWithValue("@authorFName", txtFName.Text);
            cm.Parameters.AddWithValue("@authorLName", txtLName.Text);
            cm.Parameters.AddWithValue("@authorNationality", txtNationality.Text);
            cm.Parameters.AddWithValue("@authorEmail", txtEmail.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Brand has been successfully updated.");
            this.Dispose();
        }
    }
}
