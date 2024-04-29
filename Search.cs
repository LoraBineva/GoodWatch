using Final_Eda;
using Register_page;
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
using static Final_Eda.Authenticate;

namespace FinalEda
{
    public partial class Search : Form
    {
        public User authenticatedUser;
        public Search(User user)
        {
            InitializeComponent();
            authenticatedUser = user;
            hi_user.Text = $"Welcome: {authenticatedUser.First_Name}";
        }

        private void go_watched_Click(object sender, EventArgs e)
        {
            this.Hide();
            Final_Eda.Watched watched_list = new Final_Eda.Watched(authenticatedUser);
            watched_list.ShowDialog();
        }

        private void go_watchlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Watch_List watch_list = new Watch_List(authenticatedUser);
            watch_list.ShowDialog();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();
                if (category.SelectedIndex != -1 && search_box.Text != null)
                {
                    string search = search_box.Text.ToString();
                    string category2 = category.SelectedItem.ToString().ToLower();
                    string query2 = $"SELECT * FROM Movies WHERE {category2} = '{search}' AND movieID NOT IN (SELECT movieID FROM WatchList WHERE userID = @userID)";
                    SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                    cmd2.Parameters.AddWithValue("@userID", authenticatedUser.UserID);
                    cmd2.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                    }
                    search_box.Clear();
                    category.SelectedIndex = -1;
                }
            }
        }

        private void add_watchlist_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();

                if (movieID1.Text != null)
                {
                    string query3 = "INSERT INTO Watchlist VALUES (@movieID1, @userID, (SELECT title FROM Movies WHERE movieID=@movieID1), 'Watching')";

                    SqlCommand updateStatusCmd = new SqlCommand(query3, sqlCon);
                    updateStatusCmd.Parameters.AddWithValue("@movieID1", movieID1.Text);
                    updateStatusCmd.Parameters.AddWithValue("@userID", authenticatedUser.UserID);
                    updateStatusCmd.ExecuteNonQuery();

                    MessageBox.Show("Added Succesfully!");
                    movieID1.Clear();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Failed.");
                }

            }
        }

        private void add_watched_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();

                if (movieID2.Text != null)
                {
                    string query4 = "INSERT INTO Watchlist VALUES (@movieID2, @userID, (SELECT title FROM Movies WHERE movieID=@movieID2), 'Watched')";

                    SqlCommand updateStatusCmd = new SqlCommand(query4, sqlCon);
                    updateStatusCmd.Parameters.AddWithValue("@movieID2", movieID2.Text);
                    updateStatusCmd.Parameters.AddWithValue("@userID", authenticatedUser.UserID);
                    updateStatusCmd.ExecuteNonQuery();

                    MessageBox.Show("Added Succesfully!");
                    movieID2.Clear();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Failed.");
                }

            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();
                Refresh();
            }
        }
        private void Refresh()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT * FROM Movies WHERE movieID NOT IN (SELECT movieID FROM WatchList WHERE userID = @userID)";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@userID", authenticatedUser.UserID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }

            }
        }

        private void viewall_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

    }
}
