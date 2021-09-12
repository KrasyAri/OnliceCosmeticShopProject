namespace OnlineCosmeticShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static DataConstants.TradePartner;

    public class TradePartner
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(BulstatMaxLenght)]
        public string Bulstat { get; set; }

        [Required]
        [MaxLength(CompanyNameMaxLenght)]
        public string CompanyName { get; set; }


        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }


        [Required]
        public string UserId { get; set; }

    }
}
