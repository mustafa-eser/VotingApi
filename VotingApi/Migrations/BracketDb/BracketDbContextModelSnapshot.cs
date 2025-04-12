﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VotingApi.Data;

#nullable disable

namespace VotingApi.Migrations.BracketDb
{
    [DbContext(typeof(BracketDbContext))]
    partial class BracketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VotingApi.Entities.Bracket", b =>
                {
                    b.Property<string>("bracketId")
                        .HasColumnType("text");

                    b.Property<string>("bracketName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("shareUrlToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("winnerImageId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("bracketId");

                    b.ToTable("Brackets");
                });
#pragma warning restore 612, 618
        }
    }
}
