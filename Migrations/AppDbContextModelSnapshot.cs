﻿// <auto-generated />
using GunRangeV3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GunRangeV3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GunRangeV3.Models.Shooter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdditionalTrainingHours")
                        .HasColumnType("int");

                    b.Property<string>("AdditionalTrainingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GunInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRetired")
                        .HasColumnType("bit");

                    b.Property<string>("IssuedEquipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastRangeDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarksAwards")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualificationsTraining")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shooters");
                });
#pragma warning restore 612, 618
        }
    }
}