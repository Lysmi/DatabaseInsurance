using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Database.models
{
    public class License
    {
        public int ID { get; set; }
        public int Num { get; set; }
        public byte[] PhotoLicense { get; set; }
        public DateTime DataLicense { get; set; }

        public override string ToString()
        {
            return "№"+Num.ToString();
        }
    }
}
