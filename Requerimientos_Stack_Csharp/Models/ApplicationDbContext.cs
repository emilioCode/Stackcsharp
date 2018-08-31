using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Requerimientos_Stack_Csharp.Models
{
    public class ApplicationDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);          
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=pubs;Persist Security Info=True;User ID=sa");

        //    //"Data Source=.;Initial Catalog=pubs;Integrated Security=True"
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                //.AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Libro> Libros { get; set; }
    }
    public class Libro
    {
        public int ID { get; set; }
        public string AUTOR { get; set; }
        public string VENDIDOS { get; set; }
        public DateTime FECHA { get; set; }      
    }
}
