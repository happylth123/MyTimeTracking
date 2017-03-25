using MyTimeTracking.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.Data.Models
{
    public class User
    {
        /// <summary>
        /// UserId
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// User Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User PassWord
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User Profile Gravatar
        /// </summary>
        public string ProfileGravatar { get; set; }

        /// <summary>
        /// UserType
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// DeletedOn time
        /// </summary>
        public DateTime? DeletedOn { get; set; }

        /// <summary>
        /// CreatedOn time
        /// </summary>
        public DateTime? CreatedOn { get; set; }
    }
}
