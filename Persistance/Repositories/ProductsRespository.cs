using AutoMapper;
using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistance.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
   public class ProductsRespository: BaseRepository, IProductRespository
    {

        private readonly IMapper _mapper;

        public ProductsRespository(kwooncjpContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductInfos>> ListAsync()
        {
            var SalesList = await _context.Productinfos.ToListAsync();

            List<ProductInfos> SalesInfoList = _mapper.Map<List<ProductInfos>>(SalesList);
           return SalesInfoList;
          
        }
    }
}
