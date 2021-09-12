namespace OnlineCosmeticShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static DataConstants.User;

    public class User : IdentityUser
    {
        [Required]
        [MaxLength(DefaultMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string LastName { get; set; }
    }
}
