﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_Mgmt_ASP_Core.Data;

namespace Student_Mgmt_ASP_Core.Migrations
{
    [DbContext(typeof(Student_Mgmt_Database))]
    partial class Student_Mgmt_DatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Student_Mgmt_ASP_Core.Model.Course", b =>
                {
                    b.Property<int>("course_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("course_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.HasKey("course_ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Student_Mgmt_ASP_Core.Model.Student", b =>
                {
                    b.Property<int>("student_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Course_objcourse_ID")
                        .HasColumnType("int");

                    b.Property<int>("course_ID")
                        .HasColumnType("int");

                    b.Property<string>("student_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("student_ID");

                    b.HasIndex("Course_objcourse_ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Student_Mgmt_ASP_Core.Model.Student", b =>
                {
                    b.HasOne("Student_Mgmt_ASP_Core.Model.Course", "Course_obj")
                        .WithMany()
                        .HasForeignKey("Course_objcourse_ID");

                    b.Navigation("Course_obj");
                });
#pragma warning restore 612, 618
        }
    }
}
