using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Serilog;
using SDSCom.Models;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationSettingsService : BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        public  ApplicationSettingsService(SDSComContext _db, IMemoryCache _cache) 
            : base(_db, _cache)
        {
            db = _db;
            cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<ApplicationSetting> GetAll()
        {
             return  db.AppSettingsReader.ToList();          
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

            appSetting = db.AppSettingsReader.Single(x => x.Area == area && x.Setting == setting);

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
             
            if (id > 0)
            {
                appSetting = db.AppSettingsReader.Single(x => x.Id == id);
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
                db.AppSettings.Remove(appSetting);
                db.SaveChanges();
                ok = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ApplicationSettingService>Delete");
            }
            return ok;
        }
    }
}
