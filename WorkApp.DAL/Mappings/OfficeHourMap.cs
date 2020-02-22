using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using WorkApp.Entity;

namespace WorkApp.DAL.Mappings
{
    public class OfficeHourMap : EntityTypeConfiguration<OfficeHour>
    {
        public OfficeHourMap()
        {
            ToTable("OfficeHour");

            HasKey(o => o.IdOfficeHour);

            Property(o => o.IdOfficeHour)
                .HasColumnName("IdOfficeHour")
                .IsRequired();

            Property(o => o.StartDate)
                .HasColumnName("StartDate")
                .IsOptional();

            Property(o => o.EndDate)
                .HasColumnName("EndDate")
                .IsOptional();

            Property(o => o.StartBreak)
                .HasColumnName("StartBreak")
                .IsOptional();

            Property(o => o.EndBreak)
                .HasColumnName("EndBreak")
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

            // Foreing Key
            HasRequired(o => o.Employee)
                .WithMany(e => e.WorkHours)
                .HasForeignKey(o => o.IdEmployee);
        }
    }
}
