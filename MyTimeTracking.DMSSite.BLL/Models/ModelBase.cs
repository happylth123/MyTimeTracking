using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.DMSSite.BLL.Models
{
    public abstract class ModelBase
    {
        public virtual Guid ID { get; set; }
    }
}
