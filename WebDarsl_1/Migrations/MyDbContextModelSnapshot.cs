﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDarsl_1.AddDbContext;

#nullable disable

namespace WebDarsl_1.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebDarsl_1.Models.Hodim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("familya")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jins")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("maosh")
                        .HasColumnType("float");

                    b.Property<int>("yosh")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hodims");
                });
#pragma warning restore 612, 618
        }
    }
}
