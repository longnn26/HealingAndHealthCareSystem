using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ExerciseImageCreateModel
    {
        public Guid imageID { get; set; }
        public Guid exerciseDetailID { get; set; }
    }
    public class ExerciseImageUpdateModel
    {
        public Guid imageID { get; set; }
        public Guid exerciseDetailID { get; set; }
    }
    public class ExerciseImageModel : ExerciseImageUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}