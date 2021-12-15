using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace WebApplication1
{
    public class Student 
    {
        public Guid Id { get; set; }
        public System.Guid SchoolId { get; set; }
        public string StudentStatus { get; set; }
        public string AdmPrefix { get; set; }
        public int? AdmNumber { get; set; }
        public int AdmNumberIndex { get; set; }
        public string AdmPostFix { get; set; }
        public string AdmNo { get; set; }
        public string TmpPrefix { get; set; }
        public int? TmpNumber { get; set; }
        public int TmpNumberIndex { get; set; }
        public string TmpPostFix { get; set; }
        public string TmpNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? TemporaryJoinDate { get; set; }

        public string Gender { get; set; }         
        public string UuId { get; set; }
        public string AcademicYear { get; set; }
        public string SpecialId { get; set; }
        public string GuardianName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
      
        public DateTime TerminatedAt { get; set; }

        public Guid? GuardianId { get; set; }
        public Guid? StudentUserId { get; set; }
        public string SendUserDetailsVia { get; set; }
        public string CreateUserNameBy { get; set; }
        public bool SendUserStatus { get; set; }
        public int UserPostFixValue { get; set; }
    
        public int? WebConnectivityStudentId { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("students");
            builder.Property(h => h.Id).HasColumnName("id");
            builder.Property(h => h.AdmPrefix).HasColumnName("adm_prefix").HasDefaultValue(null);
            builder.Property(h => h.AdmNo).HasColumnName("adm_no");
            builder.Property(h => h.AdmNumber).HasColumnName("adm_number").HasDefaultValue(null);
            builder.Property(h => h.AdmNumberIndex).HasColumnName("adm_number_index");
            builder.Property(h => h.AdmPostFix).HasColumnName("adm_postfix").HasDefaultValue(null);
            builder.Property(h => h.TmpPrefix).HasColumnName("tmp_prefix").HasDefaultValue(null);
            builder.Property(h => h.TmpPostFix).HasColumnName("tmp_postfix").HasDefaultValue(null);
            builder.Property(h => h.TmpNo).HasColumnName("tmp_no");
            builder.Property(h => h.TmpNumber).HasColumnName("tmp_number").HasDefaultValue(null);
            builder.Property(h => h.TmpNumberIndex).HasColumnName("tmp_number_index");
            builder.Property(h => h.SchoolId).HasColumnName("school_id");
            builder.Property(h => h.StudentStatus).HasColumnName("student_status");
            builder.Property(h => h.FirstName).HasColumnName("first_name");
            builder.Property(h => h.MiddleName).HasColumnName("middle_name");
            builder.Property(h => h.LastName).HasColumnName("last_name");
            builder.Property(h => h.Name).HasColumnName("name");
            builder.Property(h => h.Dob).HasColumnName("dob");
            builder.Property(h => h.Gender).HasColumnName("gender");
            builder.Property(h => h.UuId).HasColumnName("uu_id");
            builder.Property(h => h.AcademicYear).HasColumnName("academic_year");
            builder.Property(h => h.SpecialId).HasColumnName("special_id");
            builder.Property(h => h.GuardianName).HasColumnName("guardian_name");
            builder.Property(h => h.FatherName).HasColumnName("father_name");
            builder.Property(h => h.MotherName).HasColumnName("mother_name");
            builder.Property(h => h.TerminatedAt).HasColumnName("terminated_at");
            builder.Property(h => h.GuardianId).HasColumnName("guardian_id");
            builder.Property(h => h.StudentUserId).HasColumnName("student_user_id ");
            builder.Property(h => h.TemporaryJoinDate).HasColumnName("temporary_join_date");
            builder.Property(h => h.SendUserDetailsVia).HasColumnName("send_user_details_via");
            builder.Property(h => h.CreateUserNameBy).HasColumnName("create_user_name_by");
            builder.Property(h => h.SendUserStatus).HasColumnName("send_user_status").HasDefaultValue(false);
            builder.Property(h => h.UserPostFixValue).HasColumnName("user_post_fix_value");
            builder.Property(h => h.WebConnectivityStudentId).HasColumnName("web_connectivity_student_id");
            builder.Property(s => s.CreatedAt).HasColumnName("created_at").HasDefaultValueSql("transaction_timestamp()");

            builder.HasIndex(s => new { s.SchoolId, s.AdmNo })
            .IsUnique().HasName("IX_UNIQ_ADMISSION_NUMBER").HasFilter("adm_no IS NOT NULL");
            builder.HasIndex(s => new { s.SchoolId, s.TmpNo })
            .IsUnique().HasName("IX_UNIQ_TEMPORARY_NUMBER").HasFilter("tmp_no IS NOT NULL");

            builder.HasIndex(s => new { s.SchoolId, s.UuId }).IsUnique().HasName("IX_UNIQ_UUID_NUMBER");

            builder.HasIndex(b => new { b.SchoolId, b.WebConnectivityStudentId }).IsUnique()
           .HasName("IX_UNIQ_WEB_CONNECTIVITY_STUDENT_ID").HasFilter("web_connectivity_student_id IS NOT NULL");

        }
    }
}