using Persistance.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest_productApi.Setups
{
    public static class DbContextExtensions
    {
        public static void Seed(this kwooncjpContext dbContext)
        {
            // Add entities for DbContext instance

            dbContext.Productinfos.Add(new Productinfos
            {
                Id = 1,
                Productname = "Test",
                Unitprice = 1
            });
        }
    }
}
