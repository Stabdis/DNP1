using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CinemaContext())
            {


            }
    }

    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    } 
    
    public class Stage
    {
        public int StageId { get; set; }

        public virtual List<Seat> Seats { get; set; }
    }

    public class Seat
    {
        public int SeatId { get; set; }

        public int StageId { get; set; }
        public virtual Stage Stage { get; set; }
    }

    public class CinemaContext : DbContext
    { 
        public DbSet<Movie> Movies { get; set; }
    }

}
