using Efcore1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore1.Context
{
    public class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=USERK\\SQLEXPRESS;Database=RouteLibrary;Trusted_Connection=True;Trust Server Certificate=True; ");


        }

        public DbSet<Book> books { get; set; }

        public DbSet<Author > authors { get; set; }

        public DbSet<Category> categories { get; set; }
    }
}
