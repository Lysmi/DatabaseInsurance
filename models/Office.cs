using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.models
{
    public class Office
    {
        public int ID { get; set; }
        public int TypePropertyID { get; set; }
        public TypeProperty TypeProperty { get; set; }
        public int LicenseID { get; set; }
        public License License { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }

        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
