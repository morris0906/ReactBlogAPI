using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAppAPI.Models
{
    public partial class my_app_context : DbContext
    {
        public my_app_context() { }
        
        public my_app_context(DbContextOptions<my_app_context> options) : base(options) { }
        
        public DbSet<Post> Post { get; set; }
        
        public static System.Collections.Specialized.NameValueCollection AppSettings { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();

            optionsBuilder.UseSqlServer("Server=tcp:msa2020.database.windows.net,1433;Initial Catalog=MSADB;Persist Security Info=False;User ID=HanLee;Password=lee@16-76062096;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.Content).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}