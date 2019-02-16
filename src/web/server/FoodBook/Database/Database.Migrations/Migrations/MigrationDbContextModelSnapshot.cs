﻿// <auto-generated />
using System;
using FoodBook.Database.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodBook.Database.Migrations.Migrations
{
    [DbContext(typeof(MigrationDbContext))]
    partial class MigrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("FoodBook.Domain.Entities.Entities.UserAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Login");

                    b.Property<string>("SecurityStamp");

                    b.HasKey("Id")
                        .HasName("UserAccountId");

                    b.HasAlternateKey("Email");

                    b.ToTable("UserAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
