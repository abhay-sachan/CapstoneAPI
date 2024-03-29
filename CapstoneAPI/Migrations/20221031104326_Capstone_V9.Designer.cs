﻿// <auto-generated />
using System;
using CapstoneAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CapstoneAPI.Migrations
{
    [DbContext(typeof(CapstoneAPIDbContext))]
    [Migration("20221031104326_Capstone_V9")]
    partial class Capstone_V9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CapstoneAPI.Models.Address", b =>
                {
                    b.Property<int>("AddrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddrId"), 1L, 1);

                    b.Property<string>("AddrType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("PhoneNo")
                        .HasColumnType("bigint");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.HasKey("AddrId");

                    b.HasIndex("EmailId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductBrand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SellerEmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingCost")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("EmailId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("CapstoneAPI.Models.DeliveryPincode", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PId"), 1L, 1);

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.HasKey("PId");

                    b.HasIndex("EmailId");

                    b.ToTable("DeliveryPincode");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("DeliveryStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductBrand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("QuantityPurchased")
                        .HasColumnType("int");

                    b.Property<bool>("ReturnStatus")
                        .HasColumnType("bit");

                    b.Property<string>("SellerEmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingCost")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("EmailId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("AdditonalProductImage1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdditonalProductImage2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NoOfRatings")
                        .HasColumnType("int");

                    b.Property<string>("ProductBrand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<int>("ShippingCost")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("EmailId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Register", b =>
                {
                    b.Property<string>("EmailId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("MobNo")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ResidenceAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("SecurityAnswer")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SecurityQuestion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("EmailId");

                    b.ToTable("Register");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Wishlist", b =>
                {
                    b.Property<int>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishListId"), 1L, 1);

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductBrand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SellerEmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingCost")
                        .HasColumnType("int");

                    b.HasKey("WishListId");

                    b.HasIndex("EmailId");

                    b.ToTable("Wishlist");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Address", b =>
                {
                    b.HasOne("CapstoneAPI.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("EmailId");

                    b.Navigation("Register");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Cart", b =>
                {
                    b.HasOne("CapstoneAPI.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("EmailId");

                    b.Navigation("Register");
                });

            modelBuilder.Entity("CapstoneAPI.Models.DeliveryPincode", b =>
                {
                    b.HasOne("CapstoneAPI.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Register");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Order", b =>
                {
                    b.HasOne("CapstoneAPI.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("EmailId");

                    b.Navigation("Register");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Product", b =>
                {
                    b.HasOne("CapstoneAPI.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("EmailId");

                    b.Navigation("Register");
                });

            modelBuilder.Entity("CapstoneAPI.Models.Wishlist", b =>
                {
                    b.HasOne("CapstoneAPI.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("EmailId");

                    b.Navigation("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
