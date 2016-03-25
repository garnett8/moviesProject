using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public MovieDetails()
        {
            InitializeComponent();
            lblDetailsStatus.Text = "";
        }

        public MovieDetails(Movie movie)
        {
            InitializeComponent();
            theMovie = movie;
            lblDetailsStatus.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                // Create a new movie object locally for now
                int releaseYear, rating;
                int.TryParse(txtYearReleased.Text, out releaseYear);
                int.TryParse(txtMovieRating.Text, out rating);
                string genres = getGenreString();

                theMovie = new Movie(txtMovieTitle.Text, releaseYear, rating, txtMovieDesc.Text, genres);
                // Save new movie to the database
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
