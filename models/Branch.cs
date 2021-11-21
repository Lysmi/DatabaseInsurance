using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Database.models
{
    public class Branch
    {
        public int ID { get; set; }
        public int OfficeID { get; set; }
        public Office Office { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }

        public string Adress { get; set; }
        public string Phone { get; set; }
        public int Year { get; set; }
        public int AmountWorkers { get; set; }

        public override string ToString()
        {
            return Adress;
        }
    }
}
