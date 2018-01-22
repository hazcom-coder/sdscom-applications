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
using SDSCom.Models;
using System.Data;
using ServiceStack.OrmLite;

namespace SDSCom.Services
{
    public class TemplateService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public TemplateService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            this.config = _config;
            this.cache = _cache;
        }

        public List<Facet> GetFacetList(int parentid)
        {
            List<Facet> facets = new List<Facet>();

            using (IDbConnection db = DbFactory.Open())
            {
                facets = db.Select<Facet>("PARENT_ID = @pid", new { pid = parentid });
            }
            return facets;
        }

        public Facet GetFacetByID(int facetid)
        {
            Facet facet = new Facet();

            using (IDbConnection db = DbFactory.Open())
            {
                facet = db.Single<Facet>(x => x.Id == facetid);
            }
            return facet;
        }

        public FacetRestriction GetRestrictions(int facetid)
        {
            FacetRestriction restr = new FacetRestriction();

            using (IDbConnection db = DbFactory.Open())
            {
                restr = db.Single<FacetRestriction>(x => x.FacetId == facetid);
            }

            return restr;
        }


    }
}
