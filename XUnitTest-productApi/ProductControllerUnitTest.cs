using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;
using Xunit;
using XUnitTest_productApi.Setups;

namespace XUnitTest_productApi
{
   public class ProductControllerUnitTest
    {
        [Fact]
        public async Task TestGetStockItemsAsync()
        {
            // Arrange
            //var dbContext = DbContextMocker.GetWideWorldImportersDbContext(nameof(TestGetStockItemsAsync));
            //var controller = new ProductsController(null, dbContext);
            //public ProductsController(IProductService categoryService, IMapper mapper)

            // Arrange
            List<ProductInfos> list = new List<ProductInfos>();
            list.Add( new ProductInfos() { Id=1,Productname="aed",Unitprice=9});
           
            var valueServiceMock = new Mock<IProductService>();
            valueServiceMock.Setup(service => service.ListAsync())
            .Returns(Task.FromResult<IEnumerable<ProductInfos>> (list));
            var controller = new ProductsController(valueServiceMock.Object);

            // Act
            var response = await controller.GetAllSales() as ObjectResult;
            var values = response.Value  as List<ProductInfos>;
            
            //Assert
           Assert.Equal(values[0].Productname, "aed");
            Assert.Equal(values.Count, 1);

        }
       
    }
}
