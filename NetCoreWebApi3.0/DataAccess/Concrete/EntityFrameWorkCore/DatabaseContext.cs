using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApi3._0.Entity;
using NetCoreWebApi3._0.Models;

namespace NetCoreWebApi3._0.DataAccess.Concrete.EntityFrameWorkCore
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
        {
            
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DENIZ-PC;Database=WebApiDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person()
            {
                Id = 1,
                Name = "Deniz",
                Gender = "Male"
            });
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<NetCoreWebApi3._0.Models.PersonListModel> PersonListModel { get; set; }
    }
}
