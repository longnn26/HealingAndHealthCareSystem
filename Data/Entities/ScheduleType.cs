using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ScheduleType 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid scheduleTypeID { get; set; }
        public string typeOfName { get; set; }
        public string description { get; set; }
    }
}
