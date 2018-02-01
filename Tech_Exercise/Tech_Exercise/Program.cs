using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using static Tech_Exercise.Models.MusicLibraryModel;
using Tech_Exercise.Data;

namespace Tech_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InsertData();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        private static void InsertData()
        {
            using (var context = new MusicLibraryContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();


                // Saves changes
                context.SaveChanges();
            }
        }
    }

}
