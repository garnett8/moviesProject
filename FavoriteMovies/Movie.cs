using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Movie data object that contains the information pertaining to
/// a movie entry. (Title, Rating, Release Year, Description, and Genre(s))
/// </summary>
namespace FavoriteMovies
{
    public class Movie
    {
        private string movieTitle;  //Title of the movie
        private int yearReleased;   // Year the movie was released
        private int movieRating;    // The user rating of the movie 0-10
        private string movieDesc;   // the movie description
        private string genres;      // the genres pertaining to the movie.

        public Movie(string movieTitle, int yearReleased, int movieRating,
            string movieDesc, string genres)
        {
            this.movieTitle = movieTitle;
            this.yearReleased = yearReleased;
            this.movieRating = movieRating;
            this.movieDesc = movieDesc;
            this.genres = genres;
        }

        /// <summary>
        /// Returns the title of this movie
        /// </summary>
        /// <returns>title</returns>
        public string getMovieTitle()
        {
            return movieTitle;
        }
        
        /// <summary>
        /// Returns the year released of this movie
        /// </summary>
        /// <returns>year</returns>
        public int getYearReleased()
        {
            return yearReleased;
        }

        /// <summary>
        /// Returns the rating of the movie
        /// </summary>
        /// <returns>a rating</returns>
        public int getMovieRating()
        {
            return movieRating;
        }

        /// <summary>
        /// Returns a description of this movie.
        /// </summary>
        /// <returns>description</returns>
        public string getMovieDesc()
        {
            return movieDesc;
        }

        /// <summary>
        /// Returns the list of selected genres in a string format.
        /// </summary>
        /// <returns></returns>
        public string getGenres()
        {
            return genres;
        }
    }
}
