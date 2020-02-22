using System;
using System.Collections.Generic;
using System.Text;

namespace WorkApp.Entity
{
    public class Profile
    {
        #region Attributes
        public int IdProfile { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InclusionDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string User { get; set; }
        public virtual List<Person> Persons { get; set; }
        #endregion

        #region Constructor
        public Profile()
        {
        }
        #endregion
    }
}
