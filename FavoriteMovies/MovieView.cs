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
    public partial class MovieView : Form
    {

        public MovieView()
        {
            InitializeComponent();
            
        }

        private void MovieView_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
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
    }
}
