using Microsoft.EntityFrameworkCore;
using SushiApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Data
{
    public class SushiContext : DbContext
    {
        public DbSet<Sushi> Sushis { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SetsInOrders> SetsInOrders { get; set; }
        public DbSet<User> Users { get; set; }

        public SushiContext(DbContextOptions<SushiContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("HomeConnString");
            }
        }
    }
}
