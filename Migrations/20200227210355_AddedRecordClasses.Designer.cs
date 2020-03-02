﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RecordCompany.Models;

namespace RecordCompany.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200227210355_AddedRecordClasses")]
    partial class AddedRecordClasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RecordCompany.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsExplicit")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("RecordCompany.Models.Band", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("CountryOfOrigin")
                        .HasColumnType("text");

                    b.Property<bool>("IsSigned")
                        .HasColumnType("boolean");

                    b.Property<int>("MembersOfMembers")
                        .HasColumnType("integer");

                    b.Property<string>("PersonOfContact")
                        .HasColumnType("text");

                    b.Property<string>("Style")
                        .HasColumnType("text");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Band");
                });

            modelBuilder.Entity("RecordCompany.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<int>("Length")
                        .HasColumnType("integer");

                    b.Property<bool>("Lyrics")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Song");
                });
#pragma warning restore 612, 618
        }
    }
}
