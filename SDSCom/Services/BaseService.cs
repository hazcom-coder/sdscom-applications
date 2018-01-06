using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using ServiceStack;
using System.Data;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
       
        /// <summary>
        /// 
        /// </summary>
        public BaseService(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;
            DbFactory = new OrmLiteConnectionFactory(config["ConnectionStrings:SDSCOM"], PostgreSqlDialect.Provider);
        }

        /// <summary>
        /// 
        /// </summary>
        public OrmLiteConnectionFactory DbFactory { get; set; }


    }
}
