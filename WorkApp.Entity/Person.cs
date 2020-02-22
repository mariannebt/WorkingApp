using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WorkApp.Entity
{
    public class Person
    {
        #region Attributes
        [ForeignKey("Agenda")]
        public int IdPerson { get; set; }
       // public int IdAgenda { get; set; }
        public int IdManager { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime InclusionDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string User { get; set; }
        public virtual List<OfficeHour> WorkHours { get; set; }
        public virtual List<Activity> Activities { get; set; }
       
        // Entity Framework

        public virtual Agenda Agenda { get; set; }
        
        [ForeignKey("IdProfile")]
        public virtual Profile Profile { get; set; }
        public int IdProfile { get; set; }
        [ForeignKey("IdJob")]
        public virtual Job Job { get; set; }
        public int IdJob { get; set; }
        [ForeignKey("IdStatus")]
        public virtual Status Status { get; set; }
        public int IdStatus { get; set; }
        #endregion

        #region Constructor
        public Person()
        {

        }
        #endregion

    }
}
