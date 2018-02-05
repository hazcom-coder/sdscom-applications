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
using System.Reflection;

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

        //===============================================================================================

        public List<Facet> GetFacetList(int parentid)
        {
            List<Facet> facets = new List<Facet>();

            using (var db = new SDSComContext(config))
            {
                facets = db.Facets.Where(p => p.Id == parentid).ToList();
            }
            return facets;
        }



        public Facet GetFacetByID(int facetid)
        {
            Facet facet = new Facet();

            using (var db = new SDSComContext(config))
            {
                facet = db.Facets.Find(facetid);
            }
            return facet;
        }

        public string GetEntityChapterData(long entityid, string chaptername)
        {
            string ret = string.Empty;

            using (var db = new SDSComContext(config))
            {
                var ec = db.EntityChapters.Single(x => x.EntityId == entityid 
                                                    && x.ChapterName == chaptername);

                if (ec != null)
                {
                    ret = ec.Data;
                }                
            }
            return ret;
        }

        public bool SaveEntityChapterData(long entityid, string chaptername, string data, int userid)
        {
            bool ok = false;

            using (var db = new SDSComContext(config))
            {
                EntityChapter ec = new EntityChapter()
                {
                    EntityId = entityid,
                    ChapterName = chaptername,
                    Data = data,
                    DateStamp = DateTime.Now,
                    UserId = userid
                };

                db.EntityChapters.Add(ec);
                db.SaveChanges();
            }
            return ok;
        }

        public FacetRestriction GetRestrictions(int facetid)
        {
            FacetRestriction restr = new FacetRestriction();

            using (var db = new SDSComContext(config))
            {
                restr = db.FacetRestrictions.Single(x => x.FacetId == facetid);
            }

            return restr;
        }

        //===============================================================================================

        public bool SaveChapter0(InformationFromExportingSystem sysInfo)
        {
            bool ok = false;


            return ok;
        }



    }
}
