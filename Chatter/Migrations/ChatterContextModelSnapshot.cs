﻿// <auto-generated />
using System;
using Chatter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chatter.Migrations
{
    [DbContext(typeof(ChatterContext))]
    partial class ChatterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chatter.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BoardId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.HasIndex("UserId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("Chatter.Models.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Topic");

                    b.HasKey("Id");

                    b.ToTable("Board");
                });

            modelBuilder.Entity("Chatter.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("userName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Chatter.Models.Blog", b =>
                {
                    b.HasOne("Chatter.Models.Board", "Board")
                        .WithMany("Blogs")
                        .HasForeignKey("BoardId");

                    b.HasOne("Chatter.Models.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
