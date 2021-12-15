using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class DatabaseContext : DbContext
    {
        private readonly DbContextOptions options;
        private readonly IConfiguration configuration;

        public DatabaseContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.options = options;
            this.configuration = configuration;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
        public DbSet<Student> Students { get; set; }
    }
}
