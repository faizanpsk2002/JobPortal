using Job.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore; // <-- IMPORTANT: Use this, not Microsoft.AspNetCore.Builder
using System.Collections.Generic;

namespace Job.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }              // plural naming convention
        public DbSet<JobModel> Job { get; set; }           // rename 'Job' class to 'JobModel' to avoid conflict
        public DbSet<Application> JobApplication { get; set; }  // fix class name to match your model
    }
}
