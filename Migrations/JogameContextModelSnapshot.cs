﻿// <auto-generated />
using System;
using Jogame.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jogame.Migrations
{
    [DbContext(typeof(JogameContext))]
    partial class JogameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Jogame.Domains.Jogador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("Jogame.Domains.Jogo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("Jogame.Domains.JogosJogadores", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdJogador")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdJogo")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdJogador");

                    b.HasIndex("IdJogo");

                    b.ToTable("JogosJogadores");
                });

            modelBuilder.Entity("Jogame.Domains.JogosJogadores", b =>
                {
                    b.HasOne("Jogame.Domains.Jogador", "Jogador")
                        .WithMany("JogosJogadores")
                        .HasForeignKey("IdJogador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jogame.Domains.Jogo", "Jogo")
                        .WithMany("JogosJogadores")
                        .HasForeignKey("IdJogo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
