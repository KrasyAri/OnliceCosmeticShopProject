namespace OnlineCosmeticShop.Models.Home
{
    using OnlineCosmeticShop.Services.Products.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class IndexViewModel
    {
        public IList<NewestProductsServiceModel> Products { get; init; }
    }
}
