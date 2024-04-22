﻿// <auto-generated />
using System;
using InfoGames.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfoGames.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InfoGames.Models.DetalhesJogo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AboutTheGame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Background")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackgroundRaw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapsuleImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapsuleImagev5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetailedDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsFree")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequiredAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SteamAppId")
                        .HasColumnType("int");

                    b.Property<string>("SupportedLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DetalhesJogos");
                });

            modelBuilder.Entity("InfoGames.Models.JogoModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetalhesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DetalhesId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("InfoGames.Models.LojaModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChaveApi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lojas");

                    b.HasData(
                        new
                        {
                            Id = "d58f4180-8360-4240-a006-3eb24b7cd005",
                            ChaveApi = "123456",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/8/83/Steam_icon_logo.svg",
                            Nome = "Steam",
                            Url = "https://store.steampowered.com/"
                        });
                });

            modelBuilder.Entity("InfoGames.Models.JogoModel", b =>
                {
                    b.HasOne("InfoGames.Models.DetalhesJogo", "Detalhes")
                        .WithMany()
                        .HasForeignKey("DetalhesId");

                    b.Navigation("Detalhes");
                });
#pragma warning restore 612, 618
        }
    }
}