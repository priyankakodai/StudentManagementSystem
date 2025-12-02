using StudentWebApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace StudentWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Marks> Marks { get; set; }
    }


}

