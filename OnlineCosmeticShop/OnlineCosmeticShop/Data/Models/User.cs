﻿namespace OnlineCosmeticShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.User;

    public class User : IdentityUser
    {
        [Required]
        [MaxLength(DefaultMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string LastName { get; set; }

        public int ShippingDetailsId { get; set; }
    }
}
