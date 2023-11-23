﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sample1.Models;

#nullable disable

namespace sample1.Migrations
{
    [DbContext(typeof(SqliteDDFC))]
    partial class SqliteDDFCModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("sample1.Models.Depts", b =>
                {
                    b.Property<int>("deptid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dname")
                        .HasColumnType("TEXT");

                    b.Property<string>("location")
                        .HasColumnType("TEXT");

                    b.Property<string>("location_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("location_type")
                        .HasColumnType("TEXT");

                    b.HasKey("deptid");

                    b.ToTable("Dept");
                });
#pragma warning restore 612, 618
        }
    }
}
