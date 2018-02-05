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

namespace SDSCom.Services
{



//      SELECT 
//      'INSERT INTO PHRASES (structure_code, region, english,german,revision_date) 
//      VALUES( ''' + structure_code + ''', ''' + region + ''' , ''' + REPLACE(english,'''','''''') + ''', '''
//      + REPLACE(german,'''','''''')  + ''', ''' + ISNULL(CAST(revision_date AS VARCHAR),'') + ''');'
//      FROM PHRASES

    /// <summary>
    /// 
    /// </summary>
    public class PhraseService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public PhraseService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            this.config = _config;
            this.cache = _cache;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EuphracPhrase> Get(int maxrecords)
        {
            //NpgsqlCommand cmd = new NpgsqlCommand();
            //cmd.CommandText = @"SELECT * FROM phrases ";
            //if (maxrecords > 0)
            //{
            //    cmd.CommandText += "LIMIT " + maxrecords.ToString();
            //}
            //else
            //{
            //    cmd.CommandText += "LIMIT 100 "; 
            //}
            NpgsqlDataReader rdr = null; // = dataMgr.GetReader(cmd);

            return GetEuPhracPhraseFromReader(rdr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long GetCount()
        {
            long x = 0;
            //NpgsqlCommand cmd = new NpgsqlCommand();
            //cmd.CommandText = @"SELECT count(*) FROM public.phrases";
            //x = dataMgr.Execute(cmd);

            return x;
        }


        private List<EuphracPhrase> GetEuPhracPhraseFromReader(NpgsqlDataReader rdr)
        {
            List<EuphracPhrase> phrases = new List<EuphracPhrase>();

            while (rdr.Read())
            {
                EuphracPhrase phrase = new EuphracPhrase
                {
                    EuPhraCStructureCode = rdr["structure_code"] as string,
                    English = rdr["english"] as string,
                    German = rdr["german"] as string
                };
                phrases.Add(phrase);
            }
            rdr.Close();
            return phrases;
        }
    }
}
