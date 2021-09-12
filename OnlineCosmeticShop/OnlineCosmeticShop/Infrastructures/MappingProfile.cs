namespace OnlineCosmeticShop.Infrastructures
{
    using AutoMapper;
    using OnlineCosmeticShop.Data.Models;
    using OnlineCosmeticShop.Models.Products;
    using OnlineCosmeticShop.Services.Products.Models;
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Product, NewestProductsServiceModel>();
            this.CreateMap<ProductsDetailsServiceModel, ProductFormModel>();

            this.CreateMap<Product, ProductServiceModel>();

            this.CreateMap<Product, ProductsDetailsServiceModel>();

            //this.CreateMap<CartItem, CartViewServiceMode>();

           // this.CreateMap<ShippingDetailsFormModel, ShippingDetails>();


        }
    }
}
