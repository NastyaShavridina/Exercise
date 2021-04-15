using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
