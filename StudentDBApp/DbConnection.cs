using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentDBApp
{
    public class DbConnection : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PRASHANTH\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;
          TrustServerCertificate=True;");
        }
    }
}
