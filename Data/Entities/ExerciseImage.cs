using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ExerciseImage 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid exerciseImageID { get; set; }
        public Guid imageID { get; set; }
        [ForeignKey("imageID")]
        public virtual Image Image { get; set; }
        public Guid exerciseDetailID { get; set; }
        [ForeignKey("exerciseDetailID")]
        public virtual ExerciseDetail ExerciseDetail { get; set; }
    }
}
