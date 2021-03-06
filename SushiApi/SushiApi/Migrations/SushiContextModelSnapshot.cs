// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SushiApi.Data;

namespace SushiApi.Migrations
{
    [DbContext(typeof(SushiContext))]
    partial class SushiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SushiApi.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerPhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SushiApi.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<decimal>("CustomerPayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderPlaced")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SushiApi.Models.Set", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Custom")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Sets");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cost = 20m,
                            Custom = false,
                            Name = "Hot shot",
                            Rating = 3
                        },
                        new
                        {
                            ID = 2,
                            Cost = 15m,
                            Custom = false,
                            Name = "Magura",
                            Rating = 4
                        },
                        new
                        {
                            ID = 3,
                            Cost = 30m,
                            Custom = false,
                            Name = "Pikachu",
                            Rating = 5
                        },
                        new
                        {
                            ID = 4,
                            Cost = 10m,
                            Custom = false,
                            Name = "Sakura",
                            Rating = 4
                        },
                        new
                        {
                            ID = 5,
                            Cost = 25m,
                            Custom = false,
                            Name = "Tokio",
                            Rating = 2
                        });
                });

            modelBuilder.Entity("SushiApi.Models.SetRatingHistory", b =>
                {
                    b.Property<int>("SetInRatingHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("SetID")
                        .HasColumnType("int");

                    b.HasKey("SetInRatingHistoryID");

                    b.HasIndex("SetID");

                    b.ToTable("SetRatingHistories");
                });

            modelBuilder.Entity("SushiApi.Models.SetsInOrders", b =>
                {
                    b.Property<int>("SetsInOrdersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("SetID")
                        .HasColumnType("int");

                    b.HasKey("SetsInOrdersID");

                    b.HasIndex("OrderID");

                    b.HasIndex("SetID");

                    b.ToTable("SetsInOrders");
                });

            modelBuilder.Entity("SushiApi.Models.Sushi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<decimal>("CostPerPiece")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sushis");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Amount = 1,
                            CostPerPiece = 2m,
                            Name = "Avocado maki"
                        },
                        new
                        {
                            ID = 2,
                            Amount = 1,
                            CostPerPiece = 3m,
                            Name = "California"
                        },
                        new
                        {
                            ID = 3,
                            Amount = 1,
                            CostPerPiece = 3m,
                            Name = "Dragon"
                        },
                        new
                        {
                            ID = 4,
                            Amount = 1,
                            CostPerPiece = 4m,
                            Name = "Kappa maki"
                        },
                        new
                        {
                            ID = 5,
                            Amount = 1,
                            CostPerPiece = 5m,
                            Name = "Karu maki"
                        },
                        new
                        {
                            ID = 6,
                            Amount = 1,
                            CostPerPiece = 7m,
                            Name = "Mais"
                        },
                        new
                        {
                            ID = 7,
                            Amount = 1,
                            CostPerPiece = 5m,
                            Name = "Sake maki"
                        },
                        new
                        {
                            ID = 8,
                            Amount = 1,
                            CostPerPiece = 8m,
                            Name = "Sake"
                        },
                        new
                        {
                            ID = 9,
                            Amount = 1,
                            CostPerPiece = 2m,
                            Name = "Salmon cheese"
                        },
                        new
                        {
                            ID = 10,
                            Amount = 1,
                            CostPerPiece = 5m,
                            Name = "Smoked salmon"
                        },
                        new
                        {
                            ID = 11,
                            Amount = 1,
                            CostPerPiece = 7m,
                            Name = "Special salmon"
                        },
                        new
                        {
                            ID = 12,
                            Amount = 1,
                            CostPerPiece = 5m,
                            Name = "Spicy tuna"
                        },
                        new
                        {
                            ID = 13,
                            Amount = 1,
                            CostPerPiece = 3m,
                            Name = "Sushi todi"
                        },
                        new
                        {
                            ID = 14,
                            Amount = 1,
                            CostPerPiece = 5m,
                            Name = "Torico"
                        },
                        new
                        {
                            ID = 15,
                            Amount = 1,
                            CostPerPiece = 10m,
                            Name = "Unagi"
                        });
                });

            modelBuilder.Entity("SushiApi.Models.SushiInSets", b =>
                {
                    b.Property<int>("SushiInSetsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SetID")
                        .HasColumnType("int");

                    b.Property<int?>("SushiAmount")
                        .HasColumnType("int");

                    b.Property<int>("SushiID")
                        .HasColumnType("int");

                    b.HasKey("SushiInSetsID");

                    b.HasIndex("SetID");

                    b.HasIndex("SushiID");

                    b.ToTable("SushiInSets");

                    b.HasData(
                        new
                        {
                            SushiInSetsID = 1,
                            SetID = 1,
                            SushiAmount = 4,
                            SushiID = 10
                        },
                        new
                        {
                            SushiInSetsID = 2,
                            SetID = 2,
                            SushiAmount = 3,
                            SushiID = 12
                        },
                        new
                        {
                            SushiInSetsID = 3,
                            SetID = 3,
                            SushiAmount = 5,
                            SushiID = 9
                        },
                        new
                        {
                            SushiInSetsID = 4,
                            SetID = 3,
                            SushiAmount = 4,
                            SushiID = 14
                        },
                        new
                        {
                            SushiInSetsID = 5,
                            SetID = 5,
                            SushiAmount = 5,
                            SushiID = 10
                        },
                        new
                        {
                            SushiInSetsID = 6,
                            SetID = 4,
                            SushiAmount = 2,
                            SushiID = 7
                        });
                });

            modelBuilder.Entity("SushiApi.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SushiApi.Models.Order", b =>
                {
                    b.HasOne("SushiApi.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SushiApi.Models.SetRatingHistory", b =>
                {
                    b.HasOne("SushiApi.Models.Set", "Set")
                        .WithMany()
                        .HasForeignKey("SetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Set");
                });

            modelBuilder.Entity("SushiApi.Models.SetsInOrders", b =>
                {
                    b.HasOne("SushiApi.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SushiApi.Models.Set", "Set")
                        .WithMany()
                        .HasForeignKey("SetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Set");
                });

            modelBuilder.Entity("SushiApi.Models.SushiInSets", b =>
                {
                    b.HasOne("SushiApi.Models.Set", "Set")
                        .WithMany("SushiInSets")
                        .HasForeignKey("SetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SushiApi.Models.Sushi", "Sushi")
                        .WithMany("SushiInSets")
                        .HasForeignKey("SushiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Set");

                    b.Navigation("Sushi");
                });

            modelBuilder.Entity("SushiApi.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SushiApi.Models.Set", b =>
                {
                    b.Navigation("SushiInSets");
                });

            modelBuilder.Entity("SushiApi.Models.Sushi", b =>
                {
                    b.Navigation("SushiInSets");
                });
#pragma warning restore 612, 618
        }
    }
}
