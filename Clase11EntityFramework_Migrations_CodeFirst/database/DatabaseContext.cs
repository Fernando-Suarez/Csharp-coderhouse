using Clase11EntityFramework_Migrations_CodeFirst.models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11EntityFramework_Migrations_CodeFirst.database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=coder50285;Trusted_Connection=true; TrustServerCertificate=true;");


        }
    }
}
