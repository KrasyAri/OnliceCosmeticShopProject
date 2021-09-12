namespace OnlineCosmeticShop.Services.Products.Models
{
    using OnlineCosmeticShop.Data.Enums;

    public class ProductServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Series Series { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal TradePartnerPrice { get; set; }

        public Category CategoryName { get; init; }
    }
}
