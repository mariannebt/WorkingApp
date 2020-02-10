using System;

namespace Entity
{
    public class Person
    {
        #region Attributes
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Profile JobProfile { get; set; }
        public Person Manager { get; set; }
        public Job Role { get; set; }
        public Status Status { get; set; }
        public OfficeHours WorkHours { get; set; }
        public Agenda Schedule { get; set; }
        #endregion

        #region Constructor
        public Person()
        {

        }
        #endregion

    }
}
