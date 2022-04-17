using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Availability_CheckAPP.Models
{
    public class FoodOrder
    {
        public string CustomerName { get; set; }
        public string CustomerMail { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public string PaymentMethod { get; set; }
    }
}
