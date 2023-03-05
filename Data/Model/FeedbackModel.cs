using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class FeedbackCreateModel
    {
        public Guid Id { get; set; }

        public Guid userID { get; set; }
        public Guid scheduleDetailID { get; set; }
        public string comment { get; set; }
        public int ratingStar { get; set; }
    }
    public class FeedbackUpdateModel
    {
        public Guid feedbackID { get; set; }
        public string comment { get; set; }
        public int ratingStar { get; set; }
    }
    public class FeedbackModel : FeedbackUpdateModel
    {
        public Guid feedbackID { get; set; }
        public Guid userID { get; set; }
        public Guid scheduleDetailID { get; set; }
        public string comment { get; set; }
        public int ratingStar { get; set; }
    }
}
