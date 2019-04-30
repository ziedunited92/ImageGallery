using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peak.IDP.Entities
{
    public class ClientProperty
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Client Client { get; set; }
    }
}
