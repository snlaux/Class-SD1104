using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.IO;
namespace Slaux_Lab_11_5
{
    class SakilaContext : DbContext
    {
        public DbSet<Film> Film { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=Sakila;Trusted_Connection=True;");
        }
    }

    class Film
    {
        [Key]
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string release_year { get; set; }
        public byte language_id { get; set; }
        public byte original_language_id { get; set; }
        public byte rental_duration { get; set; }
        public decimal rental_rate { get; set; }
        public Int16 length { get; set; }
        public decimal replacement_cost { get; set; }
        public string rating { get; set; }
        public string special_features { get; set; }
        public DateTime last_update { get; set; }

        public Film(string title, string description, string release_year, byte language_id, byte original_language_id,
            byte rental_duration, decimal rental_rate, Int16 length, decimal replacement_cost, string rating, string special_features)
        {
            this.title = title;
            this.description = description;
            this.release_year = release_year;
            this.language_id = language_id;
            this.original_language_id = original_language_id;
            this.rental_duration = rental_duration;
            this.rental_rate = rental_rate;
            this.length = length;
            this.replacement_cost = replacement_cost;
            this.rating = rating;
            this.special_features = special_features;
            this.last_update = DateTime.Now;
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            SakilaContext sakila = new SakilaContext();
            //This code adds new movies to the database. I only wanted to run it once to avoid duplicates

            /*Film nineteenSeventeen = new Film("1917", "War Drama by Director Sam Mendes", 2019,1,1, 3, 5.99, 179, 19.99, "R", "Deleted Scenes");
            Film joker = new Film("Joker", "Oscar Nominated Superhero Drama", 2019, 1, 1, 3, 6.99, 182, 23.99, "R", "Deleted Scenes");
            Film StarWarsTheRiseOfSkyWalker = new Film("Star Wars the Rise of Skywalker", "Trash Disney Fan-fic", 2019, 1, 1, 3, 4.99, 202, 21.99, "PG-13", "Trailers");
            sakila.Film.Add(nineteenSeventeen);
            sakila.Film.Add(joker);
            sakila.Film.Add(StarWarsTheRiseOfSkyWalker);
            sakila.SaveChanges();
            */
            Film[] everyFilm = sakila.Film.ToArray();

            List<Film> linqlist = (from i in everyFilm
                                   where i.release_year.Equals("2019")
                                   select i).ToList();
         
            StringBuilder myHtml = new StringBuilder();
            myHtml.Append("<html>\n<body>\n<h1>Newly Released Movies</h1>\n<ul>\n");
           
            foreach (Film f in linqlist)
            {
                myHtml.Append("<li>" + "Title: " + f.title + " " + "Description: " + f.description + "</li>\n");
            }
            myHtml.Append("</ul>\n</body>\n</html>");
            Console.WriteLine(myHtml);
            string htmlFile = "D:\\Generated HTML\\newMovies.html";
            File.WriteAllText(htmlFile, myHtml.ToString());
        }
    }
}
