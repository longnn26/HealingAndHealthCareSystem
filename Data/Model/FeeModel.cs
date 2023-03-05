using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{

    public class FeeCreateModel

    {
        public Guid typeOfFeeID { get; set; }
        public float fee { get; set; }
    }
    public class FeeUpdateModel
    {
        public Guid feeID { get; set; }
        public Guid typeOfFeeID { get; set; }
        public float fee { get; set; }
    }
    public class FeeModel : FeeUpdateModel

    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}


