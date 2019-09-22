﻿// <auto-generated />
using System;
using Logistics.EF.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Logistics.EF.Core.Migrations
{
    [DbContext(typeof(LogisticsDbContext))]
    [Migration("20190921081540_adress")]
    partial class adress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Logistics.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("DetailInfo")
                        .HasMaxLength(256);

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LinkPhone");

                    b.Property<string>("Linker")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Asset");
                });

            modelBuilder.Entity("Logistics.Models.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNo");

                    b.Property<int>("AccountType");

                    b.Property<int?>("BankType");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("Logistics.Models.Evaluate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("OrderID");

                    b.Property<string>("Remark")
                        .HasMaxLength(2048);

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.ToTable("Evaluate");
                });

            modelBuilder.Entity("Logistics.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("DeadLine");

                    b.Property<Guid?>("DeliverUser");

                    b.Property<float>("DestLat");

                    b.Property<float>("DestLng");

                    b.Property<string>("Dstination");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("MailingAddress")
                        .HasMaxLength(64);

                    b.Property<float>("MailingLat");

                    b.Property<float>("MailingLng");

                    b.Property<int>("OrderStatus");

                    b.Property<Guid>("OrderUser");

                    b.Property<decimal>("Price");

                    b.Property<int>("Qty");

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Logistics.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("GoodsName");

                    b.Property<int>("GoodsQty");

                    b.Property<int>("GoodsType");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("OrderId");

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<int>("SeqNo");

                    b.HasKey("Id");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Logistics.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.Property<string>("PassWord");

                    b.Property<string>("Phone");

                    b.Property<string>("Remark")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}