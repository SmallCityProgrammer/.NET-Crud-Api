using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Estudantes
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    public class AppDbContext : DbContext
    {
        private DbSet<Estudante> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Server=DESKPC\\SQLEXPRESS;Database=BloggieDb;Trusted_Connection=True;TrustServerCertificate=Yes");
            base.OnConfiguring(optionsBuilder);
        }
    }
}