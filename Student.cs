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
        
        public int? AdmNumber { get; set; }
      
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("students");
            builder.Property(h => h.Id).HasColumnName("id");
            builder.Property(h => h.AdmNumber).HasColumnName("adm_number").HasDefaultValue(null);
            builder.Property(h => h.Name).HasColumnName("name");
            builder.Property(h => h.PhoneNumber).HasColumnName("phone_number");

        

        }
    }
}