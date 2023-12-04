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
    public partial class Form5 : Form
    {
        private OleDbConnection conn;
        public Form5()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Admin\\Desktop\\LibSys1\\LibSys\\Library.accdb");
            loadDatagrid();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void loadDatagrid()
        {
            conn.Open();
            OleDbCommand com = new OleDbCommand("SELECT * FROM book ORDER BY [accession_number]", conn);
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count > 0)
            {
                string selectedAccessionNumber = grid1.SelectedRows[0].Cells["accession_number"].Value.ToString();

                string column_name = grid1.SelectedRows[0].Cells["column_name"].Value.ToString();
                if (column_name == "Unavailable")
                {
                    MessageBox.Show("The selected book is not available for borrowing.");
                    return;
                }

                bool isBookBorrowed = BorrowBook(selectedAccessionNumber);

                if (isBookBorrowed)
                {
                    MessageBox.Show("The book has been successfully borrowed.");
                    loadDatagrid(); 
                }
                else
                {
                    MessageBox.Show("Failed to borrow the selected book.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book from the grid.");
            }
        }

        private bool BorrowBook(string accessionNumber)
        {
            string query = "UPDATE book SET column_name = 'Unavailable' WHERE accession_number = @p1";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@p1", accessionNumber);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                      
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void grid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0 && e.RowIndex < grid1.Rows.Count)
            {
                string accessionNumber = grid1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
                string title = grid1.Rows[e.RowIndex].Cells["title"].Value.ToString();
                string author = grid1.Rows[e.RowIndex].Cells["author"].Value.ToString();
                string column_name = grid1.SelectedRows[0].Cells["column_name"].Value.ToString();

                // Display the book information in a message box
                MessageBox.Show($"Accession Number: {accessionNumber}\nTitle: {title}\nAuthor: {author}\nColumn Name: {column_name}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
       
            if (grid1.SelectedRows.Count > 0)
            {
              
                string selectedAccessionNumber = grid1.SelectedRows[0].Cells["accession_number"].Value.ToString();

           
                string column_name = grid1.SelectedRows[0].Cells["column_name"].Value.ToString();
                if (column_name == "Available")
                {
                    MessageBox.Show("The selected book is already available.");
                    return;
                }
            }
        }

        private bool ReturnBook(string accessionNumber)
        {
            string query = "UPDATE book SET column_name = 'Available' WHERE accession_number = @p1";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@p1", accessionNumber);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        return true;
                    }
                    else
                    {
                      
                        return false;
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void returnButton_Click_1(object sender, EventArgs e)
        {
          
            if (grid1.SelectedRows.Count > 0)
            {
           
                string selectedAccessionNumber = grid1.SelectedRows[0].Cells["accession_number"].Value.ToString();

       
                string column_name = grid1.SelectedRows[0].Cells["column_name"].Value.ToString();
                if (column_name == "Available")
                {
                    MessageBox.Show("The selected book is already available.");
                    return;
                }

   
                bool isBookReturned = ReturnBook(selectedAccessionNumber);

                if (isBookReturned)
                {
                    MessageBox.Show("The book has been successfully returned.");
                    loadDatagrid();
                }
                else
                {
                    MessageBox.Show("Failed to return the selected book.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book from the grid.");
            }
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}