﻿// <auto-generated />
using System;
using MediumEfCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediumEfCoreRelationships.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MediumEfCoreRelationships.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Çalıkuşu"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Kuyucaklı Yusuf"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Acımak"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Harry Potter Sırlar Odası"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Clean Code"
                        });
                });

            modelBuilder.Entity("MediumEfCoreRelationships.Models.BookDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<short>("Pages")
                        .HasColumnType("smallint");

                    b.Property<short>("ReleaseYear")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Country = "Türkiye",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "9785486037986",
                            IsDeleted = false,
                            Pages = (short)409,
                            ReleaseYear = (short)1922
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            Country = "Türkiye",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "9786051215877",
                            IsDeleted = false,
                            Pages = (short)222,
                            ReleaseYear = (short)1937
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            Country = "Türkiye",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "9789751026569",
                            IsDeleted = false,
                            Pages = (short)160,
                            ReleaseYear = (short)1928
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            Country = "İngiltere",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "9781408855669",
                            IsDeleted = false,
                            Pages = (short)314,
                            ReleaseYear = (short)1998
                        },
                        new
                        {
                            Id = 5,
                            BookId = 5,
                            Country = "Amerika",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "978-0132350884",
                            IsDeleted = false,
                            Pages = (short)464,
                            ReleaseYear = (short)2008
                        });
                });

            modelBuilder.Entity("MediumEfCoreRelationships.Models.BookDetail", b =>
                {
                    b.HasOne("MediumEfCoreRelationships.Models.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("MediumEfCoreRelationships.Models.BookDetail", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("MediumEfCoreRelationships.Models.Book", b =>
                {
                    b.Navigation("BookDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
