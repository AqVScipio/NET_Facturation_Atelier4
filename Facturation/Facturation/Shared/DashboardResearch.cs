using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class DashboardResearch
    {
        public DateTime DateMin { get; set; }
        public DateTime DateMax { get; set; }

        public DashboardResearch()
        {
            int year = DateTime.Now.Year;
            DateMin = new DateTime(year, 1, 1);
            DateMax = new DateTime(year, 12, 31);
        }
    }
}
