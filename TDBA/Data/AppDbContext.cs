using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;  
using TDBA.Data;
using TDBA.Services;

namespace TDBA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EventModel> Events { get; set; }
    }
}
