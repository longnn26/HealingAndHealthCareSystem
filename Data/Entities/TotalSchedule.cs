using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class TotalSchedule : BaseEntities
    {
        public Guid totalScheduleID { get; set; }
        public Guid physiotherapistID { get; set; }
        [ForeignKey("physiotherapistID")]
        public virtual PhysiotherapistDetail PhysiotherapistDetail { get; set; }
        public Guid? Id { get; set; }
        [ForeignKey("Id")]
        public virtual User User { get; set; }
        public Guid freeScheduleID { get; set; }
        [ForeignKey("freescheduleID")]
        public virtual FreePhysioSchedule FreePhysioSchedule { get; set; }

        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
        public int duaration { get; set; }
    }
}
