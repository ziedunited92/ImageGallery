using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peak.IDP.Entities
{
    public class ClientCorsOrigin
    {
        public string Origin { get; set; }
        public Client Client { get; set; }
    }
}
