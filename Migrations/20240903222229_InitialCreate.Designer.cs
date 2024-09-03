﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kotas_backend_challenge.Data;

#nullable disable

namespace kotas_backend_challenge.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20240903222229_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("kotas_backend_challenge.Models.MestrePokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MestresPokemon");
                });

            modelBuilder.Entity("kotas_backend_challenge.Models.PokemonCapturado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCaptura")
                        .HasColumnType("TEXT");

                    b.Property<int>("MestrePokemonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MestrePokemonId");

                    b.ToTable("PokemonsCapturados");
                });

            modelBuilder.Entity("kotas_backend_challenge.Models.PokemonCapturado", b =>
                {
                    b.HasOne("kotas_backend_challenge.Models.MestrePokemon", "MestrePokemon")
                        .WithMany("PokemonsCapturados")
                        .HasForeignKey("MestrePokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MestrePokemon");
                });

            modelBuilder.Entity("kotas_backend_challenge.Models.MestrePokemon", b =>
                {
                    b.Navigation("PokemonsCapturados");
                });
#pragma warning restore 612, 618
        }
    }
}
