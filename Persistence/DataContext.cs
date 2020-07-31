using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<Value> Values {get; set;} //Values is the table name in SQLite
        //Protected means it's only accessible in the class it's defined in and any derived classes from this class
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Value>()
            .HasData(
                new Value {Id = 1, Name = "Value 101"},
                new Value {Id = 2, Name = "Value 102"},
                new Value {Id = 3, Name = "Value 103"}
            );
        }
    }
}
