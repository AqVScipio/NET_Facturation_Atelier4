using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class FactureRef
    {
        public string FReference { get; set; }
        public FactureRef(string fRef)
        {
            FReference = fRef;
        }
    }
}
