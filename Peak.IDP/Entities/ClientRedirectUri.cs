using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peak.IDP.Entities
{
    public class ClientRedirectUri
    {
        public string RedirectUri { get; set; }
        public Client Client { get; set; }
    }
}
