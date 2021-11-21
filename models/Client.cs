using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Database.models
{
    public class Client
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        [ForeignKey("CityID")]
        public City City { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Patronimic { get; set; }
        public int SocialID { get; set; }
        [ForeignKey("SocialID")]
        public Social Social { get; set; }
        public DateTime Birthday { get; set; }
        public string House { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return Surname+" "+FirstName+" "+Patronimic;
        } 
    }
}
