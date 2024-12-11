using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_
{
    [Serializable]
    internal class FaultsClass
    {
        public string description { get; set; }
        public string location { get; set; }

        public FaultsClass(string des ,string location)
        { 
            this.description = des;
            this.location = location;
        }
    }
}
