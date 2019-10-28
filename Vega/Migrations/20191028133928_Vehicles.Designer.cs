﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vega.Models;

namespace Vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    [Migration("20191028133928_Vehicles")]
    partial class Vehicles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vega.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cup holder"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Air condition"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Heated seats"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Automatic transmission"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Manual transmission"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Navigation"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Steel wheels"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Alloy wheels"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Heated windscreen"
                        });
                });

            modelBuilder.Entity("Vega.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Skoda"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Opel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Volkswagen"
                        });
                });

            modelBuilder.Entity("Vega.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MakeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MakeId = 1,
                            Name = "Fabia"
                        },
                        new
                        {
                            Id = 2,
                            MakeId = 1,
                            Name = "Octavia"
                        },
                        new
                        {
                            Id = 3,
                            MakeId = 1,
                            Name = "Rapid"
                        },
                        new
                        {
                            Id = 4,
                            MakeId = 2,
                            Name = "Insignia"
                        },
                        new
                        {
                            Id = 5,
                            MakeId = 2,
                            Name = "Astra"
                        },
                        new
                        {
                            Id = 6,
                            MakeId = 2,
                            Name = "Corsa"
                        },
                        new
                        {
                            Id = 7,
                            MakeId = 3,
                            Name = "A4"
                        },
                        new
                        {
                            Id = 8,
                            MakeId = 3,
                            Name = "A6"
                        },
                        new
                        {
                            Id = 9,
                            MakeId = 4,
                            Name = "Yaris"
                        },
                        new
                        {
                            Id = 10,
                            MakeId = 4,
                            Name = "Corolla"
                        },
                        new
                        {
                            Id = 11,
                            MakeId = 4,
                            Name = "Prius"
                        },
                        new
                        {
                            Id = 12,
                            MakeId = 5,
                            Name = "Polo"
                        },
                        new
                        {
                            Id = 13,
                            MakeId = 5,
                            Name = "Golf"
                        },
                        new
                        {
                            Id = 14,
                            MakeId = 5,
                            Name = "Passat"
                        },
                        new
                        {
                            Id = 15,
                            MakeId = 5,
                            Name = "Tiguan"
                        });
                });

            modelBuilder.Entity("Vega.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailContact")
                        .HasMaxLength(255);

                    b.Property<int>("ModelId");

                    b.Property<string>("PhoneContact")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Vega.Models.Model", b =>
                {
                    b.HasOne("Vega.Models.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vega.Models.Vehicle", b =>
                {
                    b.HasOne("Vega.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
