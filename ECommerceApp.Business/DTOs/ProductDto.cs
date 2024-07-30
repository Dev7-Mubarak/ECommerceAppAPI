﻿using Microsoft.AspNetCore.Http;

namespace ECommerceApp.API.DTOs
{
    public class ProductDto
    {
      
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public int? QuantityInStock { get; set; }
        public List<IFormFile>? Images {  get; set; }
    }
}
