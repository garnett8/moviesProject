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

/// <summary>
/// Main form of the final project. It allows the user to view movies they have added to their list so that 
/// they can go back and review movies they really liked.
/// </summary>
namespace FavoriteMovies
{
    public partial class MovieView : Form
    {
        private const int TITLE_COL = 0;
        private const int DESC_COL = 1;
        private const int YEAR_COL = 2;
        private const int GENRE_COL = 3;
        private const int RATING_COL = 4;

        // Database strings
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

        /// <summary>
        /// Load method. Instantiate a list of movies and load the movies  to the dgv from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieView_Load(object sender, EventArgs e)
        {
            
            lblStatus.Text = "";
           
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
                        refreshDGV();
                    }
                }
            }
            catch (Exception e)
            {
                lblStatus.Text = "Error loading movies from DB";
            }
        }

        /// <summary>
        /// Helper method that refreshes the DGV 
        /// with data from the DB
        /// </summary>
        private void refreshDGV()
        {
            // Now Refresh the datagrid view
            dataAdapter = new SqlDataAdapter(selectQuery, dbConnectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            bs.DataSource = table;
            gridMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    resetStatusLabel();
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
            loadMoviesFromDB();
            resetStatusLabel();
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
                Movie editMovie = getMovieFromDGV();

                MovieDetails movieDetails = new MovieDetails(editMovie);
                movieDetails.ShowDialog();
                loadMoviesFromDB();
                resetStatusLabel();
            }
            catch(Exception ex)
            {
                lblStatus.Text = "Please select a movie or add a movie to edit";
            }
        }

        /// <summary>
        /// Returns the selected movie in the DGV as an object.
        /// </summary>
        /// <returns></returns>
        private Movie getMovieFromDGV()
        {
            string title = getSelectedMovieTitle();

            // Grab the movie that is selected in the DGV and return it
            Movie editMovie = movieList.Find(a => a.getMovieTitle() == title);

            return editMovie;
        }


        /// <summary>
        /// Returns the selected movie's title in the DGV
        /// </summary>
        /// <returns></returns>
        private string getSelectedMovieTitle()
        {
            return gridMovies.SelectedRows[0].Cells[TITLE_COL].Value.ToString();
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
                loadMoviesFromDB();
            }
            else
            {
                lblStatus.Text = "Error Deleting movie";
            }
        }

        /// <summary>
        /// Helper method to reset the status label.
        /// </summary>
        private void resetStatusLabel()
        {
           lblStatus.Text = "";
        }
    }
}
