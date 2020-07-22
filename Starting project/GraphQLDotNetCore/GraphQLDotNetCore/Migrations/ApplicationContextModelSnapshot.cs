﻿// <auto-generated />
using System;
using GraphQLDotNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQLDotNetCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b88fa14f-0444-4014-b093-8cffd3456675"),
                            Description = "Cash account for our users",
                            OwnerId = new Guid("f823b9b8-6390-4acb-b873-dd5bc9daf12f"),
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("0681d722-79f4-4df8-aede-14f58b7dfe2e"),
                            Description = "Savings account for our users",
                            OwnerId = new Guid("98153f44-7cf6-418a-bc4c-1d9380e7abf5"),
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("29dc76c2-5332-4d16-96cc-08f610de2bbe"),
                            Description = "Income account for our users",
                            OwnerId = new Guid("98153f44-7cf6-418a-bc4c-1d9380e7abf5"),
                            Type = 3
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f823b9b8-6390-4acb-b873-dd5bc9daf12f"),
                            Address = "John Doe's address",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("98153f44-7cf6-418a-bc4c-1d9380e7abf5"),
                            Address = "Jane Doe's address",
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.HasOne("GraphQLDotNetCore.Entities.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
