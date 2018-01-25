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
using ServiceStack.OrmLite;
using System.Data;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public AdminService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            config = _config;
            cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CreateDBObjects()
        {
            List<Facet> facets = new List<Facet>();
            List<Facet> facetsDE = new List<Facet>();
            List<FacetRestriction> facetsRest = new List<FacetRestriction>();
            List<FacetRestriction> facetsRestDE = new List<FacetRestriction>();
                
            using (IDbConnection db = DbFactory.Open())
            {
                db.DropAndCreateTable<EntityChapter>();

                db.DropAndCreateTable<Facet>();

                db.DropAndCreateTable<FacetRestriction>();

                db.DropAndCreateTable<FacetPhraseLink>();

                db.DropAndCreateTable<FacetValue>();

                db.DropAndCreateTable<FacetPhraseLink>();

                db.DropAndCreateTable<ValidationMessage>();

                SchemaService dMgr = new SchemaService();

                //=========================================================================================================

                facets = dMgr.GetSchemas();

                facetsRest = dMgr.GetDataTypes(facets, "SDSComXMLDT.xsd");
                
                //=========================================================================================================
                               
                facetsDE = dMgr.GetExtensions();

                facetsRestDE = dMgr.GetDataTypes(facetsDE, "SDSComXMLNE_DE.xsd");

                //=========================================================================================================

                dMgr.CreateFacets(facets);

                dMgr.CreateFacets(facetsDE);

                dMgr.CreateFacetRestrictionss(facetsRest);

                dMgr.CreateFacetRestrictionss(facetsRestDE);

                //=========================================================================================================
                   
                db.DropAndCreateTable<Entity>();                              

                db.Save(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestProduct 1",
                    EntityType = 1,
                    OtherId = "TestProd1"
                });

                db.Save(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestProduct 2",
                    EntityType = 1,
                    OtherId = "TestProd2"
                });

                db.Save(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestComponent 1",
                    EntityType = 2,
                    OtherId = "TestComp1"
                });

                db.Save(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestComponent 2",
                    EntityType = 2,
                    OtherId = "TestComp2"
                });

                //===========================================================================================

                db.DropAndCreateTable<EntityType>();

                db.Save(new EntityType { EntityTypeName = "Product" });
                db.Save(new EntityType { EntityTypeName = "Component" });
                db.Save(new EntityType { EntityTypeName = "Company" });

                //===========================================================================================

                db.DropAndCreateTable<ApplicationSetting>();

                db.Save(new ApplicationSetting
                {
                    Area = "DEFAULT",
                    Setting = "XmlStandardVersionNo",
                    DataValue = "4.2.0"
                });

                db.Save(new ApplicationSetting
                {
                    Area = "ADMIN",
                    Setting = "CompanyName",
                    DataValue = "Test Company"
                });

                db.Save(new ApplicationSetting
                {
                    Area = "ADMIN",
                    Setting = "StartDate",
                    DataValue = "12/1/2017"
                });

                //===========================================================================================

                db.DropAndCreateTable<User>();

                db.Save(new User
                {
                    Active = true,
                    CreateDate = DateTime.Now,
                    FirstName = "First 1",
                    LastName = "Last 1",
                    Password = "abc",
                    UpdateDate = DateTime.Now,
                    UserName = "First1",
                    Email = "First1@gmail.com"
                });

                db.Save(new User
                {
                    Active = true,
                    CreateDate = DateTime.Now,
                    FirstName = "First 2",
                    LastName = "Last 2",
                    Password = "abc",
                    UpdateDate = DateTime.Now,
                    UserName = "First2",
                    Email = "First2@gmail.com"
                });

                db.Save(new User
                {
                    Active = true,
                    CreateDate = DateTime.Now,
                    FirstName = "First 3",
                    LastName = "Last 3",
                    Password = "abc",
                    UpdateDate = DateTime.Now,
                    UserName = "First3",
                    Email = "First3@gmail.com"
                });

                //===========================================================================================
            }
        }
    }
}
