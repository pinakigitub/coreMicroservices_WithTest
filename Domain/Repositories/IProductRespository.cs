using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
   public interface IProductRespository
    {
        Task<IEnumerable<ProductInfos>> ListAsync();
    }
}
