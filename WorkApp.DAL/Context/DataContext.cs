using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Configuration;
using WorkApp.Entity;
using WorkApp.DAL.Mappings;

namespace WorkApp.DAL.Context
{
    class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["AppDB"].ConnectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //adicionar as classes de mapeamento..
            modelBuilder.Configurations.Add(new ActivityMap());
            modelBuilder.Configurations.Add(new AgendaMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new OfficeHourMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new ProfileMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Entity<Activity>().HasRequired(a => a.Agenda);
            modelBuilder.Entity<OfficeHour>().HasRequired(o => o.Employee);
            modelBuilder.Entity<Person>().HasRequired(p => p.Agenda);
            modelBuilder.Entity<Person>().HasRequired(p => p.Profile);
            modelBuilder.Entity<Person>().HasRequired(p => p.Job);
            modelBuilder.Entity<Person>().HasRequired(p => p.Status);
        }

        public DbSet<Activity> Activity { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<OfficeHour> OfficeHour { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
