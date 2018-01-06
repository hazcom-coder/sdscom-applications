using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Npgsql.PostgresTypes;
using Npgsql;
using SDSCom.Models;
using System.Data;
using ServiceStack.OrmLite;
using ServiceStack;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationSettingsService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;


        /// <summary>
        /// 
        /// </summary>
        public  ApplicationSettingsService(IConfiguration _config, IMemoryCache _cache) 
            : base(_config, _cache)
        {
            this.config = _config;
            this.cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<ApplicationSetting> GetAll()
        {
            List<ApplicationSetting> settings = new List<ApplicationSetting>();
            using (IDbConnection db = DbFactory.Open())
            {
                settings = db.Select<ApplicationSetting>();
            }
            return settings;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="setting"></param>
        /// <returns></returns>
        public ApplicationSetting Get(string area, string setting)
        {
            ApplicationSetting appSetting = new ApplicationSetting();

            List<ApplicationSetting> settings = GetAll();

            using (IDbConnection db = DbFactory.Open())
            {
                appSetting = db.Select<ApplicationSetting>(x => x.Area == area && x.Setting == setting).FirstOrDefault();
            }

            if (appSetting == null ) appSetting = new ApplicationSetting();

            return appSetting;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="setting"></param>
        /// <param name="datavalue"></param>
        /// <returns></returns>
        public bool Set(string area, string setting, string datavalue)
        {
            bool ok = false;

            using (IDbConnection db = DbFactory.Open())
            {
                db.Save(new ApplicationSetting() { Area = area, Setting = setting, DataValue = datavalue });
            }           

            return ok;
        }

    }
}
