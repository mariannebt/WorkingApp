using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkApp.Entity
{
    public class OfficeHour
    {
        #region Attributes
        public int IdOfficeHour { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartBreak { get; set; }
        public DateTime EndBreak { get; set; }
        public DateTime InclusionDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string User { get; set; }
        //Entity Framework
        [ForeignKey("IdEmployee")]
        public virtual Person Employee { get; set; }
        public int IdEmployee { get; set; }
        #endregion

        #region Constructor
        public OfficeHour()
        {

        }
        #endregion
    }
}
