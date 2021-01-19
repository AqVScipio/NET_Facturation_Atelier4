using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public static class Utils
    {
        public static string ToInputDate(this DateTime date)
        {
            string yyyy = date.Year.ToString();
            string MM = date.Month < 9 ? "0" + date.Month.ToString() : date.Month.ToString();
            string DD = date.Day < 9 ? "0" + date.Day.ToString() : date.Day.ToString();
            return yyyy + "-" + MM + "-" + DD;
        }

    }
}
