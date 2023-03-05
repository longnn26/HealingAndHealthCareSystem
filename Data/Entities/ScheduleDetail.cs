using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ScheduleDetail 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid scheduleDetailID { get; set; }
        public Guid exerciseID { get; set; }
        [ForeignKey("exerciseID")]
        public virtual Exercise Exercise { get; set; }
        public Guid totalScheduleID { get; set; }
        [ForeignKey("totalScheduleID")]
        public virtual TotalSchedule TotalSchedule { get; set; }
        public Guid scheduleTypeID { get; set; }
        [ForeignKey("scheduleTypeID")]
        public virtual ScheduleType ScheduleType { get; set; }
        public Guid feeID { get; set; }
        [ForeignKey("feeID")]
        public virtual Fee Fee { get; set; }
    }
}
