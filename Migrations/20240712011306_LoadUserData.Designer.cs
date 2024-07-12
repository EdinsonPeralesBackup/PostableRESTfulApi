﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostableRESTfulApi.Data;

#nullable disable

namespace PostableRESTFulApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240712011306_LoadUserData")]
    partial class LoadUserData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PostableRESTfulApi.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("PostId", "UserId")
                        .IsUnique();

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("PostableRESTfulApi.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("PostableRESTfulApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2607),
                            Email = "edi_perales@neelvat.com",
                            FirstName = "Edinson",
                            LastName = "Perales",
                            Password = "123456",
                            Role = "Admin",
                            UserName = "EdinsonPerales"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2626),
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "password1",
                            Role = "User",
                            UserName = "JohnDoe"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2627),
                            Email = "jane_smith@example.com",
                            Password = "password2",
                            Role = "User",
                            UserName = "JaneSmith"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2629),
                            FirstName = "Mike",
                            Password = "password3",
                            Role = "User",
                            UserName = "MikeBrown"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2631),
                            LastName = "Connor",
                            Password = "password4",
                            Role = "Admin",
                            UserName = "SaraConnor"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2632),
                            Password = "password5",
                            Role = "User",
                            UserName = "TomHanks"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2633),
                            Email = "emma_watson@example.com",
                            FirstName = "Emma",
                            LastName = "Watson",
                            Password = "password6",
                            Role = "User",
                            UserName = "EmmaWatson"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2635),
                            Email = "robert_downey@example.com",
                            Password = "password7",
                            Role = "User",
                            UserName = "RobertDowney"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2636),
                            FirstName = "Chris",
                            Password = "password8",
                            Role = "User",
                            UserName = "ChrisEvans"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2638),
                            LastName = "Johansson",
                            Password = "password9",
                            Role = "User",
                            UserName = "ScarlettJohansson"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2639),
                            FirstName = "Bruce",
                            LastName = "Wayne",
                            Password = "password10",
                            Role = "User",
                            UserName = "BruceWayne"
                        });
                });

            modelBuilder.Entity("PostableRESTfulApi.Models.Like", b =>
                {
                    b.HasOne("PostableRESTfulApi.Models.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PostableRESTfulApi.Models.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PostableRESTfulApi.Models.Post", b =>
                {
                    b.HasOne("PostableRESTfulApi.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PostableRESTfulApi.Models.Post", b =>
                {
                    b.Navigation("Likes");
                });

            modelBuilder.Entity("PostableRESTfulApi.Models.User", b =>
                {
                    b.Navigation("Likes");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
