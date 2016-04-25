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

namespace FavoriteMovies
{
    public partial class MovieView : Form
    {
        private const int TITLE_COL = 0;
        private const int DESC_COL = 1;
        private const int YEAR_COL = 2;
        private const int GENRE_COL = 3;
        private const int RATING_COL = 4;

        private string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaron\documents\visual studio 2015\Projects\FavoriteMovies\FavoriteMovies\MovieDatabase.mdf;Integrated Security=True";
        private string selectQuery = "SELECT * FROM dbo.Movies";
        private string deleteQuery = @"DELETE FROM dbo.Movies WHERE MovieTitle = @title";
        public static List<Movie> movieList;
        private SqlDataAdapter dataAdapter;
        BindingSource bs = new BindingSource();

        public MovieView()
        {
            InitializeComponent();
        }

        private void MovieView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Movies' table. You can move, or remove it, as needed.
            lblStatus.Text = "";
           // this.moviesTableAdapter.Fill(this.movieDatabaseDataSet.Movies);
            movieList = new List<Movie>();
            gridMovies.DataSource = bs;
            loadMoviesFromDB();

        }

        /// <summary>
        /// Loads the data from the database to the array list.
        /// </summary>
        private void loadMoviesFromDB()
        {
            movieList = null;
            movieList = new List<Movie>();
            try
            {
                using (SqlConnection con = new SqlConnection(dbConnectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                while (reader.Read())
                                {

                                    Movie tmpMovie = new Movie(reader["MovieTitle"].ToString(),
                                        Convert.ToInt32(reader["ReleaseYear"]),
                                        Convert.ToInt32(reader["Rating"]),
                                        reader["Description"].ToString(),
                                        reader["Genres"].ToString());

                                    movieList.Add(tmpMovie);
                                }
                            }
                        }
                        
                        // Now Refresh the datagrid view
                        dataAdapter = new SqlDataAdapter(selectQuery, dbConnectionString);
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        bs.DataSource = table;
                        gridMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                }
            }
            catch (Exception e)
            {
                lblStatus.Text = "Error loading movies from DB";
            }
        }

        /// <summary>
        /// Helper function that takes in a movie name and deletes it from the database
        /// </summary>
        /// <param name="movieName"></param>
        /// <returns></returns>
        private bool deleteMovie(string movieName)
        {
            bool result = false;

            try
            {
                // Delete movie from the database
                using (var dbConnection = new SqlConnection(dbConnectionString))
                using (var dbCommand = new SqlCommand(deleteQuery, dbConnection))
                {
                    dbConnection.Open();

                    dbCommand.Parameters.AddWithValue("@title", movieName);

                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error deleting movie";
            }

            return result;
        }

        /// <summary>
        /// Kicks off the MovieDetails form to allow the user to add a new movie
        /// to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMovie_Click(object sender, EventArgs e)
        {

            MovieDetails movieDetails = new MovieDetails();
            movieDetails.ShowDialog();
            updateMovies();
        }

        /// <summary>
        /// Closes the application, unsaved data is lost.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Open a new movieDetails view but with the selected item in the table as a parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string title = gridMovies.SelectedRows[0].Cells[TITLE_COL].Value.ToString();
                string desc = gridMovies.SelectedRows[0].Cells[DESC_COL].Value.ToString();
                int year = (int)gridMovies.SelectedRows[0].Cells[YEAR_COL].Value;
                string genre = gridMovies.SelectedRows[0].Cells[GENRE_COL].Value.ToString();
                int rating = (int)gridMovies.SelectedRows[0].Cells[RATING_COL].Value;
                Movie editMovie = new Movie(title, year, rating, desc, genre);

                MovieDetails movieDetails = new MovieDetails(editMovie);
                movieDetails.ShowDialog();
                updateMovies();
            }
            catch(Exception ex)
            {
                lblStatus.Text = "Please select a movie or add a movie to edit";
            }
        }


        private void updateMovies()
        {
            loadMoviesFromDB();

            //gridMovies.Columns["movieTitleDataGridViewTextBoxColumn"].DisplayIndex = TITLE_COL;
            //gridMovies.Columns["releaseYearDataGridViewTextBoxColumn"].DisplayIndex = YEAR_COL;
            //gridMovies.Columns["ratingDataGridViewTextBoxColumn"].DisplayIndex = RATING_COL;
            //gridMovies.Columns["descriptionDataGridViewTextBoxColumn"].DisplayIndex = DESC_COL;
            //gridMovies.Columns["genresDataGridViewTextBoxColumn"].DisplayIndex = GENRE_COL;

            //gridMovies.Columns["movieTitleDataGridViewTextBoxColumn"].DataPropertyName = "MovieTitle";
            //gridMovies.Columns["releaseYearDataGridViewTextBoxColumn"].DataPropertyName = "ReleaseYear";
            //gridMovies.Columns["ratingDataGridViewTextBoxColumn"].DataPropertyName = "Rating";
            //gridMovies.Columns["descriptionDataGridViewTextBoxColumn"].DataPropertyName = "Description";
            //gridMovies.Columns["genresDataGridViewTextBoxColumn"].DataPropertyName = "Genres";

        }

        /// <summary>
        /// Event handler for the remove movie button. It removes the selected movie in the data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            string movieName = gridMovies.SelectedRows[0].Cells[TITLE_COL].Value.ToString();
            if (deleteMovie(movieName))
            {
                lblStatus.Text = "Movie Deleted";
                updateMovies();
            }
            else
            {
                lblStatus.Text = "Error Deleting movie";
            }
        }
    }
}
