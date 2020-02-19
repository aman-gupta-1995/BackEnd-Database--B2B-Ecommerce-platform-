﻿// <auto-generated />
using System;
using AybCommerce.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AybCommerce.Persistance.Data.Migrations
{
    [DbContext(typeof(AybCommerceDbContext))]
    partial class AybCommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AybCommerce.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(300);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(300);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.Property<string>("UserId");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("UpdatedId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartId")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Currency")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<string>("ProductName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Quantity");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentId");

                    b.Property<short>("Status");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("ParentId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.CategoryInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Extra")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Key")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("CategoryInfos");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CallSite")
                        .HasMaxLength(5000);

                    b.Property<string>("Exception")
                        .HasMaxLength(5000);

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Logged");

                    b.Property<string>("Logger")
                        .HasMaxLength(255);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<string>("BackRef")
                        .HasMaxLength(255);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("FreePayment");

                    b.Property<bool>("IsSuccess");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("OrderNote")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<short>("OrderStatus");

                    b.Property<string>("PayuForm");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CreatedId");

                    b.HasIndex("UpdatedId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Currency")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("OrderId");

                    b.Property<string>("ProductCode")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("ProductName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BinNumber")
                        .HasColumnType("char(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CardNumber")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<int>("OrderId");

                    b.Property<short>("PaymentStatus");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.PaymentLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("ErrorMessage");

                    b.Property<short>("LogType");

                    b.Property<string>("Message");

                    b.Property<int?>("PaymentId");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("PaymentLogs");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("ErpCode")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.Property<decimal>("SalePrice");

                    b.Property<short>("Status");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.ProductInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Extra")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Key")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ProductCode");

                    b.Property<int?>("ProductId");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("ProductInfos");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedId")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Extra")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Key")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Updated");

                    b.Property<string>("UpdatedId")
                        .HasColumnName("UpdatedBy");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("CreatedId");

                    b.HasIndex("UpdatedId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("AddressId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("char(11)")
                        .HasMaxLength(11);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<short>("Status");

                    b.Property<string>("Surname")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Address", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("AybCommerce.Domain.Entities.Address", "UserId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Category", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.Category", "Parent")
                        .WithMany("Chilren")
                        .HasForeignKey("ParentId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.CategoryInfo", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Order", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Payment", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.Order", "Order")
                        .WithMany("Payment")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.PaymentLog", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.Payment", "Payment")
                        .WithMany("PaymentLogs")
                        .HasForeignKey("PaymentId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Product", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.ProductInfo", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.Product")
                        .WithMany("ProductInfos")
                        .HasForeignKey("ProductId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("AybCommerce.Domain.Entities.Setting", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedId");

                    b.HasOne("AybCommerce.Domain.Entities.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AybCommerce.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AybCommerce.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
