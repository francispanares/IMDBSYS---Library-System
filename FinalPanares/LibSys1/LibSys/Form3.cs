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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibSys
{
    public partial class Form3 : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataReader reader;
        public Form3()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Francis\Downloads\PANARES\FinalPanares\LibSys1\LibSys\Database1.accdb");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = User.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else
            {
                string q = "SELECT * FROM login WHERE username = @username AND password = @password";
                cmd = new OleDbCommand(q, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Success");
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                reader.Close();
                conn.Close();
            }
        }
    }
        }
    

