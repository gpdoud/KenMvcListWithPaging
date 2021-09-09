using System;
using KenMvcListWithPaging.Models;
using Microsoft.EntityFrameworkCore;

namespace KenMvcListWithPaging.Data {

    public class AppDbContext : DbContext {

        public DbSet<Log> Logs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
