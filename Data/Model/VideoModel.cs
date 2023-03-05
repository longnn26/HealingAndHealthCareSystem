using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class VideoCreateModel
    {
        public string videoURL { get; set; }
    }
    public class VideoUpdateModel
    {
        public Guid videoID { get; set; }
        public string videoURL { get; set; }
    }
    public class VideoModel : VideoUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}