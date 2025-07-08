using E_Commerce_Website_Backend.Models;
using ECommerceBackendAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerceBackendAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

       public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}