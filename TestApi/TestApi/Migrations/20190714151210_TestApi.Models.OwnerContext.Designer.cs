﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApi.Models;

namespace TestApi.Migrations
{
    [DbContext(typeof(OwnerContext))]
    [Migration("20190714151210_TestApi.Models.OwnerContext")]
    partial class TestApiModelsOwnerContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestApi.Models.FleetData", b =>
                {
                    b.Property<long>("FleetRCNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FleetType")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<long>("OwnerId");

                    b.HasKey("FleetRCNo");

                    b.HasIndex("OwnerId");

                    b.ToTable("Fleets");
                });

            modelBuilder.Entity("TestApi.Models.OwnerData", b =>
                {
                    b.Property<long>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("OwnerContact")
                        .HasMaxLength(10);

                    b.Property<string>("OwnerEmail")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Ownerpass")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("OwnerId");

                    b.ToTable("Owner","dbo");

                    b.HasData(
                        new
                        {
                            OwnerId = 101L,
                            OwnerContact = 64737493L,
                            OwnerEmail = "qnwqn2@feen",
                            OwnerName = "Bob",
                            Ownerpass = "cbdcmbs"
                        },
                        new
                        {
                            OwnerId = 102L,
                            OwnerContact = 64737493L,
                            OwnerEmail = "qnwcsmklcm@feen",
                            OwnerName = "malkdm",
                            Ownerpass = "cbadjwu89bs"
                        });
                });

            modelBuilder.Entity("TestApi.Models.FleetData", b =>
                {
                    b.HasOne("TestApi.Models.OwnerData", "Owner")
                        .WithMany("Fleets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
