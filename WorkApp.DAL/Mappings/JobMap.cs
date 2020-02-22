using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using WorkApp.Entity;

namespace WorkApp.DAL.Mappings
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            ToTable("Job");

            HasKey(j => j.IdJob);

            Property(j => j.IdJob)
                .HasColumnName("IdJob")
                .IsRequired();

            Property(j => j.Name)
                .HasColumnName("Name")
                .HasMaxLength(30)
                .IsRequired();

            Property(j => j.Description)
                .HasColumnName("Description")
                .HasMaxLength(50)
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
