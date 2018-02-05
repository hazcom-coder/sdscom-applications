using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationSettingsService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache id;

        /// <summary>
        /// 
        /// </summary>
        public  ApplicationSettingsService(IConfiguration _config, IMemoryCache _cache) 
            : base(_config, _cache)
        {
            this.config = _config;
            this.id = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<ApplicationSetting> GetAll()
        {
            List<ApplicationSetting> settings = new List<ApplicationSetting>();

            using (var db = new SDSComContext(config))
            {
                settings = db.AppSettingsReader.ToList();
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
            var appSetting = new ApplicationSetting();

            using (var db = new SDSComContext(config))
            {
                appSetting = db.AppSettings.Single(x => x.Area == area && x.Setting == setting);
            }

            if (appSetting == null ) appSetting = new ApplicationSetting();

            return appSetting;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="setting"></param>
        /// <returns></returns>
        public ApplicationSetting Get(long id)
        {
            var appSetting = new ApplicationSetting();

            using (var db = new SDSComContext(config))
            {              
                if (id > 0)
                {
                    appSetting = db.AppSettings.Single(x => x.Id == id);
                }
            }
            return appSetting;
        }
        
        /// <summary>
        /// Updates an application setting
        /// </summary>
        ///<param name="appSetting"></param>
        /// <returns></returns>
        public bool Save(ApplicationSetting appSetting)
        {
            bool ok = false;
            try
            {
                using (var db = new SDSComContext(config))
                {
                    if (appSetting.Id == 0)
                    {
                        db.AppSettings.Add(appSetting);
                    }
                    else
                    {
                        db.AppSettings.Update(appSetting);
                    }
                    ok =  (db.SaveChanges() == 1);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ApplicationSettingService>AddNew");
            }

            return ok;
        }

        /// <summary>
        /// Delete an application setting
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(ApplicationSetting appSetting)
        {
            bool ok = false;
            try
            {
                using (var db = new SDSComContext(config))
                {
                    db.AppSettings.Remove(appSetting);
                    db.SaveChanges();
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ApplicationSettingService>Delete");
            }

            return ok;
        }
    }
}
