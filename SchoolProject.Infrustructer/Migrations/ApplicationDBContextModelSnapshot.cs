﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolProject.Infrustructer.Data;

#nullable disable

namespace SchoolProject.Infrustructer.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolProject.Data.Entities.Department", b =>
                {
                    b.Property<int>("DID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DID"));

                    b.Property<string>("DName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("DID");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.DepartmetSubject", b =>
                {
                    b.Property<int>("DeptSubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptSubID"));

                    b.Property<int>("DID")
                        .HasColumnType("int");

                    b.Property<int>("SubID")
                        .HasColumnType("int");

                    b.HasKey("DeptSubID");

                    b.HasIndex("DID");

                    b.HasIndex("SubID");

                    b.ToTable("departmentSubjects");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Student", b =>
                {
                    b.Property<int>("StudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("DID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("StudID");

                    b.HasIndex("DID");

                    b.ToTable("students");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.StudentSubject", b =>
                {
                    b.Property<int>("StudSubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudSubID"));

                    b.Property<int>("StudID")
                        .HasColumnType("int");

                    b.Property<int>("SubID")
                        .HasColumnType("int");

                    b.HasKey("StudSubID");

                    b.HasIndex("StudID");

                    b.HasIndex("SubID");

                    b.ToTable("studentSubjects");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Subjects", b =>
                {
                    b.Property<int>("SubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubID"));

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("SubID");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.DepartmetSubject", b =>
                {
                    b.HasOne("SchoolProject.Data.Entities.Department", "Department")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("DID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolProject.Data.Entities.Subjects", "Subjects")
                        .WithMany("DepartmetsSubjects")
                        .HasForeignKey("SubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Student", b =>
                {
                    b.HasOne("SchoolProject.Data.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.StudentSubject", b =>
                {
                    b.HasOne("SchoolProject.Data.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolProject.Data.Entities.Subjects", "Subject")
                        .WithMany("StudentsSubjects")
                        .HasForeignKey("SubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Department", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Subjects", b =>
                {
                    b.Navigation("DepartmetsSubjects");

                    b.Navigation("StudentsSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
