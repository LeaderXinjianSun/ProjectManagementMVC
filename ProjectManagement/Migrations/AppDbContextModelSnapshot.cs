﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManagement.Models;

namespace ProjectManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManagement.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assembler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AssemblerScore")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Designer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DesignerScore")
                        .HasColumnType("float");

                    b.Property<string>("Engineer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EngineerScore")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Programmer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProgrammerScore")
                        .HasColumnType("float");

                    b.Property<string>("ProjectID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Assembler = "邱伟",
                            AssemblerScore = 10.0,
                            Count = 24,
                            Designer = "范杰",
                            DesignerScore = 10.0,
                            Engineer = "邬海欣",
                            EngineerScore = 10.0,
                            Name = "收放板共用机（LDR-D5X-SF)   VPP D53_撕膜电测",
                            Programmer = "孙鑫建",
                            ProgrammerScore = 10.0,
                            ProjectID = "SZ-20191228-01"
                        },
                        new
                        {
                            Id = 2,
                            Assembler = "李晓锁",
                            AssemblerScore = 10.0,
                            Count = 13,
                            Designer = "范杰",
                            DesignerScore = 10.0,
                            Engineer = "李明昌",
                            EngineerScore = 10.0,
                            Name = "X1023自动上下料机",
                            Programmer = "孙鑫建",
                            ProgrammerScore = 10.0,
                            ProjectID = "LDR-SJ-0220"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
