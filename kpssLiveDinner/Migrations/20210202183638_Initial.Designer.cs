﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kpssLiveDinner.Domain;

namespace kpssLiveDinner.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210202183638_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("kpssLiveDinner.Domain.Entities.BlogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Heading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlogItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Nikita Andreevich",
                            Date = new DateTime(2021, 2, 2, 18, 36, 37, 723, DateTimeKind.Utc).AddTicks(766),
                            Heading = "So good for real...",
                            Message = "Nikita says that this web-application is so good yeah boy shit some text to fill kakakaka lorem ipsum ge ka"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Oleg Dubovoy",
                            Date = new DateTime(2021, 2, 2, 18, 36, 37, 724, DateTimeKind.Utc).AddTicks(8803),
                            Heading = "So bad shit god damn...",
                            Message = "Oleg says thah this is full shit bitch fuck yeah ahahaha"
                        });
                });

            modelBuilder.Entity("kpssLiveDinner.Domain.Entities.CustomerReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerReviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.",
                            Name = "Paul Mitchel",
                            Role = "Web Designer"
                        },
                        new
                        {
                            Id = 2,
                            Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.",
                            Name = "Redo Mufasa",
                            Role = "True rapper"
                        },
                        new
                        {
                            Id = 3,
                            Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.",
                            Name = "John Wick",
                            Role = "Killer"
                        });
                });

            modelBuilder.Entity("kpssLiveDinner.Domain.Entities.GalleryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GalleryImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "gallery-img-01.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "gallery-img-02.jpg"
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "gallery-img-03.jpg"
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "gallery-img-04.jpg"
                        },
                        new
                        {
                            Id = 5,
                            ImagePath = "gallery-img-05.jpg"
                        });
                });

            modelBuilder.Entity("kpssLiveDinner.Domain.Entities.StuffItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StuffItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "stuff-img-01.jpg",
                            Name = "Nikita Andreevich",
                            Role = "Master chief"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "stuff-img-02.jpg",
                            Name = "Oleg Anatolievich",
                            Role = "Loh Killer"
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "stuff-img-03.jpg",
                            Name = "Valeriya Olegovna",
                            Role = "Killer sex doll"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}