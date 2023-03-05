using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ScheduleTypeCreateModel
    {
        public string typeOfName { get; set; }
        public string description { get; set; }
    }
    public class ScheduleTypeUpdateModel
    {
        public Guid scheduleTypeID { get; set; }
        public string typeOfName { get; set; }
        public string description { get; set; }
    }
    public class ScheduleTypeModel : ScheduleTypeUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}