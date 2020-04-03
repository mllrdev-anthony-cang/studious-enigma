using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSC.BL
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public string MinOrderDate { get; set; }
        public string MaxOrderDate { get; set; }

        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string ShippingAddress { get; set; }
        public bool Validate
        {
            get
            {
                bool valid = true;

                if (CustomerId < 1) valid = false;
                if (AddressId < 1) valid = false;
                if (OrderDate == null) valid = false;
                if (Math.Round(Convert.ToDouble(TotalAmount), 2) <= 0) valid = false;
                //if (OrderItems.Count() < 1) valid = false;

                return valid;
            }
        }

        public List<string> ValidateSearchField
        {
            get
            {
                var list = new List<string>();

                if (Id > 0) list.Add("Id");
                if (CustomerId > 0) list.Add("CustomerId");
                if (AddressId > 0) list.Add("AddressId");
                if (string.IsNullOrWhiteSpace(MinOrderDate) == false && string.IsNullOrWhiteSpace(MaxOrderDate) == false) list.Add("DateRange");
                if (string.IsNullOrEmpty(CustomerName) == false) list.Add("CustomerName");
                if (string.IsNullOrEmpty(CustomerPhoneNumber) == false) list.Add("CustomerPhoneNumber");
                if (string.IsNullOrEmpty(ShippingAddress) == false) list.Add("ShippingAddress");

                return list;
            }
        }
    }
}
