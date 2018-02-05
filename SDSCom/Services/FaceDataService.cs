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
using SDSCom.Models;
using System.Data;
using System;
using System.Collections.Generic;

namespace SDSCom.Services
{
    public class FaceDataService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public FaceDataService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            this.config = _config;
            this.cache = _cache;
        }

        #region Values

        public bool SaveValue(FacetValue fval)
        {
            bool ok = false;

            if (fval == null) return ok;

            using (var db = new SDSComContext(config))
            {
                //db.Update(new FacetValue { StopDateStamp = DateTime.Now},
                //   p => p.EntityId == fval.EntityId 
                //             && p.FacetId == fval.FacetId);

                //db.Insert<FacetValue>(fval);
            }
            return ok;
        }


        #endregion

        #region Phrases

        public bool SavePhrases(List<FacetPhraseLink> fphrases)
        {
            bool ok = false;

            if (fphrases == null) return ok;

            int entityid = fphrases[0].EntityId;
            int facetid = fphrases[0].FacetId;

            using (var db = new SDSComContext(config))
            {
                //db.UpdateOnly(() => new FacetPhraseLink {
                //    StopDateStamp = DateTime.Now }, 
                //    where: p => p.EntityId == entityid
                //             && p.FacetId == facetid);

                //ok = db.Save<List<FacetPhraseLink>>(fphrases);
            }

            return ok;
        }



        #endregion



    }

}
