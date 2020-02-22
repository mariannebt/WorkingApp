using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using WorkApp.Entity;

namespace WorkApp.DAL.Mappings
{
    public class ActivityMap : EntityTypeConfiguration<Activity>
    {
        public ActivityMap()
        {
            ToTable("Activity");

            HasKey(a => a.IdActivity);

            Property(a => a.IdActivity)
                .HasColumnName("IdActivity")
                .IsRequired();
            Property(a => a.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(a => a.Description)
                .HasColumnName("Description")
                .HasMaxLength(100)
                .IsOptional();
            Property(a => a.Status)
                .HasColumnName("Status")
                .HasMaxLength(100)
                .IsRequired();
            Property(a => a.Start)
                .HasColumnName("StartActivity")
                .IsOptional();
            Property(a => a.End)
                .HasColumnName("EndtActivity")
                .IsOptional();
            Property(a => a.ExpectedTime)
                .HasColumnName("ExpectedTime")
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


            //Foreign key - Agenda
            HasRequired(a => a.Agenda) // Activity has 1 Agenda
                .WithMany(p => p.Activities) // Agenda has many activities
                .HasForeignKey(a => a.IdAgenda); // Activity Foreing Key
        }
    }
}
