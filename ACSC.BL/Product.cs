using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSC.BL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public bool Validate
        {
            get
            {
                bool valid = true;

                if (string.IsNullOrWhiteSpace(Name)) valid = false;
                if (string.IsNullOrWhiteSpace(Description)) valid = false;
                if (CurrentPrice == null || Math.Round(Convert.ToDouble(CurrentPrice),2) <= 0) valid = false;

                return valid;
            }
        }
        public List<string> ValidateSearchField
        {
            get
            {
                var list = new List<string>();

                if (Id > 0) list.Add("Id");
                if (string.IsNullOrWhiteSpace(Name) == false) list.Add("Name");
                if (string.IsNullOrWhiteSpace(Description) == false) list.Add("Description");
                if ((MinPrice != null && MinPrice > 0) && (MaxPrice != null && MaxPrice > 0)) list.Add("PriceRange");

                return list;
            }
        }
    }
}
