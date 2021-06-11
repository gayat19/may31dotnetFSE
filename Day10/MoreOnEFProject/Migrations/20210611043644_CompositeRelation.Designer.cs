﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoreOnEFProject.Models;

namespace MoreOnEFProject.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210611043644_CompositeRelation")]
    partial class CompositeRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoreOnEFProject.Models.Bill", b =>
                {
                    b.Property<int>("BillNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("BillNumber");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("MoreOnEFProject.Models.BillDetail", b =>
                {
                    b.Property<int>("BillNumber")
                        .HasColumnType("int");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BillNumber", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("MoreOnEFProject.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MoreOnEFProject.Models.Item", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("MoreOnEFProject.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Username = "ABC",
                            Password = "123"
                        });
                });

            modelBuilder.Entity("MoreOnEFProject.Models.Bill", b =>
                {
                    b.HasOne("MoreOnEFProject.Models.Customer", null)
                        .WithMany("Bills")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("MoreOnEFProject.Models.BillDetail", b =>
                {
                    b.HasOne("MoreOnEFProject.Models.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoreOnEFProject.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MoreOnEFProject.Models.Customer", b =>
                {
                    b.HasOne("MoreOnEFProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Username");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MoreOnEFProject.Models.Customer", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
