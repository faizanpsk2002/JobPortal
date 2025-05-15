using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi.Model;

namespace WebApi.Data

{
    public class JobPortalDbContext : DbContext
    {
        public JobPortalDbContext(DbContextOptions<JobPortalDbContext> options)
       : base(options) { }

        
        public DbSet<User> Users { get; set; }
    }
}
