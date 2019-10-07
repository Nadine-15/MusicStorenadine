﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicStorenadine.Models;

namespace MusicStorenadine.Migrations
{
    [DbContext(typeof(MusicStoreContext))]
    [Migration("20191007211324_MigrationYeet")]
    partial class MigrationYeet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicStorenadine.Models.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<int>("GenreID");

                    b.Property<string>("Name");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("AlbumID");

                    b.HasIndex("GenreID");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("MusicStorenadine.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GenreID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("MusicStorenadine.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumID");

                    b.Property<string>("Artist");

                    b.Property<string>("Featuring");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("RunTimeSeconds");

                    b.Property<int?>("SongID1");

                    b.Property<string>("SongName");

                    b.HasKey("SongID");

                    b.HasIndex("SongID1");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("MusicStorenadine.Models.Album", b =>
                {
                    b.HasOne("MusicStorenadine.Models.Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MusicStorenadine.Models.Song", b =>
                {
                    b.HasOne("MusicStorenadine.Models.Song")
                        .WithMany("Songs")
                        .HasForeignKey("SongID1");
                });
#pragma warning restore 612, 618
        }
    }
}