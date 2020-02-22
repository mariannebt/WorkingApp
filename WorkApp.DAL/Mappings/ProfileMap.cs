using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using WorkApp.Entity;

namespace WorkApp.DAL
{
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        public ProfileMap()
        {
            ToTable("Profile");

            HasKey(p => p.IdProfile);

            Property(p => p.IdProfile)
                .HasColumnName("IdProfile")
                .IsRequired();

            Property(a => a.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.Description)
                .HasColumnName("Description")
                .HasMaxLength(100)
                .IsOptional();

            Property(a => a.InclusionDt)
                .HasColumnName("InclusionTime")
                .IsRequired();

            Property(a => a.UpdateDt)
                .HasColumnName("UpdateTime")
                .IsOptional();

            Property(a => a.User)
                .HasColumnName("User")
                .IsRequired();

        }
    }
}
