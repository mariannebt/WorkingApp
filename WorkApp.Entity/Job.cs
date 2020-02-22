using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkApp.Entity
{
    public class Job
    {
        #region Attributes
        public int IdJob { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Person> Persons { get; set; }
        public DateTime InclusionDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string User { get; set; }
        #endregion

        #region Constructor
        public Job()
        {

        }
        #endregion
    }
}
