using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class AppContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MUHAMMETAZIZ\\SQLEXPRESS;Database=WorksAndProjectsDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        
        public DbSet<Product>Products { get; set; }=null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
    }
}
