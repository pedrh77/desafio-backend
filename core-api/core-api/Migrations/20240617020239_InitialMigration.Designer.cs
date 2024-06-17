﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using core_api.Infra.Context;

#nullable disable

namespace core_api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240617020239_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("core_api.Features.Products.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<string>("seller")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("thumbnailHd")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("zipcode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("core_api.Features.Purchases.Models.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("card_holder_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("card_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("cvv")
                        .HasColumnType("integer");

                    b.Property<string>("exp_date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("core_api.Features.Purchases.Models.RelationalTransactionCreditCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedIn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CreditCardId")
                        .HasColumnType("integer");

                    b.Property<int>("TransationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreditCardId");

                    b.HasIndex("TransationId");

                    b.ToTable("RelationalTransactionCreditCards");
                });

            modelBuilder.Entity("core_api.Features.Purchases.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("client_id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("client_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("total_to_pay")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("core_api.Features.Purchases.Models.RelationalTransactionCreditCard", b =>
                {
                    b.HasOne("core_api.Features.Purchases.Models.CreditCard", "CreditCard")
                        .WithMany()
                        .HasForeignKey("CreditCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("core_api.Features.Purchases.Models.Transaction", "Transation")
                        .WithMany()
                        .HasForeignKey("TransationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditCard");

                    b.Navigation("Transation");
                });
#pragma warning restore 612, 618
        }
    }
}
