using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class TypeOfFeeCreateModel
    {
        public string serviceCharge { get; set; }
    }
    public class TypeOfFeeUpdateModel
    {
        public Guid typeOfFeeID { get; set; }
        public string serviceCharge { get; set; }
    }
    public class TypeOfFeeModel : TypeOfFeeUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}