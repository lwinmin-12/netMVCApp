using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using netMvcApp.Models;

namespace netMvcApp.EFCoreExamples
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "netConsole",
                UserID = "sa",
                Password = "Asdffdsa4580",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(_sqlConnectionStringBuilder.ConnectionString);
        }
        public DbSet<BlogModel> Blog { set; get; }

    }
}