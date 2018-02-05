using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using Microsoft.Extensions.Caching.Memory;

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
                
            using (var db = new SDSComContext(config))
            {
                var allAS = db.Set<ApplicationSetting>();
                db.AppSettings.RemoveRange(allAS);

                var allE = db.Set<Entity>();
                db.Entities.RemoveRange(allE);

                var allET = db.Set<EntityType>();
                db.EntityTypes.RemoveRange(allET);

                var allDSFI = db.Set<DataSheetFeedImport>();
                db.Imports.RemoveRange(allDSFI);

                var allEC = db.Set<EntityChapter>();
                db.EntityChapters.RemoveRange(allEC);

                var allF = db.Set<Facet>();
                db.Facets.RemoveRange(allF);

                var allFR = db.Set<FacetRestriction>();
                db.FacetRestrictions.RemoveRange(allFR);

                var allFPL = db.Set<FacetPhraseLink>();
                db.FacetPhraseLinks.RemoveRange(allFPL);

                var allV = db.Set<ValidationMessage>();
                db.ValidationMessages.RemoveRange(allV);

                var allU = db.Set<User>();
                db.Users.RemoveRange(allU);

                db.SaveChanges();

                SchemaService sSvc = new SchemaService(config,cache);

                //=========================================================================================================

                facets = sSvc.GetSchemas();

                facetsRest = sSvc.GetDataTypes(facets, "SDSComXMLDT.xsd");
                
                //=========================================================================================================
                               
                facetsDE = sSvc.GetExtensions();

                facetsRestDE = sSvc.GetDataTypes(facetsDE, "SDSComXMLNE_DE.xsd");

                //=========================================================================================================

                sSvc.CreateFacets(facets);

                sSvc.CreateFacets(facetsDE);

                sSvc.CreateFacetRestrictionss(facetsRest);

                sSvc.CreateFacetRestrictionss(facetsRestDE);

                //=========================================================================================================

                db.Entities.Add(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestProduct 1",
                    EntityType = 1,
                    OtherId = "TestProd1"
                });

                db.Entities.Add(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestProduct 2",
                    EntityType = 1,
                    OtherId = "TestProd2"
                });

                db.Entities.Add(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestComponent 1",
                    EntityType = 2,
                    OtherId = "TestComp1"
                });

                db.Entities.Add(new Entity
                {
                    Active = true,
                    DateStamp = DateTime.Now,
                    UserId = 1,
                    EntityName = "TestComponent 2",
                    EntityType = 2,
                    OtherId = "TestComp2"
                });

                //===========================================================================================

                db.EntityTypes.Add(new EntityType { EntityTypeName = "Product" });
                db.EntityTypes.Add(new EntityType { EntityTypeName = "Component" });
                db.EntityTypes.Add(new EntityType { EntityTypeName = "Company" });

                //===========================================================================================

                db.AppSettings.Add(new ApplicationSetting
                {
                    Area = "DEFAULT",
                    Setting = "XmlStandardVersionNo",
                    DataValue = "4.2.0"
                });

                db.AppSettings.Add(new ApplicationSetting
                {
                    Area = "ADMIN",
                    Setting = "CompanyName",
                    DataValue = "Test Company"
                });

                db.AppSettings.Add(new ApplicationSetting
                {
                    Area = "ADMIN",
                    Setting = "StartDate",
                    DataValue = "12/1/2017"
                });

                //===========================================================================================

                db.Users.AddRange(new User
                {
                    Active = true,
                    CreateDate = DateTime.Now,
                    FirstName = "First 1",
                    LastName = "Last 1",
                    Password = "abc",
                    UpdateDate = DateTime.Now,
                    UserName = "First1",
                    Email = "First1@gmail.com"
                },
                    new User
                {
                    Active = true,
                    CreateDate = DateTime.Now,
                    FirstName = "First 2",
                    LastName = "Last 2",
                    Password = "abc",
                    UpdateDate = DateTime.Now,
                    UserName = "First2",
                    Email = "First2@gmail.com"
                }
                    ,new User
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

                db.SaveChanges();

                //===========================================================================================
            }
        }
    }
}
