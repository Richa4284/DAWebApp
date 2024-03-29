﻿// <auto-generated />
using LocationApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocationApi.Migrations
{
    [DbContext(typeof(LocationContext))]
    partial class LocationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocationApi.Models.LocationInfo", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FleetID");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("LocationID");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationID = 1,
                            FleetID = 1,
                            Latitude = 23.235323000000001,
                            Longitude = 90.392723000000004
                        },
                        new
                        {
                            LocationID = 2,
                            FleetID = 2,
                            Latitude = 53.235323000000001,
                            Longitude = 73.472921999999997
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
