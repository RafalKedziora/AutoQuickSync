﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(GitDbContext))]
    [Migration("20220912114553_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Domain.GitRepoInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PathToFile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlToRepository")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GitRepoInfo", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PathToFile = "C:\\Users\\rawci\\source\\repos\\",
                            UrlToRepository = "https://github.com/RafalKedziora/test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}