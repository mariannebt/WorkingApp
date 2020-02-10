using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Job
    {
        #region Attributes
        public int IdJob { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        #endregion

        #region Constructor
        public Job()
        {

        }
        #endregion
    }
}
