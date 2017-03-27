using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTimeTracking.DMSSite.Models
{
    public abstract class BaseVM
    {
        [Key]
        public Guid ID { get; set; }
    }
}