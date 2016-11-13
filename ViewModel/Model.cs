using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Model
    {
        [Required(ErrorMessage = "Enter the name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Enter the amount")]
        public decimal InitialValue { get; set; }

        [Required(ErrorMessage = "Enter the cheque issue date")]
        [Display(Name = "Cheque Issue Date")]
        [DataType(DataType.Date)]
        public DateTime ChequeDate { get; set; }

        [Display(Name = "Printed Amount")]
        public string ConvertedWords { get; set; }

        [Display(Name = "Cheque Issue Date")]
        public string ChequeDateSTR
        {
            get
            {
                return ChequeDate.ToString("dd.MM.yyyy");
            }
        }

    }
}
