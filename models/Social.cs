using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.models
{
    public class Social
    {
        public int ID { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return Position;
        }
    }
}
