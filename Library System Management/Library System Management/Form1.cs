using System.Data;
using System.Data.SqlClient;

namespace Library_System_Management
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-AN5C6GCV\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False");
        Thread th;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String userID, userpassword;

            userID = txt_user.Text;
            userpassword = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM UsersDB WHERE userID = '" + txt_user.Text + "' AND userpassword = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    userID = txt_user.Text;
                    userpassword = txt_password.Text;

                    //page that needed to be load next

                    menu Menu = new menu();
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_user.Clear();
                    txt_password.Clear();

                    //to focus username
                    txt_user.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passTxtbx_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void signUpBttn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}