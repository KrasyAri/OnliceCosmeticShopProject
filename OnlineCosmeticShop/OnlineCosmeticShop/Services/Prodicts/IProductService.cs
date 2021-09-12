namespace OnlineCosmeticShop.Services.Prodicts
{
    using OnlineCosmeticShop.Data.Enums;
    using OnlineCosmeticShop.Models;
    using OnlineCosmeticShop.Services.Products.Models;
    using System.Collections.Generic;

    public interface IProductService
    {
        ProductQueryServiceModel All(
           string name,
           string searchTerm,
           ProductSorting sorting,
           int currentPage,
           int productsPerPage);


        int Create(
            string productCode,
            string name,
            string tradePartnerPrice,
            string price,
            int quantity,
            int netWeight,
            string description,
            string imageUrl,
            Series series,
            ProductType productType,
            Category category);

        bool Edit(
            int id,
            string productCode,
            string name,
            string tradePartnerPrice,
            string price,
            int quantity,
            int netWeight,
            string description,
            string imageUrl,
            Series series,
            ProductType productType,
            Category category);

        bool Delete(int id);

        IEnumerable<NewestProductsServiceModel> NewestProducts();

        public ProductsDetailsServiceModel Details(int id);

        IEnumerable<string> AllProductNames();
    }
}
