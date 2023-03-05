using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Video 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid videoID { get; set; }
        public string videoURL { get; set; }
    }
}
