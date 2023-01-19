﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SesaPay.DataModels;

#nullable disable

namespace SesaPay.DataModels.Migrations
{
    [DbContext(typeof(SesaPayContext))]
    partial class SesaPayContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SesaPay.DataModels.Admin.tbl_cities", b =>
                {
                    b.Property<int>("city_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("city_id");

                    b.Property<string>("city_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city_name");

                    b.Property<int>("country_id")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<int>("state_id")
                        .HasColumnType("int")
                        .HasColumnName("state_id");

                    b.HasKey("city_id");

                    b.ToTable("tbl_cities");
                });

            modelBuilder.Entity("SesaPay.DataModels.Partners.tbl_partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("partner_id");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int")
                        .HasColumnName("partner_mobile_number");

                    b.Property<string>("PartnerEmail")
                        .HasColumnType("longtext")
                        .HasColumnName("partner_email");

                    b.Property<string>("PartnerName")
                        .HasColumnType("longtext")
                        .HasColumnName("partner_name");

                    b.Property<string>("PartnerOperator")
                        .HasColumnType("longtext")
                        .HasColumnName("partner_operator");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("partner_password");

                    b.Property<int>("PhoneCode")
                        .HasColumnType("int")
                        .HasColumnName("partner_phone_code");

                    b.HasKey("Id");

                    b.ToTable("tbl_Partners");
                });
#pragma warning restore 612, 618
        }
    }
}
