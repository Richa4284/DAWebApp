﻿// <auto-generated />
using FleetApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FleetApi.Migrations
{
    [DbContext(typeof(FleetContext))]
    [Migration("20190716152540_FleetApi.Models.FleetContextSeed")]
    partial class FleetApiModelsFleetContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FleetApi.Models.FleetData", b =>
                {
                    b.Property<long>("FleetID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("FleetRCNo")
                        .HasMaxLength(17);

                    b.Property<string>("FleetType")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<long>("OwnerId");

                    b.HasKey("FleetID");

                    b.ToTable("Fleets");

                    b.HasData(
                        new
                        {
                            FleetID = 1L,
                            CompanyName = "ssjfksef",
                            FleetRCNo = 43823462L,
                            FleetType = "Car",
                            OwnerId = 102L
                        },
                        new
                        {
                            FleetID = 2L,
                            CompanyName = "sfhjhsfr",
                            FleetRCNo = 11478545L,
                            FleetType = "Truck",
                            OwnerId = 102L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
