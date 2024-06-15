using Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Connection : DbContext
    {
        public DbSet<Film> Films { get; set; }  
        public DbSet<Actor> Actors { get; set; }  
        public DbSet<FilmToActor> FilmToActors { get; set; }  
        public DbSet<FilmToGenre> FilmToGenre { get; set; }  
        public DbSet<Genre> Genre { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @"Data Source=(localdb)\\MSSQLLocalDB;
                            Initial Catalog=db.KinoKiosk;
                            Integrated Security=True;
                            Trust Server Certificate=True;";
            optionsBuilder.UseSqlServer(path);
        }
    }
}
