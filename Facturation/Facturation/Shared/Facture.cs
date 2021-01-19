using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class Facture
    {
        public static int DEADLINE_WARNING = 14;
        public static int DEADLINE_ALERT = 2;

        [Required]
        [StringLength(15, MinimumLength =10)]
        public string Numero { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Client { get; set; }
        [Required]
        public DateTime DateReglement { get; set; }


        [Required]
        [Range(0.1, double.MaxValue)]
        public decimal Montant { get; set; }
        [Required]
        [Range(0.1, double.MaxValue)]
        public decimal MontantRegle { get; set; }

        public static int NbDaysRemaining(DateTime date)
        {
            return (int)Math.Truncate((date - DateTime.Now).TotalDays);
        }
    }
}
