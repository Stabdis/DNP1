namespace DNP1
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class CinemaContext : DbContext
    {
        // Your context has been configured to use a 'CinemaContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DNP1.CinemaContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CinemaContext' 
        // connection string in the application configuration file.
        public CinemaContext()
            : base("name=CinemaContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
    }

    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

        public virtual List<CreditCard> CreditCards { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }

    public class CreditCard
    {
        public int CardId { get; set; }
        public string Number { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CvcCode { get; set; }
        
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }

    public class Stage
    {
        public int StageId { get; set; }
        public string Title { get; set; }

        public virtual List<Seat> Seats { get; set; }
    }

    public class Seat
    {
        public int SeatId { get; set; }
        public int Number { get; set; }
        
        public int StageId { get; set; }
        public virtual Stage Stage { get; set; }
    }

    public class MovieSession
    {
        public int MovieSessionId { get; set; }
        public float price { get; set; }
        public DateTime SessionDate { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int StageId { get; set; }
        public virtual Stage Stage { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }

    public class Reservation
    {
        public int ReservationId { get; set; }
        public float PricePayed { get; set; }

        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }

        public int MovieSessionId { get; set; }
        public virtual MovieSession MovieSession { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CreditCardId { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }

}