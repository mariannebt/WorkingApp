using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Profile
    {
        #region Attributes
        public int IdProfile { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        #endregion

        #region Constructor
        public Profile()
        {
        }
        #endregion
    }
}
