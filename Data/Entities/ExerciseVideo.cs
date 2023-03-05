using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ExerciseVideo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid exerciseVideoID { get; set; }
        public Guid videoID { get; set; }
        [ForeignKey("videoID")]
        public virtual Video Video { get; set; }
        public Guid exerciseDetailID { get; set; }
        [ForeignKey("exerciseDetailID")]
        public virtual ExerciseDetail ExerciseDetail { get; set; }
    }
}
