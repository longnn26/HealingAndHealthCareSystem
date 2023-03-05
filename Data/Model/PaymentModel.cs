using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class PaymentCreateModel
    {
        public Guid ScheduldeDetailID { get; set; }
        public float totalPrice { get; set; }
    }
    public class PaymentUpdateModel
    {
        public Guid paymentID { get; set; }
        public Guid schedultDetailID { get; set; }
        public float totalPrice { get; set; }
    }
    public class PaymentModel : PaymentUpdateModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}

