﻿// <auto-generated />
using System;
using LernsiegDbLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LernsiegDbLib.Migrations
{
    [DbContext(typeof(LernsiegContext))]
    partial class LernsiegContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LernsiegDbLib.Criteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EvaluationType")
                        .HasColumnType("int");

                    b.Property<int>("SequenceNr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Criterias");
                });

            modelBuilder.Entity("LernsiegDbLib.Evaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EvaluationType")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolOrTeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("LernsiegDbLib.EvaluationItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CriteriaId")
                        .HasColumnType("int");

                    b.Property<int?>("EvaluationId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CriteriaId");

                    b.HasIndex("EvaluationId");

                    b.ToTable("EvaluationItems");
                });

            modelBuilder.Entity("LernsiegDbLib.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("LernsiegDbLib.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LernsiegDbLib.EvaluationItem", b =>
                {
                    b.HasOne("LernsiegDbLib.Criteria", "Criteria")
                        .WithMany()
                        .HasForeignKey("CriteriaId");

                    b.HasOne("LernsiegDbLib.Evaluation", "Evaluation")
                        .WithMany("EvaluationItems")
                        .HasForeignKey("EvaluationId");

                    b.Navigation("Criteria");

                    b.Navigation("Evaluation");
                });

            modelBuilder.Entity("LernsiegDbLib.Teacher", b =>
                {
                    b.HasOne("LernsiegDbLib.School", "School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("LernsiegDbLib.Evaluation", b =>
                {
                    b.Navigation("EvaluationItems");
                });

            modelBuilder.Entity("LernsiegDbLib.School", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
