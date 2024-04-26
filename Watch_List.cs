using FinalEda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Final_Eda.Authenticate;
using System.Collections;

namespace Final_Eda
{
    public partial class Watch_List : Form
    {
        public User user1;
        public Watch_List(User user)
        {
            InitializeComponent();
            user1 = user;
        }
        SqlConnection sql;

        private void go_search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search(user1);
            search.ShowDialog();
        }

        private void go_watched_Click(object sender, EventArgs e)
        {
            this.Hide();
            Watched watched_list = new Watched(user1);
            watched_list.ShowDialog();
        }

        private void Watch_List_Load(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;");
                sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            filter();
            PopulateGenreComboBox();
        }

        private void add_watchlist_Click(object sender, EventArgs e)
        {
            if (movieID1.Text != null)
            {
                string query3 = "UPDATE WatchList SET status = 'Watched' WHERE movieID=@movieID1";

                SqlCommand updateStatusCmd = new SqlCommand(query3, sql);
                updateStatusCmd.Parameters.AddWithValue("@movieID1", movieID1.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (movieID2.Text != null)
            {
                string query3 = "Delete from WatchList WHERE movieID=@movieID2";

                SqlCommand updateStatusCmd = new SqlCommand(query3, sql);
                updateStatusCmd.Parameters.AddWithValue("@movieID2", movieID2.Text);
                updateStatusCmd.ExecuteNonQuery();

                MessageBox.Show("Removed Succesfully!");
                movieID2.Clear();
                Refresh();
            }
            else
            {
                MessageBox.Show("Failed.");
            }
        }

        private void viewall_btn_Click(object sender, EventArgs e)
        {
            azCBox.SelectedIndex = -1;
            GenreCbox.SelectedIndex = -1;
            Refresh();
        }
        private void Refresh() {
            string fetchMovies = "SELECT WatchList.movieID, Movies.title, Movies.genre, Movies.duration_min, Movies.year, Movies.director, Movies.language  " +
             "From WatchList INNER JOIN Movies ON WatchList.movieID = Movies.movieID WHERE WatchList.userID=@userID AND WatchList.status='Watching'";
            SqlCommand cmd = new SqlCommand(fetchMovies, sql);
            cmd.Parameters.AddWithValue("@userID", user1.UserID);
            cmd.CommandText = fetchMovies;
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                data.DataSource = ds.Tables[0];
            }
        }
        private void PopulateGenreComboBox()
        {
            try
            {
                string query = "SELECT DISTINCT genre FROM Movies";

                SqlCommand cmd = new SqlCommand(query, sql);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string genre = reader.GetString(0);
                        GenreCbox.Items.Add(genre);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void filter()
        {
            string query = "SELECT WatchList.movieID, Movies.title, Movies.genre, Movies.duration_min, Movies.year, Movies.director, Movies.language  " +
            "From WatchList INNER JOIN Movies ON WatchList.movieID = Movies.movieID WHERE WatchList.userID=@userID AND WatchList.status='Watching'";

            if (GenreCbox.SelectedIndex != -1)
            {
                string genre = GenreCbox.SelectedItem?.ToString();
                query += $"AND Movies.genre = '{genre}'";
            }

            if (azCBox.SelectedIndex != -1)
            {
                if (azCBox.SelectedItem.ToString() == "A-Z")
                {
                    query += " ORDER BY Movies.title DESC";
                }
                else if (azCBox.SelectedItem.ToString() == "Z-A")
                {
                    query += " ORDER BY title ASC";
                }
            }
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddWithValue("@userID", user1.UserID);

            cmd.CommandText = query;

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                data.DataSource = ds.Tables[0];
            }

        }

        private void azCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void GenreCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
