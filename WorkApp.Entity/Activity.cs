using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkApp.Entity
{
    public class Activity
    {
        #region Attributes
        public int IdActivity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime ExpectedTime { get; set; }
        //public virtual Agenda Agenda { get; set; } // All Activity has an agenda
        public string Status { get; set; } // All Activity has a status
        public DateTime InclusionDt { get; set; }
        
        public DateTime UpdateDt { get; set; }
        public string User{ get; set; }

        // Entity Framework

        //public virtual Agenda IdAgenda { get; set; }
        [ForeignKey("IdAgenda")]
        public virtual Agenda Agenda { get; set; }
        public int IdAgenda { get; set; }

        #endregion

        #region Constructor
        public Activity()
        {

        }
        #endregion
    }
}
