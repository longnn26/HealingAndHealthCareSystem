using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ExerciseVideoCreateModel
    {
        public Guid videoID { get; set; }
        public Guid exerciseDetailID { get; set; }
    }
    public class ExerciseVideoUpdateModel
    {
        public Guid videoID { get; set; }
        public Guid exerciseDetailID { get; set; }
    }
    public class ExerciseVideoModel : ExerciseVideoUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}