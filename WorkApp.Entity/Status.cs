using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkApp.Entity
{
    public class Status
    {
        #region Attributes
        public int IdStatus { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InclusionDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string User { get; set; }
        public List<Person> People { get; set; }
        #endregion

        #region Constructor
        public Status()
        {

        }
        #endregion
    }
}
