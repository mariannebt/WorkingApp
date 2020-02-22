using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using WorkApp.Entity;

namespace WorkApp.DAL.Mappings
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable("Person");

            HasKey(p => p.IdPerson);

            Property(p => p.IdPerson)
                .HasColumnName("IdPerson")
                .IsRequired();

            Property(p => p.IdManager)
                .HasColumnName("IdManager")
                .IsOptional();

            Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired();

            Property(p => p.Login)
                .HasColumnName("Login")
                .IsRequired();

            Property(p => p.Password)
                .HasColumnName("Password")
                .IsRequired();

            Property(p => p.Photo)
                .HasColumnName("Photo")
                .IsRequired();

            Property(p => p.DateofBirth)
                .HasColumnName("DateofBirth")
                .IsRequired();

            Property(p => p.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            Property(p => p.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            Property(p => p.EndDate)
                .HasColumnName("EndDate")
                .IsOptional();

            Property(p => p.InclusionDt)
                .HasColumnName("InclusionTime")
                .IsRequired();

            Property(p => p.UpdateDt)
                .HasColumnName("UpdateTime")
                .IsOptional();

            Property(p => p.User)
                .HasColumnName("User")
                .IsRequired();
    }
    }
}
