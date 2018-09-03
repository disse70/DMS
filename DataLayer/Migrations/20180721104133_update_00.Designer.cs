﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(DMSContext))]
    [Migration("20180721104133_update_00")]
    partial class update_00
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.Property<int>("UsersUserId");

                    b.HasKey("CategoryId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DataLayer.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("DocumentName")
                        .IsRequired();

                    b.Property<string>("DocumentPath")
                        .IsRequired();

                    b.Property<string>("DocumentTags")
                        .IsRequired();

                    b.Property<int>("UsersUserId");

                    b.HasKey("DocumentId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("DataLayer.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserEmail")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserRole")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataLayer.Category", b =>
                {
                    b.HasOne("DataLayer.User", "Users")
                        .WithMany("Catgories")
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.Document", b =>
                {
                    b.HasOne("DataLayer.Category", "Category")
                        .WithMany("Documents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLayer.User", "Users")
                        .WithMany("Documents")
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}