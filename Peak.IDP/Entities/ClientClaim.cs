using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peak.IDP.Entities
{
    public class ClientClaim
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public Client Client { get; set; }
    }
}
