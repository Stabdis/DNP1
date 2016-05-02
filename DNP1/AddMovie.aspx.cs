using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DNP1
{
    public partial class AddMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                ShowMovies();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                // Create and save a new Blog 
                var title = TextBox1.Text;

                var movie = new Movie { Title = title };
                db.Movies.Add(movie);
                db.SaveChanges();

                Label1.Text = "New movie " + title + " added!";

                ShowMovies();

            }


        }

        private void ShowMovies()
        {
            using (var db = new CinemaContext())
            {
                List<Movie> movies = new List<Movie>();

                var query = from b in db.Movies
                            orderby b.Title
                            select b;

                foreach (var item in query)
                {
                    movies.Add((Movie)item);
                }

                ListBox1.DataSource = movies;
                ListBox1.DataTextField = "Title";
                ListBox1.DataValueField = "MovieId";
                ListBox1.DataBind();
            }
        }
    }
}