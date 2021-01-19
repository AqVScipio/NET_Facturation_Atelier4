using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class DashboardDto
    {
        public DashboardDto()
        {

        }
        public DashboardDto(IBusinessData from)
        {
            CA = from.CA;
            Percu = from.Percu;
            MontantDus = from
                .GetFactures(DateTime.Now, null)
                .Select(f => new MontantDuDto(f));
        }
        public DashboardDto(IEnumerable<Facture> from)
        {
            foreach (Facture item in from)
            {
                CA += item.Montant;
                Percu += item.MontantRegle;
                MontantDus.Append(new MontantDuDto(item));
            }
        }

        public decimal CA { get; set; }
        public decimal Percu { get; set; }

        public IEnumerable<MontantDuDto> MontantDus { get; set; }
    }
}
