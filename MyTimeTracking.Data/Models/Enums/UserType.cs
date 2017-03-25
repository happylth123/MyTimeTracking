using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.Data.Models.Enums
{
    public enum UserType
    {
        /// <summary>
        /// the Administrator
        /// </summary>
        [Description("Administrator")]
        Administrator = 0,

        /// <summary>
        /// the Customer
        /// </summary>
        [Description("User")]
        User = 1,
    }
}
