using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using WorkApp.Entity;

namespace WorkApp.DAL.Mappings
{
    public class AgendaMap : EntityTypeConfiguration<Agenda>
    {
        public AgendaMap()
        {
            ToTable("Agenda");

            HasKey(g => g.IdAgenda);
            
            Property(g => g.IdAgenda)
                .HasColumnName("IdAgenda")
                .IsRequired();

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
