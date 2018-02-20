using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using System.Threading;
using Microsoft.Extensions.Primitives;
using SDSCom.Models;
using System.Data;
using System;
using System.Collections.Generic;

namespace SDSCom.Services
{
    public class FaceDataService : BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_db"></param>
        /// <param name="_cache"></param>
        public FaceDataService(SDSComContext _db, IMemoryCache _cache) : base(_db, _cache)
        {
            db = _db;
            cache = _cache;
        }

        #region Values

        public bool SaveValue(FacetValue fval)
        {
            bool ok = false;

            return ok;
        }


        #endregion

        #region Phrases

        public bool SavePhrases(List<FacetPhraseLink> fphrases)
        {
            bool ok = false;
        
            return ok;
        }

        #endregion
    }

}
