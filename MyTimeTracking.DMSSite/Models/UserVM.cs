using MyTimeTracking.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTimeTracking.DMSSite.Models
{
    public class UserVM : BaseVM
    {
        [Required]
        [Display(Name = "Email Adress")]
        public string Email { get; set; }

        public string PassWord { get; set; }

        public string UserName { get; set; }

        public string ProfileGravatar { get; set; }

        public UserType UserType { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}