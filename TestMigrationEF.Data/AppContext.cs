using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestMigrationEF.Data.Models;

namespace TestMigrationEF.Data
{
    public class AppContext : DbContext
    {
        private string ConnectionString = @"Data Source=LAPTOP-JF7SEDRL\SQLEXPRESS;Initial Catalog=TestMigration2;Integrated Security=true";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Persona> Persons { get; set; }
    }
}
