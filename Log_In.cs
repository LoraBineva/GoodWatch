using FinalEda;
using Register_page;
using System.Data;
using System.Data.SqlClient;
using static Final_Eda.Authenticate;

namespace Final_Eda
{
    public partial class Log_In : Form
    {
        SqlConnection sql;
        public Log_In()
        {
            InitializeComponent();
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;");
                sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void log_in_btn_Click(object sender, EventArgs e)
        {
            string username_inp = username.Text;
            string password_inp = password.Text;

            if (!string.IsNullOrWhiteSpace(username_inp) && !string.IsNullOrWhiteSpace(password_inp))
            {
                Authenticate.User authenticatedUser = DatabaseManager.AuthenticateUser(username_inp, password_inp);

                if (authenticatedUser != null)
                {
                    this.Hide();
                    Search search = new Search(authenticatedUser);
                    search.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }
    }
}