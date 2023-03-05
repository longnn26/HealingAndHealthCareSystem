using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Fee 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid feeID { get; set; }
        public Guid typeOfFeeID { get; set; }
        [ForeignKey("typeOfFeeID")]
        public virtual TypeOfFee TypeOfFee { get; set; }
        public float fee { get; set; }
    }
}
