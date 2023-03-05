using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class FreePhysioScheduleCreateModel
    {

        public Guid freeDayID { get; set; }
        public Guid physiotherapistID { get; set; }

        public string description { get; set; }
    }
    public class FreePhysioScheduleUpdateModel
    {
        public Guid freeScheduleID { get; set; }

        public Guid freeDayID { get; set; }

        public Guid physiotherapistID { get; set; }



        public string description { get; set; }

    }
    public class FreePhysioScheduleModel : FreePhysioScheduleUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}

