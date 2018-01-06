using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using Npgsql.PostgresTypes;
using Npgsql.Schema;
using NpgsqlTypes;
using Npgsql.NameTranslation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;
using System.Threading;
using Microsoft.Extensions.Primitives;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class DataService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        private string connString;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public DataService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            this.config = _config;
            this.cache =_cache;

            connString = config["ConnectionStrings:SDSCOM"];           

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="ReturnId"></param>
        /// <param name="ReturnField"></param>
        /// <returns></returns>
        public Int64 Execute(NpgsqlCommand cmd, bool ReturnId = false , string ReturnField = "")
        {
            Int64 ret = 0;

            if(ReturnId)
            {
                if (string.IsNullOrEmpty(ReturnField))
                {
                    ReturnField = "ID";
                }
                cmd.CommandText = cmd.CommandText + " ; RETURNING " + ReturnField + " ; ";
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                cmd.Connection = conn;

                try
                {
                    ret = (Int64)cmd.ExecuteScalar();
                }
                catch (NpgsqlException ex)
                {
                    Console.Write(ex.Message);
                }
                finally { conn.Close(); }
            }
            return ret;
        }

        /// <summary>
        /// Close it when done
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public NpgsqlDataReader GetReader(NpgsqlCommand cmd)
        {
            NpgsqlDataReader rdr = null;

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            { 
                conn.Open();
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                Console.Write(ex.Message);
            }
           
            return rdr;
        }


        #region cache

        private static CancellationTokenSource cts = new CancellationTokenSource();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        public string GetCachedItem(string cacheKey)
        {            
            cache.TryGetValue<string>(cacheKey, out string obj);            
            return obj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <param name="itemContent"></param>
        /// <returns></returns>
        public bool SetCachedItem(string cacheKey, string itemContent)
        {
            cache.Set(cacheKey, itemContent, new CancellationChangeToken(cts.Token));
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheKey"></param>
        public void RemoveCachedItem(string cacheKey)
        {
            cache.Remove(cacheKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ClearCache()
        {
            if (cts != null && !cts.IsCancellationRequested && cts.Token.CanBeCanceled)
            {
                cts.Cancel();
                cts.Dispose();
            }

            cts = new CancellationTokenSource();
        }


        #endregion

    }
}
