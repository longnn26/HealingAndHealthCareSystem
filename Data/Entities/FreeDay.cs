using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class FreeDay
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid freeDayID { get; set; }
        public DateTime freeDate { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
    }
}
