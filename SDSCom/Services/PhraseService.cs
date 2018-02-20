using System;
using System.Collections.Generic;
using SDSCom.Models;
using System.Xml.Schema;
using System.Reflection;
using System.Collections;
using Microsoft.Extensions.Caching.Memory;
using System.Linq;

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
        private readonly SDSComContext db;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public PhraseService(SDSComContext _db, IMemoryCache _cache) : base(_db, _cache)
        {
            db = _db;
            cache = _cache;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EuphracPhrase> Get(int maxrecords)
        {
            IQueryable<EuphracPhrase> phrases = (from s in db.Phrases select s).Take(maxrecords);
            return phrases.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long GetCount()
        {
            IQueryable<EuphracPhrase> phrases = (from s in db.Phrases select s);
            return phrases.Count();
        }      
    }
}
