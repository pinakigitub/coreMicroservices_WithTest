using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Repositories;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRespository _productRepository;
        private readonly IMapper _mapper;

      public  ProductService(IProductRespository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductInfos>> ListAsync()
        {
            var resp = await _productRepository.ListAsync();
            return resp;
           
        }
    }
}
