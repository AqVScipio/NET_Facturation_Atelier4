using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class FactureSorting
    {
        public string SortBy { get; set; }
        public string Order { get; set; }

        public FactureSorting(string sortBy, string order)
        {
            SortBy = sortBy;
            Order = order;
        }
    }

    public static class E_FactureSortBy
    {
        public static bool MatchesFactureElement(this string elementToCheck)
        {
            return elementToCheck switch
            {
                DateReglement => true,
                Numero => true,
                Client => true,
                Montant => true,
                _ => false,
            };
        }
        public static bool MatchesSortOrder(this string elementToCheck)
        {
            return elementToCheck switch
            {
                ASC => true,
                DESC => true,
                _ => false,
            };
        }
        public const string DateReglement = "DateReglement";
        public const string Numero = "Numero";
        public const string Client = "Client";
        public const string Montant = "Montant";
        public const string ASC = "ASC";
        public const string DESC = "DESC";
    }
}
