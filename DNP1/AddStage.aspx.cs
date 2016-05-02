using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DNP1
{
    public partial class AddStage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                ShowStages();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var title = TextBox1.Text;
                int NumberOfSeats = Convert.ToInt32(TextBox2.Text);

                Stage Stage = new Stage() { Title = title };
                db.Stages.Add(Stage);

                List<Seat> Seats = new List<Seat>();

                for (int i = 0; i < NumberOfSeats; i++)
                {
                    Seat newSeat = new Seat();
                    newSeat.StageId = Stage.StageId;
                    newSeat.Number = i;
                    db.Seats.Add(newSeat);
                }

                db.SaveChanges();

                Label1.Text = "New Stage " + title + " added & new seats created!";

                ShowStages();
            }
        }

        private void ShowStages()
        {
            using (var db = new CinemaContext())
            {
                List<Stage> stages = new List<Stage>();

                var query = from b in db.Stages
                            orderby b.Title
                            select b;

                foreach (var item in query)
                {
                    stages.Add((Stage)item);
                }

                ListBox1.DataSource = stages;
                ListBox1.DataTextField = "Title";
                ListBox1.DataValueField = "StageId";
                ListBox1.DataBind();
            }
        }
    }
}