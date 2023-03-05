using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ScheduleDetailCreateModel
    {
        public Guid exerciseID { get; set; }
        public Guid totalScheduleID { get; set; }
        public Guid scheduleTypeID { get; set; }
        public Guid feeID { get; set; }
    }
    public class ScheduleDetailUpdateModel
    {
        public Guid scheduleDetailID { get; set; }
        public Guid exerciseID { get; set; }
        public Guid totalScheduleID { get; set; }
        public Guid scheduleTypeID { get; set; }
        public Guid feeID { get; set; }
    }
    public class ScheduleDetailModel : ScheduleDetailUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }

}


