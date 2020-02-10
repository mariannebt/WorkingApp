using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class OfficeHours
    {
        #region Attributes
        public int IdOfficeHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartBreak { get; set; }
        public DateTime EndBreak { get; set; }
        public Person Employee { get; set; }
        #endregion

        #region Constructor
        public OfficeHours()
        {

        }
        #endregion
    }
}
