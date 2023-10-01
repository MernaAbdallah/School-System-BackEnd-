﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230917114150_edit3")]
    partial class edit3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.EnrollmentAggregate.Enrollment", b =>
                {
                    b.Property<long>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EnrollmentID"));

                    b.Property<long>("CourseID")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentID")
                        .HasColumnType("bigint");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Domain.Lookups.StudentLevel", b =>
                {
                    b.Property<long>("StudentLevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentLevelID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentLevelID");

                    b.ToTable("StudentLevels");
                });

            modelBuilder.Entity("Domain.Lookups.TeacherCategory", b =>
                {
                    b.Property<long>("TeacherCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TeacherCategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherCategoryID");

                    b.ToTable("TeacherCategories");
                });

            modelBuilder.Entity("Domain.ManagerAggregate.Manger", b =>
                {
                    b.Property<long>("ManagerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ManagerID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.Course", b =>
                {
                    b.Property<long>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TeacherID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("TeacherId")
                        .HasColumnType("bigint");

                    b.HasKey("CourseID");

                    b.HasIndex("TeacherID1");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.School", b =>
                {
                    b.Property<long>("SchoolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SchoolID"));

                    b.Property<long?>("MangerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolID");

                    b.HasIndex("MangerId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.Student", b =>
                {
                    b.Property<long>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SchoolID")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentLevelID")
                        .HasColumnType("bigint");

                    b.HasKey("StudentID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("StudentLevelID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Domain.TeacherAggregate.Teacher", b =>
                {
                    b.Property<long>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TeacherID"));

                    b.Property<long>("CategoryTeacherCategoryID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.HasKey("TeacherID");

                    b.HasIndex("CategoryTeacherCategoryID");

                    b.HasIndex("CourseId")
                        .IsUnique()
                        .HasFilter("[CourseId] IS NOT NULL");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Domain.EnrollmentAggregate.Enrollment", b =>
                {
                    b.HasOne("Domain.SchoolAggregate.Course", "Course")
                        .WithMany("Enrolled")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.SchoolAggregate.Student", "Student")
                        .WithMany("Enrolls")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.Course", b =>
                {
                    b.HasOne("Domain.TeacherAggregate.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.School", b =>
                {
                    b.HasOne("Domain.ManagerAggregate.Manger", "Manger")
                        .WithMany()
                        .HasForeignKey("MangerId");

                    b.Navigation("Manger");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.Student", b =>
                {
                    b.HasOne("Domain.SchoolAggregate.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Lookups.StudentLevel", "StudentLevel")
                        .WithMany()
                        .HasForeignKey("StudentLevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("StudentLevel");
                });

            modelBuilder.Entity("Domain.TeacherAggregate.Teacher", b =>
                {
                    b.HasOne("Domain.Lookups.TeacherCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryTeacherCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.SchoolAggregate.Course", "Course")
                        .WithOne()
                        .HasForeignKey("Domain.TeacherAggregate.Teacher", "CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.SchoolAggregate.School", "School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Course");

                    b.Navigation("School");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.Course", b =>
                {
                    b.Navigation("Enrolled");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.School", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Domain.SchoolAggregate.Student", b =>
                {
                    b.Navigation("Enrolls");
                });
#pragma warning restore 612, 618
        }
    }
}
