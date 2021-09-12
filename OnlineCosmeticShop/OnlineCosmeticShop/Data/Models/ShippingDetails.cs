namespace OnlineCosmeticShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static DataConstants.ShippingDetails;

    public class ShippingDetails
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(CountryMaxLenght)]
        public string Country { get; set; }

        [Required]
        [MaxLength(CityMaxLenght)]
        public string City { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(DeliveryCompanyMax)]
        public string DeliveryCompanyOffice { get; set; }

        public string AdditionalInfo { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
