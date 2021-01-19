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

        public int Id { get; set; }

        [Required(ErrorMessage = "Numero requis.")]
        [StringLength(15, MinimumLength =6, ErrorMessage = "Doit être compris entre 6 et 15 caractères.")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Client requis.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage ="Doit être compris entre 2 et 50 caractères.")]
        public string Client { get; set; }
        [Required(ErrorMessage = "Date estimée de règlement requise.")]
        public DateTime DateReglement { get; set; }


        [Required(ErrorMessage = "Montant requis.")]
        [Range(0, double.MaxValue, ErrorMessage = "Doit valoir au minimum 0.")]
        public decimal Montant { get; set; }
        [Required(ErrorMessage = "Montant réglé requis.")]
        [Range(0, double.MaxValue, ErrorMessage = "Doit valoir au minimum 0.")]
        public decimal MontantRegle { get; set; }

        public static int NbDaysRemaining(DateTime date)
        {
            return (int)Math.Truncate((date - DateTime.Now).TotalDays);
        }
    }
}
