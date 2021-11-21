using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.models
{
    public class Contract
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int InsuranseID { get; set; }
        public InsuranseVariant Insuranse { get; set; }
        public int WorkerID { get; set; }
        public Worker Worker { get; set; }
        public float Sum { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return Insuranse.ToString();
        }
    }
}
