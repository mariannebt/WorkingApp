using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WorkApp.Entity
{
    public class Agenda 
    {
        #region Attributes
        public int IdAgenda { get; set; }
        public DateTime InclusionDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string User { get; set; }
        public List<Activity> Activities { get; set; }
        public virtual Person Person { get; set; }
        #endregion

        #region Constructor
        public Agenda()
        {

        }
        #endregion
    }
}
