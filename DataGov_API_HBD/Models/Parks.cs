using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGov_API_HBD.Models
{
    public class Parks
    {
        public string total { get; set; }
        public Park[] data { get; set; }
        public string limit { get; set; }
        public string start { get; set; }
    }

    public class Park
    {
        public string id { get; set; }
        public string name { get; set; }
        public Park[] parks { get; set; }
    }


}
