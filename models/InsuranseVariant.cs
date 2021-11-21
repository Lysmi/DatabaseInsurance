using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.models
{
    public class InsuranseVariant
    {
        public int ID { get; set; }
        public string Variant { get; set; }
        public override string ToString()
        {
            return Variant;
        }
    }
}
