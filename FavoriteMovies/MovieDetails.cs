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
    
    public partial class MovieDetails : Form
    {
        private Movie theMovie;
        private Movie originalMovie;
        private string queryInsert = @"INSERT INTO dbo.Movies(MovieTitle, Description, ReleaseYear, Genres, Rating) VALUES(@title, @description, @year, @genre, @rating)";
        private string queryUpdate = @"UPDATE dbo.Movies SET Description = @description, ReleaseYear = @year, Genres = @genre, Rating = @rating WHERE MovieTitle = @title";
        private bool updating = false;

        // Need to replace local path with variable path.
        private string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaron\documents\visual studio 2015\Projects\FavoriteMovies\FavoriteMovies\MovieDatabase.mdf;Integrated Security=True";
        
        // Regular constructor, typically used when inserting a new movie
        public MovieDetails()
        {
            InitializeComponent();
            lblDetailsStatus.Text = "";
        }

        // this contrsuctor is called when we want to update an existing movie.
        public MovieDetails(Movie movie)
        {
            updating = true;
            InitializeComponent();
            originalMovie = movie;
            lblDetailsStatus.Text = "";

            // put this in its own method when the time comes
            // We are updating an existing movie
            txtMovieDesc.Text = originalMovie.getMovieDesc();
            txtMovieRating.Text = originalMovie.getMovieRating().ToString();
            txtMovieTitle.Text = originalMovie.getMovieTitle();
            txtYearReleased.Text = originalMovie.getYearReleased().ToString();


            // Set the selected check boxes for genres.
            if(originalMovie.getGenres().IndexOf("Comedy") != -1)
            {
                chkComedy.Checked = true;
            }
            if(originalMovie.getGenres().IndexOf("Adventure") != -1)
            {
                chkAdventure.Checked = true;
            }
            if(originalMovie.getGenres().IndexOf("Drama") != -1)
            {
                chkDrama.Checked = true;
            }
            if(originalMovie.getGenres().IndexOf("Action") != -1)
            {
                chkAction.Checked = true;
            }
            if(originalMovie.getGenres().IndexOf("Scary") != -1)
            {
                chkScary.Checked = true;
            }

            // Disable the movie title since it is used to find an existing movie
            txtMovieTitle.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // If we are not updating, we are inserting a new movie into the DB.
            if (validateInput() && !updating)
            {
                // Create a new movie object locally for now
                int releaseYear, rating;
                int.TryParse(txtYearReleased.Text, out releaseYear);
                int.TryParse(txtMovieRating.Text, out rating);
                string genres = getGenreString();
                
                theMovie = new Movie(txtMovieTitle.Text, releaseYear, rating, txtMovieDesc.Text, genres);

                try
                {
                    // Save new movie to the database
                    using (var dbConnection = new SqlConnection(dbConnectionString))
                    using (var dbCommand = new SqlCommand(queryInsert, dbConnection))
                    {
                        dbConnection.Open();

                        dbCommand.Parameters.AddWithValue("@title", theMovie.getMovieTitle());
                        dbCommand.Parameters.AddWithValue("@description", theMovie.getMovieDesc());
                        dbCommand.Parameters.AddWithValue("@year", theMovie.getYearReleased());
                        dbCommand.Parameters.AddWithValue("@genre", theMovie.getGenres());
                        dbCommand.Parameters.AddWithValue("@rating", theMovie.getMovieRating());

                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                        MovieView.movieList.Add(theMovie);
                    }
                    this.Close();
                }
                catch(Exception ex)
                {
                    lblDetailsStatus.Text = ex.Message;
                }
            }
            else if(validateInput() && updating)
            {
                int releaseYear, rating;
                int.TryParse(txtYearReleased.Text, out releaseYear);
                int.TryParse(txtMovieRating.Text, out rating);
                string genres = getGenreString();

                theMovie = new Movie(txtMovieTitle.Text, releaseYear, rating, txtMovieDesc.Text, genres);

                try
                {
                    // Save new movie info to the database
                    using (var dbConnection = new SqlConnection(dbConnectionString))
                    using (var dbCommand = new SqlCommand(queryUpdate, dbConnection))
                    {
                        dbConnection.Open();

                        dbCommand.Parameters.AddWithValue("@title", theMovie.getMovieTitle());
                        dbCommand.Parameters.AddWithValue("@description", theMovie.getMovieDesc());
                        dbCommand.Parameters.AddWithValue("@year", theMovie.getYearReleased());
                        dbCommand.Parameters.AddWithValue("@genre", theMovie.getGenres());
                        dbCommand.Parameters.AddWithValue("@rating", theMovie.getMovieRating());

                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();

                        int index = MovieView.movieList.FindIndex(a => a.getMovieTitle() == theMovie.getMovieTitle());
                        MovieView.movieList.RemoveAt(index);
                        MovieView.movieList.Add(theMovie);
                   
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    lblDetailsStatus.Text = ex.Message;
                }
            }
        }


        /// <summary>
        /// This method validates the movie entry input by caling each text boxes
        /// specific validation method.
        /// </summary>
        private bool validateInput()
        {
            bool status = true; 

            if (!validateTitle())
            {
                lblDetailsStatus.Text = "Please enter a movie title";
                status = false;
            }
            else if (!validateYearReleased())
            {
                lblDetailsStatus.Text = "Please enter a legitimate movie released year";
                status = false;
            }
            else if (!validateMovieRating())
            {
                lblDetailsStatus.Text = "Please enter an integer between 0 and 10 for the rating";
                status = false;
            }
            else if (!validateMovieDesc())
            {
                lblDetailsStatus.Text = "Please enter a description for the movie";
                status = false;
            }
            else if (!validateGenres())
            {
                lblDetailsStatus.Text = "Please select at least one movie genre";
                status = false;
            }

            return status;
        }

        /// <summary>
        /// Validates that the movie title isn't blank
        /// </summary>
        /// <returns></returns>
        private bool validateTitle()
        {
            return !txtMovieTitle.Text.Equals("");
        }

        /// <summary>
        /// Validates that the year released is numeric
        /// </summary>
        /// <returns></returns>
        private bool validateYearReleased()
        {
            int result;
            return int.TryParse(txtYearReleased.Text, out result);
        }

        /// <summary>
        /// Verifies the rating is between 0 and 10
        /// </summary>
        /// <returns></returns>
        private bool validateMovieRating()
        {
            int result;
            return int.TryParse(txtMovieRating.Text, out result) && result <= 10 && result >= 0;
        }

        /// <summary>
        /// Validates if the movie description is blank or not.
        /// </summary>
        /// <returns></returns>
        private bool validateMovieDesc()
        {
            return !txtMovieDesc.Text.Equals("");
        }

        /// <summary>
        /// Ensure at least one check box is checked for a movie genre.
        /// </summary>
        /// <returns></returns>
        private bool validateGenres()
        {
            return chkAction.Checked || chkAdventure.Checked || chkComedy.Checked
                || chkDrama.Checked || chkScary.Checked;
        }


        /// <summary>
        /// Returns the list of genres as one string
        /// </summary>
        /// <returns></returns>
        public string getGenreString()
        {
            string genres = "";
            char[] trimChars = { ',', ' ' };
            if (chkAction.Checked)
            {
                genres += "Action, ";
            }
            if (chkAdventure.Checked)
            {
                genres += "Adventure, ";
            }
            if (chkComedy.Checked)
            {
                genres += "Comedy, ";
            }
            if (chkDrama.Checked)
            {
                genres += "Drama, ";
            }
            if (chkScary.Checked)
            {
                genres += "Scary, ";
            }

            genres = genres.TrimEnd(trimChars);


            return genres;
        }

        /// <summary>
        /// Closes the Movie Details From
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
