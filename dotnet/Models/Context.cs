using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class Context : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./db/database.db");
        }
    }
}