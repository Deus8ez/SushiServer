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
        public DbSet<SushiInSets> SushiInSets { get; set; }
        public DbSet<SetRatingHistory> SetRatingHistories { get; set; }

        public SushiContext(DbContextOptions<SushiContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("JobConnString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sushi>().HasData(
                new Sushi
                {
                    ID = 1,
                    Name = "Avocado maki",
                    CostPerPiece = 2,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 2,
                    Name = "California",
                    CostPerPiece = 3,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 3,
                    Name = "Dragon",
                    CostPerPiece = 3,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 4,
                    Name = "Kappa maki",
                    CostPerPiece = 4,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 5,
                    Name = "Karu maki",
                    CostPerPiece = 5,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 6,
                    Name = "Mais",
                    CostPerPiece = 7,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 7,
                    Name = "Sake maki",
                    CostPerPiece = 5,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 8,
                    Name = "Sake",
                    CostPerPiece = 8,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 9,
                    Name = "Salmon cheese",
                    CostPerPiece = 2,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 10,
                    Name = "Smoked salmon",
                    CostPerPiece = 5,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 11,
                    Name = "Special salmon",
                    CostPerPiece = 7,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 12,
                    Name = "Spicy tuna",
                    CostPerPiece = 5,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 13,
                    Name = "Sushi todi",
                    CostPerPiece = 3,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 14,
                    Name = "Torico",
                    CostPerPiece = 5,
                    Amount = 1
                },
                new Sushi
                {
                    ID = 15,
                    Name = "Unagi",
                    CostPerPiece = 10,
                    Amount = 1
                }
            );

            modelBuilder.Entity<Set>().HasData(
                new Set
                {
                    ID = 1,
                    Name = "Hot shot",
                    Cost = 20,
                    Custom = false,
                    Rating = 3
                },
                new Set
                {
                    ID = 2,
                    Name = "Magura",
                    Cost = 15,
                    Custom = false,
                    Rating = 4
                },
                new Set
                {
                    ID = 3,
                    Name = "Pikachu",
                    Cost = 30,
                    Custom = false,
                    Rating = 5
                },
                new Set
                {
                    ID = 4,
                    Name = "Sakura",
                    Cost = 10,
                    Custom = false,
                    Rating = 4
                },
                new Set
                {
                    ID = 5,
                    Name = "Tokio",
                    Cost = 25,
                    Custom = false,
                    Rating = 2
                }
            );

            modelBuilder.Entity<SushiInSets>().HasData(
                new SushiInSets
                {
                    SushiInSetsID = 1,
                    SetID = 1,
                    SushiID = 10,
                    SushiAmount = 4
                },
                new SushiInSets
                {
                    SushiInSetsID = 2,
                    SetID = 2,
                    SushiID = 12,
                    SushiAmount = 3
                },
                new SushiInSets
                {
                    SushiInSetsID = 3,
                    SetID = 3,
                    SushiID = 9, 
                    SushiAmount = 5
                },
                new SushiInSets
                {
                    SushiInSetsID = 4,
                    SetID = 3,
                    SushiID = 14,
                    SushiAmount = 4
                },
                new SushiInSets
                {
                    SushiInSetsID = 5,
                    SetID = 5,
                    SushiID = 10,
                    SushiAmount = 5
                },
                new SushiInSets
                {
                    SushiInSetsID = 6,
                    SetID = 4,
                    SushiID = 7,
                    SushiAmount = 2
                }
            );
        }
    }
}
