using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using System.Xml.Schema;
using System.Reflection;
using Npgsql.PostgresTypes;
using Npgsql;
using System.Collections;
using Microsoft.Extensions.Caching.Memory;
using System.Data;

namespace SDSCom.Services
{
    public class ExportService : BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_db"></param>
        /// <param name="_cache"></param>
        public ExportService(SDSComContext _db, IMemoryCache _cache) : base(_db, _cache)
        {
            db = _db;
            cache = _cache;
        }

        public bool ExportOne(long entityId, string exportPath)
        {
            bool ok = false;



            return ok;

        }


    }
}
