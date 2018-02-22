using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDSCom;
using SDSCom.Services;
using SDSCom.Models;
using System;

namespace SDSComTests
{
    [TestClass]
    public class EntityTests
    {
        static DbContextOptions options;
        static SDSComContext db;
        static IMemoryCache cache;
        static EntityService eSvc;

        [ClassInitialize]
        public static void AssmStart(TestContext context)
        {
            options = new DbContextOptionsBuilder<SDSComContext>()
                .UseInMemoryDatabase(databaseName: "SDSCom_Entity_Tests")
                .Options;

            db = new SDSComContext(options);
            cache = null;

            eSvc = new EntityService(db, cache);
        }

        [ClassCleanup]
        public static void AssmStop()
        {

        }
       

    }
}
