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
    public class ImportExportTests
    {
        static DbContextOptions options;
        static SDSComContext db;
        static IMemoryCache cache;
        static ImportService iSvc;
        static ExportService eSvc;

        [ClassInitialize]
        public static void AssmStart(TestContext context)
        {
            options = new DbContextOptionsBuilder<SDSComContext>()
                .UseInMemoryDatabase(databaseName: "SDSCom_Imp_Exp_Tests")
                .Options;

            db = new SDSComContext(options);
            cache = null;

            iSvc = new ImportService(db, cache);
            eSvc = new ExportService(db, cache);
        }

        [ClassCleanup]
        public static void AssmStop()
        {

        }


    }
}
