using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using JokiaRegistration.Models;


    namespace JokiaRegistration.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Staff> Staff { get; set; }
            public DbSet<StaffEntryExit> StaffEntryExits { get; set; }
        }
    }


