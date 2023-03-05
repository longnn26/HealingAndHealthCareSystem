using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid paymentID { get; set; }
        public Guid scheduleDetailID { get; set; }
        [ForeignKey("scheduleDetailID")]
        public virtual ScheduleDetail ScheduleDetail { get; set; }
        public float totalPrice { get; set; }
    }
}
