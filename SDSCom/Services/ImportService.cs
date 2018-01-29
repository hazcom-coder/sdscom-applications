using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using System.Xml;
using System.Xml.Schema;
using System.Reflection;
using Npgsql.PostgresTypes;
using Npgsql;
using System.Collections;
using Microsoft.Extensions.Caching.Memory;
using ServiceStack.OrmLite;
using System.Data;
using System.IO;
using System.Text;
using Serilog;

namespace SDSCom.Services
{
    public class ImportService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private SchemaService sSvc;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public ImportService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            config = _config;
            cache = _cache;
            sSvc = new SchemaService(config,cache);
        }

        public bool Import(string importPath)
        {
            bool ok = false;

            string fileContent = ReadFile(importPath);

            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(fileContent);

            }
            catch (Exception ex)
            {
                Log.Error(ex, "Import File Name:" + importPath);
            }

            return ok;

        }  
        
        private string ReadFile(string importPath)
        {
            string ret = string.Empty;

            try
            {   
                using (StreamReader sr = new StreamReader(importPath))
                {
                   ret = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "Import>ReadFile: File Name:" + importPath);
            }

            return ret;
        }
    }
}
