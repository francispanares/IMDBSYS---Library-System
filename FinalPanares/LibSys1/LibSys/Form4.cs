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
    public partial class Form4 : Form
    {
        private OleDbConnection conn;

        public Form4()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Admin\\Desktop\\LibSys1\\LibSys\\Library.accdb");
            loadDatagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text.Trim();
            string lastname = textBox2.Text.Trim();
            DateTime borrowDate = dateTimePicker1.Value;
            string cellphone = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(cellphone))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            SaveBorrowedDetails(firstname, lastname, borrowDate, cellphone);
            Form5 form5 = new Form5();
            form5.Show(); 
            this.Hide();
        }

        private void SaveBorrowedDetails(string firstname, string lastname, DateTime borrowDate, string cellphone)
        {
            string query = "INSERT INTO Borrow (First_Name, Last_Name, [Date], Cellphone_No) VALUES (?, ?, ?, ?)";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@p1", firstname);
                cmd.Parameters.AddWithValue("@p2", lastname);
                cmd.Parameters.AddWithValue("@p3", borrowDate);
                cmd.Parameters.AddWithValue("@p4", cellphone);

                try
                {   
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully.");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    loadDatagrid();
                }
            }
        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = grid2.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
            textBox2.Text = grid2.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
            string dateString = grid2.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            DateTime date;
            if (DateTime.TryParse(dateString, out date))
            {
                dateTimePicker1.Value = date;
            }
            else
            {
               
            }

            textBox4.Text = grid2.Rows[e.RowIndex].Cells["Cellphone_No"].Value.ToString();
        }

        private void loadDatagrid()
        {
            conn.Open();
            OleDbCommand com = new OleDbCommand("SELECT * FROM Borrow ORDER BY [First_Name]", conn);
            com.ExecuteNonQuery();
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid2.DataSource = tab;

            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}