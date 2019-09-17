using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VitecovitchFinale.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Telephone Number")]
        public int TelephoneNumber { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Email { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        public long Cpr { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(100)]
        [Required]
        [Display(Name = "Supscription")]
        public string Subscribtion { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Monthly Price")]
        public double Price { get; set; }

        [Display(Name = "Reg nr.")]
        public int RegNr { get; set; }

        [Display(Name = "Account nr")]
        public long KontoNr { get; set; }
    }
}
