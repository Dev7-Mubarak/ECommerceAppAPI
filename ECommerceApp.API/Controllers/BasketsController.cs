﻿using AutoMapper;
using ECommerceApp.Business.DTOs;
using ECommerceApp.Business.Interfaces;
using ECommerceApp.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerceApp.API.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
       
        IMapper mapper;
        private readonly IBasketService _basketService;

        public BasketsController(IMapper mapper, IBasketService basketService)
        {
            this.mapper=mapper;
            _basketService=basketService;
        }
        [HttpPost("Create")]
        public async Task <IActionResult> Create(BasketDto cardto)
        {
            if (cardto == null)
            {
                return BadRequest("is Null");
            }

          await _basketService.Create(cardto);
            return Ok(cardto);
        }
    }
}
