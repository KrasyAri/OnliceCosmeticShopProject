namespace OnlineCosmeticShop.Services.Products.Models
{
    using OnlineCosmeticShop.Data.Enums;

    public class NewestProductsServiceModel
    {
        public int Id { get; init; }

        public string ProductCode { get; set; }

        public string Name { get; init; }

        public Series Series { get; init; }

        public string ImageUrl { get; init; }

        public decimal Price { get; init; }
    }
}
