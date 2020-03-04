using Microsoft.EntityFrameworkCore;
using Persistance.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest_productApi.Setups
{
    public static class DbContextMocker
    {
        public static kwooncjpContext GetWideWorldImportersDbContext(string dbName)
        {
            // Create options for DbContext instance
            var options = new DbContextOptionsBuilder<kwooncjpContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            // Create instance of DbContext
            var dbContext = new kwooncjpContext(options);

            // Add entities in memory
            dbContext.Seed();

            return dbContext;
        }
    }
}
