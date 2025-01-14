﻿namespace OnlineCosmeticShop.Models.Products
{
    using OnlineCosmeticShop.Data.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    using static OnlineCosmeticShop.Data.DataConstants.Product;

    public class ProductFormModel
    {
        [Required]
        [StringLength(ProductCodeMaxLenght, MinimumLength = ProductCodeMinLenght)]
        public string ProductCode { get; init; }


        [Required]
        [StringLength(ProductNameMaxLenght, MinimumLength = ProductNameMinLenght)]
        public string Name { get; init; }


        [Required]
        public string TradePartnerPrice { get; init; }


        [Required]
        public string Price { get; init; }

        public int Quantity { get; init; }


        [Range(ProductMinWeight, ProductMaxWeight)]
        public int NetWeight { get; init; }


        [Required]
        [StringLength(
            int.MaxValue,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = "The field Description must be a string with a minimum length of {2}.")]
        public string Description { get; init; }


        [Required]
        [Url]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; }


        public Series Series { get; init; }

        public Category Category { get; init; }


        [Display(Name = "Product Type")]
        public ProductType ProductType { get; set; }
    }
}
