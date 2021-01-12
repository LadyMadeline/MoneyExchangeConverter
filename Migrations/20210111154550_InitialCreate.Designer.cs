﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyExchangeConverter.Data;

namespace MoneyExchangeConverter.Migrations
{
    [DbContext(typeof(ExchangeContext))]
    [Migration("20210111154550_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MoneyExchangeConverter.Models.ExchangeRequest", b =>
                {
                    b.Property<int>("ExchangeRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FromAmount")
                        .HasColumnType("float");

                    b.Property<string>("FromCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ToAmount")
                        .HasColumnType("float");

                    b.Property<string>("ToCorrency")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExchangeRequestId");

                    b.ToTable("exchangeRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
