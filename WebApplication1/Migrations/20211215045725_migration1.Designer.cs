﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211215045725_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebApplication1.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("AcademicYear")
                        .HasColumnName("academic_year")
                        .HasColumnType("text");

                    b.Property<string>("AdmNo")
                        .HasColumnName("adm_no")
                        .HasColumnType("text");

                    b.Property<int?>("AdmNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("adm_number")
                        .HasColumnType("integer")
                        .HasDefaultValue(null);

                    b.Property<int>("AdmNumberIndex")
                        .HasColumnName("adm_number_index")
                        .HasColumnType("integer");

                    b.Property<string>("AdmPostFix")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("adm_postfix")
                        .HasColumnType("text")
                        .HasDefaultValue(null);

                    b.Property<string>("AdmPrefix")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("adm_prefix")
                        .HasColumnType("text")
                        .HasDefaultValue(null);

                    b.Property<string>("CreateUserNameBy")
                        .HasColumnName("create_user_name_by")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("transaction_timestamp()");

                    b.Property<DateTime?>("Dob")
                        .HasColumnName("dob")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FatherName")
                        .HasColumnName("father_name")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("text");

                    b.Property<Guid?>("GuardianId")
                        .HasColumnName("guardian_id")
                        .HasColumnType("uuid");

                    b.Property<string>("GuardianName")
                        .HasColumnName("guardian_name")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnName("middle_name")
                        .HasColumnType("text");

                    b.Property<string>("MotherName")
                        .HasColumnName("mother_name")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Guid>("SchoolId")
                        .HasColumnName("school_id")
                        .HasColumnType("uuid");

                    b.Property<string>("SendUserDetailsVia")
                        .HasColumnName("send_user_details_via")
                        .HasColumnType("text");

                    b.Property<bool>("SendUserStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("send_user_status")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("SpecialId")
                        .HasColumnName("special_id")
                        .HasColumnType("text");

                    b.Property<string>("StudentStatus")
                        .HasColumnName("student_status")
                        .HasColumnType("text");

                    b.Property<Guid?>("StudentUserId")
                        .HasColumnName("student_user_id ")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("TemporaryJoinDate")
                        .HasColumnName("temporary_join_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TerminatedAt")
                        .HasColumnName("terminated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TmpNo")
                        .HasColumnName("tmp_no")
                        .HasColumnType("text");

                    b.Property<int?>("TmpNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("tmp_number")
                        .HasColumnType("integer")
                        .HasDefaultValue(null);

                    b.Property<int>("TmpNumberIndex")
                        .HasColumnName("tmp_number_index")
                        .HasColumnType("integer");

                    b.Property<string>("TmpPostFix")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("tmp_postfix")
                        .HasColumnType("text")
                        .HasDefaultValue(null);

                    b.Property<string>("TmpPrefix")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("tmp_prefix")
                        .HasColumnType("text")
                        .HasDefaultValue(null);

                    b.Property<int>("UserPostFixValue")
                        .HasColumnName("user_post_fix_value")
                        .HasColumnType("integer");

                    b.Property<string>("UuId")
                        .HasColumnName("uu_id")
                        .HasColumnType("text");

                    b.Property<int?>("WebConnectivityStudentId")
                        .HasColumnName("web_connectivity_student_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId", "AdmNo")
                        .IsUnique()
                        .HasName("IX_UNIQ_ADMISSION_NUMBER")
                        .HasFilter("adm_no IS NOT NULL");

                    b.HasIndex("SchoolId", "TmpNo")
                        .IsUnique()
                        .HasName("IX_UNIQ_TEMPORARY_NUMBER")
                        .HasFilter("tmp_no IS NOT NULL");

                    b.HasIndex("SchoolId", "UuId")
                        .IsUnique()
                        .HasName("IX_UNIQ_UUID_NUMBER");

                    b.HasIndex("SchoolId", "WebConnectivityStudentId")
                        .IsUnique()
                        .HasName("IX_UNIQ_WEB_CONNECTIVITY_STUDENT_ID")
                        .HasFilter("web_connectivity_student_id IS NOT NULL");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}