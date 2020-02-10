using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Activity
    {
        #region Attributes
        public int IdActivity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime TimeTotal { get; set; }
        public Agenda Agenda { get; set; }
        #endregion

        #region Constructor
        public Activity()
        {

        }
        #endregion
    }
}
