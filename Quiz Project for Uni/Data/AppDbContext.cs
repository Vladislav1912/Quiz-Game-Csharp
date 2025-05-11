using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Project_for_Uni.Data
{
     public class AppDbContext : DbContext 
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-27HBL35\\MSSQLSERVER01;Database=QuizGame;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        
    }
}
