using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class TypeOfFee 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid typeOfFeeID { get; set; }
        public string serviceCharge { get; set; }
    }
}
