using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());
    
            builder.AddJsonFile("appsettings.json");
   
            var config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");


            DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            var options = optionsBuilder
             .UseSqlServer(connectionString)
             .Options;

            using (ApplicationContext db = new ApplicationContext(options))
            {
                
            }
            Console.Read();


        }
    }
}
