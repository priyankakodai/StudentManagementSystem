<<<<<<< HEAD
﻿using StudentWebApp.Models;
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


=======
﻿using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Marks> Marks { get; set; }
    }
>>>>>>> bdb365cb097ab2d431762969e71c4587c82a328c
}

