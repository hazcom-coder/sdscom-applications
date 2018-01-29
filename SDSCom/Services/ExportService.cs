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
using ServiceStack.OrmLite;
using System.Data;

namespace SDSCom.Services
{
    public class ExportService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public ExportService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            config = _config;
            cache = _cache;
        }

        public bool ExportOne(long entityId, string exportPath)
        {
            bool ok = false;



            return ok;

        }


    }
}
