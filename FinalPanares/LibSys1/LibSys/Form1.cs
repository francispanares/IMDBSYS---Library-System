using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys
{
    public partial class Form1 : Form
    {
        private OleDbConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Admin\\Desktop\\LibSys1\\LibSys\\Library.accdb");
            loadDatagrid();
        }

        private void loadDatagrid()
        {
            conn.Open();
            OleDbCommand com = new OleDbCommand("SELECT * FROM book ORDER BY [accession_number]", conn);
            com.ExecuteNonQuery();
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;
            conn.Close();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtno.Text = grid1.Rows[e.RowIndex].Cells["accession_Number"].Value.ToString();
            txttitle.Text = grid1.Rows[e.RowIndex].Cells["title"].Value.ToString();
            txtauthor.Text = grid1.Rows[e.RowIndex].Cells["author"].Value.ToString();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Admin\\Desktop\\LibSys1\\LibSys\\Library.accdb"))
                {
                    conn.Open();
                    OleDbCommand com = new OleDbCommand("INSERT INTO book (accession_number, title, author, column_name) VALUES (@accessionNumber, @title, @author, @availability)", conn);
                    com.Parameters.AddWithValue("@accessionNumber", txtno.Text);
                    com.Parameters.AddWithValue("@title", txttitle.Text);
                    com.Parameters.AddWithValue("@author", txtauthor.Text);
                    com.Parameters.AddWithValue("@availability", "Available");
                    com.ExecuteNonQuery();
                }

                MessageBox.Show("Successfully Saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand com = new OleDbCommand("Select * from book where title like '%" + txtSearch.Text + "%'", conn);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            conn.Close();
        }

        private void grid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtno.Text != "")
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Admin\\Desktop\\LibSys1\\LibSys\\Library.accdb"))
                    {
                        conn.Open();
                        OleDbCommand com = new OleDbCommand("DELETE FROM book WHERE accession_number = @accessionNumber", conn);
                        com.Parameters.AddWithValue("@accessionNumber", txtno.Text);
                        com.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

