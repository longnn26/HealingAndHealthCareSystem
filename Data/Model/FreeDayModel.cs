using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class FreeDayCreateModel
    {
        public DateTime freeDate { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
    }
    public class FreeDayUpdateModel
    {
        public Guid freeDayID { get; set; }
        public DateTime freeDate { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }

    }
    public class FreeDayModel : FreeDayUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}

