using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.models
{
    public class Worker
    {
        public int ID { get; set; }
        public int BranchID { get; set; }
        public Branch Branch { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Patronimic { get; set; }
        public override string ToString()
        {
            return Surname + " " + FirstName + " " + Patronimic;
        }

    }
}
