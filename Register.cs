using Microsoft.VisualBasic.ApplicationServices;
using System.Web;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Final_Eda;

namespace Register_page
{
    public partial class Register : Form
    {

        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uTXTbox.Text) ||
                string.IsNullOrEmpty(eTXTbox.Text) ||
                string.IsNullOrEmpty(last_nameTXTbox.Text) ||
                string.IsNullOrEmpty(first_nameTXTbox.Text) ||
                string.IsNullOrEmpty(yearCbox.Text) ||
                string.IsNullOrEmpty(monthCbox.Text) ||
                string.IsNullOrEmpty(dayCbox.Text) ||
                string.IsNullOrEmpty(pTXTbox.Text))
            {
                MessageBox.Show("Please fill all gaps!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Email_Valid() || password_Validating() || username_Validating())
                {



                    using (cn = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;Encrypt=False;"))
                    {
                        cn.Open();

                        // Checking if the username already exists
                        using (cmd = new SqlCommand("SELECT COUNT(1) FROM Users Where username = @Username", cn))
                        {
                            cmd.Parameters.AddWithValue("@username", uTXTbox.Text);

                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            if (count == 1)
                            {
                                MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                string DOB = yearCbox.SelectedItem.ToString() + monthCbox.SelectedItem.ToString() + dayCbox.SelectedItem.ToString();
                                // Inserting user information into the database
                                using (cmd = new SqlCommand("INSERT INTO Users (username, password, email, first_name,last_name, DOB)\r\nVALUES (@username, @password, @email, @first_name, @last_name , @DOB)", cn))
                                {
                                    cmd.Parameters.AddWithValue("@username", uTXTbox.Text);
                                    cmd.Parameters.AddWithValue("@email", eTXTbox.Text);
                                    cmd.Parameters.AddWithValue("@password", pTXTbox.Text);
                                    cmd.Parameters.AddWithValue("@first_name", first_nameTXTbox.Text);
                                    cmd.Parameters.AddWithValue("@last_name", last_nameTXTbox.Text);
                                    cmd.Parameters.AddWithValue("@DOB", DOB);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Your Account is created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Hide();
                                    Log_In log_In = new Log_In();
                                    log_In.ShowDialog();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Plese enter valid informaion");
                }


            }

        }






        public bool Email_Valid()
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(eTXTbox.Text))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(eTXTbox.Text);
        }
        private bool username_Validating()
        {
            if (uTXTbox.Text.Length < 8)
            {
                MessageBox.Show("Your username has to be at least 8 characters", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool password_Validating()
        {
            if (!(pTXTbox.Text.Length >= 8 && pTXTbox.Text.Any(char.IsUpper) && pTXTbox.Text.Any(char.IsLower) && pTXTbox.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more conditions for the password haven't been met.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }


        }

        private void monthCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}