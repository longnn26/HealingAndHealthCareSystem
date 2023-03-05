using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class FreePhysioSchedule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid freeScheduleID { get; set; }

        public Guid freeDayID { get; set; }
        [ForeignKey("freeDayID")]
        public virtual FreeDay  FreeDay { get; set; }
        public Guid physiotherapistID { get; set; }
        [ForeignKey("physiotherapistID")]
        public virtual PhysiotherapistDetail PhysiotherapistDetail { get; set; }

        public string description { get; set; }

    }
}
