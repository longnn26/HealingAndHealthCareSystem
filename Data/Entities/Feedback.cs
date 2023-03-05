using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Feedback 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid feedbackID { get; set; }
        public Guid Id { get; set; }
        [ForeignKey("Id")]
        public virtual User User { get; set; }
        public Guid scheduleDetailID { get; set; }
        [ForeignKey("scheduleDetailID")]
        public virtual ScheduleDetail ScheduleDetail { get; set; }
        public string comment { get; set; }
        public int ratingStar { get; set; }
    }
}
