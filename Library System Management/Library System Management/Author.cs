using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System_Management
{
    public partial class Author : Form
    {
        string connectionString = @"Data Source=LAPTOP-AN5C6GCV\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";

        SqlDataAdapter sqlDa;
        DataTable dt;

        public Author()
        {
            InitializeComponent();
            displayDB();

        }

        private void displayDB()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AuthorDB", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dataGridView1.DataSource = dtbl;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayDB();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    using (DataTable dtbl = new DataTable("authorDB"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM authorDB WHERE authorID=@authorID or authorFName=@authorFname or authorLName=@authorLName or authorNationality=@authorNationality or authorEmail=@authorEmail", sqlCon))
                        {
                            cmd.Parameters.AddWithValue("authorID", txt_search.Text);
                            cmd.Parameters.AddWithValue("authorFName", txt_search.Text);
                            cmd.Parameters.AddWithValue("authorLName", txt_search.Text);
                            cmd.Parameters.AddWithValue("authorNationality", txt_search.Text);
                            cmd.Parameters.AddWithValue("authorEmail", txt_search.Text);
                            sqlDa = new SqlDataAdapter(cmd);
                            sqlDa.Fill(dtbl);
                            dataGridView1.DataSource = dtbl;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //updateAuthorUI update = new updateAuthorUI();


            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "update")
            {
                updateAuthorUI update = new updateAuthorUI();
                update.txtFName.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                update.txtLName.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                update.txtNationality.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                update.txtEmail.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                update.ShowDialog();
            }

            /*string query = "SELECT * FROM AuthorDB WHERE @AuthorID = authorid";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            using SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@AuthorID", authorID);
            */
            //update.txtID.Text();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addAuthorUI addAuthor = new addAuthorUI();
            addAuthor.Show();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            //Commented Auto Complete Search Code
            /*try
            {
                SqlConnection con = new SqlConnection(connectionString);
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                con.Open();

                string sql = "SELECT * FROM authorDB";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = null;
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    col.Add(sdr["authorID"].ToString());
                }
                sdr.Close();

                txt_search.AutoCompleteCustomSource = col;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
