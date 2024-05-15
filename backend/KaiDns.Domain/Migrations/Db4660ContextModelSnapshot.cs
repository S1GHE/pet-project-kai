﻿// <auto-generated />
using System;
using KaiDns.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KaiDns.Domain.Migrations
{
    [DbContext(typeof(Db4660Context))]
    partial class Db4660ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KaiDns.Domain.Model.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .UseCollation("Cyrillic_General_CI_AS");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentID");

                    b.Property<string>("PathToIcon")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("path_to_icon");

                    b.HasKey("Id")
                        .HasName("PK__Catalog");

                    b.HasIndex("ParentId");

                    b.ToTable("Catalog", (string)null);
                });

            modelBuilder.Entity("KaiDns.Domain.Model.Catalog", b =>
                {
                    b.HasOne("KaiDns.Domain.Model.Catalog", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK_ParentID_ID");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("KaiDns.Domain.Model.Catalog", b =>
                {
                    b.Navigation("InverseParent");
                });
#pragma warning restore 612, 618
        }
    }
}