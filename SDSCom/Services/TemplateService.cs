﻿using System;
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
        private readonly SDSComContext db;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public TemplateService(SDSComContext _db, IMemoryCache _cache) : base(_db, _cache)
        {
            db = _db;
            cache = _cache;           
        }

        //===============================================================================================

        public List<Facet> GetFacetList(int parentid)
        {           
            return db.Facets.Where(p => p.Id == parentid).ToList();
        }



        public Facet GetFacetByID(int facetid)
        {            
            return db.Facets.Find(facetid);           
        }

        public string GetEntityChapterData(long entityid, string chaptername)
        {
            string ret = string.Empty;
           
            var ec = db.EntityChapters.Single(x => x.EntityId == entityid 
                                                && x.ChapterName == chaptername);

            if (ec != null)
            {
                ret = ec.Data;
            }     
            
            return ret;
        }

        public bool SaveEntityChapterData(long entityid, string chaptername, string data, int userid)
        {
            bool ok = false;

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

            return ok;
        }

        public FacetRestriction GetRestrictions(int facetid)
        {
            return  db.FacetRestrictions.Single(x => x.FacetId == facetid);
        }

        //===============================================================================================

        public bool SaveChapter0(InformationFromExportingSystem sysInfo)
        {
            bool ok = false;


            return ok;
        }



    }
}
