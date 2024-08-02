﻿using AutoMapper;
using ECommerceApp.API.DTOs;
using ECommerceApp.Business.DTOs;
using ECommerceApp.Data.Entities;
using Microsoft.Build.Framework;

namespace ECommerceApp.Business.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Product, ProductDto>()
                .ReverseMap();

            CreateMap<Order, OrderDto>()
                .ReverseMap();

            //CreateMap<UpdateOrderDto, Order>()
            //    .ForMember(prdto => prdto.BrandName,
            //    opt => opt.MapFrom(src => src.Brand.Name))
            //    .ForMember(prdto => prdto.CategoryName,
            //    opt => opt.MapFrom(src => src.Category.Name))
            //    .ForMember(prdto => prdto.Images,
            //    opt => opt.MapFrom(src => src.ProductImages.Select(pi => pi.ImageURL.ToList())))
            //    .ReverseMap();


            CreateMap<UpdateOrderDto, Order>()
                .ReverseMap();



            CreateMap<Product, ProducrImageDto>()
               .ForMember(prdto => prdto.BrandName,
               opt => opt.MapFrom(src => src.Brand.Name))
               .ForMember(prdto => prdto.CategoryName,
               opt => opt.MapFrom(src => src.Category.Name))
               .ForMember(prdto => prdto.ImageUrls,
               opt => opt.MapFrom(src => src.ProductImages.Select(pi => pi.ImageURL.ToList())))
               .ReverseMap();



            CreateMap<Basket, BasketDto>()
               .ForMember(shop => shop.Items,
               opt => opt.MapFrom(src => src.catItems))
              .ReverseMap();




            CreateMap<BasketItem,BasketItemDto>()
                //.ForMember(car => car.BasketId,
                //opt => opt.MapFrom(src => src.ShoppingCartId))
                .ForMember(car => car.ProductId,
                opt => opt.MapFrom(src => src.ProdutId))
               .ReverseMap();











            //CreateMap<Product, ProductUpdateDto>()
            //   .ForMember(prdto => prdto.BrandName,
            //   opt => opt.MapFrom(src => src.Brand.Name))
            //   .ForMember(prdto => prdto.CategoryName,
            //   opt => opt.MapFrom(src => src.Category.Name))
            //   .ForMember(prdto => prdto.ImageUrls,
            //   opt => opt.MapFrom(src => src.ProductImages.Select(pi => pi.ImageURL.ToList())))
            //   .ReverseMap();



            //CreateMap<CartItemDto, CartItem >()
            //   .ReverseMap();


            //CreateMap<BasketDto, Basket >()
            //    .ForMember(shop => shop.catItems,
            //    opt => opt.MapFrom(src => src.Items))
            //   .ReverseMap();
















        }
    }
}
