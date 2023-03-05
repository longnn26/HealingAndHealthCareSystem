using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ImageCreateModel
    {
        public string imageURL { get; set; }
    }
    public class ImageUpdateModel
    {
        public Guid imageID { get; set; }
        public string imageURL { get; set; }
    }
    public class ImageModel : ImageUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}