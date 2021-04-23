using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        delegate string Mydelegate();

        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            DataRead dataRead = new DataRead();

            DataOperate dataOperate = new DataOperate();

            Mydelegate mydelegate = new Mydelegate(dataRead.ReadSubjectName);

            mydelegate += dataRead.ReadStudentFirstName;

            mydelegate += dataRead.ReadStudentLastName;

            foreach (Mydelegate item in mydelegate.GetInvocationList())
            {
                list.Add(item());
            }

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

            Console.Read();

            dataOperate.Operation(options, list[0], list[1], list[2]);

        }
    }
}
