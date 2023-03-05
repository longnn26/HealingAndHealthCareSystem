using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class UserExercise 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid userExercise { get; set; }
        public Guid exerciseID { get; set; }
        [ForeignKey("exerciseID")]
        public virtual Exercise Exercise { get; set; }
        public Guid Id { get; set; }
        [ForeignKey("Id")]
        public virtual User User { get; set; }
    }
}
