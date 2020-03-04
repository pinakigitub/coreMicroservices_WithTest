using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _categoryService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService categoryService)
        {
            _categoryService = categoryService;
            //_mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllSales")]
        public async Task<ActionResult> GetAllSales()
        {
            var categories = await _categoryService.ListAsync();

            return Ok(categories);
        }
    }
}