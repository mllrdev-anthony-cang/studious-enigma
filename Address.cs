using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSC.BL
{
    public class Address
    {
        public int Id { get; set; }
        public string HouseBuildingStreet { get; set; }
        public string Province { get; set; }
        public string CityMunicipality { get; set; }
        public string Barangay { get; set; }
        public int CustomerId { get; set; }
        
        public bool Validate
        {
            get
            {
                bool valid = true;

                if (string.IsNullOrWhiteSpace(HouseBuildingStreet)) valid = false;
                if (string.IsNullOrWhiteSpace(Province)) valid = false;
                if (string.IsNullOrWhiteSpace(CityMunicipality)) valid = false;
                if (string.IsNullOrWhiteSpace(Barangay)) valid = false;
                if (CustomerId < 1) valid = false;

                return valid;
            }
        }

        public List<string> ValidColumns
        {
            get
            {
                var list = new List<string>();

                if (Id > 0) list.Add("Id");
                if (string.IsNullOrWhiteSpace(HouseBuildingStreet) == false) list.Add("HouseBuildingStreet");
                if (string.IsNullOrWhiteSpace(Province) == false) list.Add("Province");
                if (string.IsNullOrWhiteSpace(CityMunicipality) == false) list.Add("CityMunicipality");
                if (string.IsNullOrWhiteSpace(Barangay) == false) list.Add("Barangay");

                return list;
            }
        }
    }
}
