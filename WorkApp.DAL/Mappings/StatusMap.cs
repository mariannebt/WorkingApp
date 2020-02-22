using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using WorkApp.Entity;

namespace WorkApp.DAL.Mappings
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            ToTable("Status");

            HasKey(s => s.IdStatus);

            Property(s => s.IdStatus)
                .HasColumnName("IdStatus")
                .IsRequired();

            Property(s => s.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();

            Property(s => s.Description)
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
