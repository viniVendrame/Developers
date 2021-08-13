using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Developer : Base
    {
        public User User { get; set; }
        public Profile Profile { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }
}
