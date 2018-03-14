using System;
using System.Collections.Generic;
using SDSCom.Models;
using Microsoft.Extensions.Caching.Memory;
using Serilog;
using System.Xml;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminService : BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private EntityService eSvc;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public AdminService(SDSComContext _db, IMemoryCache _cache) : base(_db, _cache)
        {
            db = _db;
            cache = _cache;
            eSvc = new EntityService(db, cache);
        }


        public void LoadComponents()
        {   
            try
            {
                List<Entity> entList = eSvc.GetByType(EntityTypeEnum.Component);
                db.Entities.RemoveRange(entList);
                db.SaveChanges();
                
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(@"files\ec-inventory-export.xml");

                XmlNode root = xdoc.DocumentElement;

                db.AppSettings.Add(new ApplicationSetting()
                    {
                        Area = "SUBSTANCES",
                        Setting = "EXPORT_DATE",
                        DataValue = root.Attributes["exportDate"].Value
                    });                

                db.AppSettings.Add(new ApplicationSetting()
                    {
                        Area = "SUBSTANCES",
                        Setting = "LAST_UPDATED",
                        DataValue = root.Attributes["lastUpdate"].Value
                    });
                
                db.AppSettings.Add(new ApplicationSetting()
                    {
                        Area = "SUBSTANCES",
                        Setting = "COUNT",
                        DataValue = root.Attributes["uniqueSustances"].Value
                    });               

                db.SaveChanges();

                //------------------------------------------------------------------------------------

                List<Entity> entities = new List<Entity>();     

                XmlNodeList substanceNodes = xdoc.SelectNodes("results/result");
                int x = 0;
                foreach (XmlNode substanceNode in substanceNodes)
                {
                    Entity entity = new Entity()
                    {
                        Active = true,
                        DateStamp = DateTime.Now,
                        EntityName = substanceNode.SelectSingleNode("name").Value ?? string.Empty,
                        EntityType = 2,
                        Id = 0,
                        OtherId = substanceNode.SelectSingleNode("cas-no").Value ?? string.Empty,
                        UserId = 1
                    };

                    entities.Add(entity);   
                    x++;
                    if (x >= 1000)  
                    {
                        db.Entities.AddRange(entities);
                        db.SaveChanges();
                        x = 0;
                        entities = new List<Entity>();
                    }  
                }
            
                db.Entities.AddRange(entities);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        public void LoadComponentsOld()
        {
            List<string> badOnes = new List<string>();
            
            List<Entity> entList = eSvc.GetByType(EntityTypeEnum.Component);
            db.Entities.RemoveRange(entList);
            db.SaveChanges();

            //For other formats visit : www.downloadexcelfiles.com,,
            //,,
            //Original source : en.wikipedia.org/wiki/Dictionary_of_chemical_formulas,,

            int counter = 0;
            string line;
            List<Entity> entities = new List<Entity>();
            System.IO.StreamReader file =  null;

            try
            {
                file = new System.IO.StreamReader(@"files\cas.csv");
                while ((line = file.ReadLine()) != null)
                {
                    string[] items = line.Split(",");

                    string formula = items[0];
                    string cas = items[2];
                    string chemname = items[1];

                    if ((cas.Trim().Length > 0) && (chemname.Trim().Length > 0))
                    {
                        Entity entity = new Entity()
                        {
                            Active = true,
                            DateStamp = DateTime.Now,
                            EntityName = chemname,
                            EntityType = 2,
                            Id = 0,
                            OtherId = cas,
                            UserId = 1
                        };

                        entities.Add(entity);
                    }
                    else
                    {
                        badOnes.Add(line);
                    }

                    counter++;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            finally
            {
                file.Close();
            }
            
            db.Entities.AddRange(entities);
            db.SaveChanges();

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
                
            
                var allAS = db.Set<ApplicationSetting>();
                db.AppSettings.RemoveRange(allAS);

                var allE = db.Set<Entity>();
                db.Entities.RemoveRange(allE);

                var allET = db.Set<EntityType>();
                db.EntityTypes.RemoveRange(allET);

                var allDSFI = db.Set<DataSheetFeedImport>();
                db.Imports.RemoveRange(allDSFI);
              
                var allF = db.Set<Facet>();
                db.Facets.RemoveRange(allF);

                var allFR = db.Set<FacetRestriction>();
                db.FacetRestrictions.RemoveRange(allFR);                

                var allV = db.Set<ValidationMessage>();
                db.ValidationMessages.RemoveRange(allV);

                var allU = db.Set<User>();
                db.Users.RemoveRange(allU);

                db.SaveChanges();

                SchemaService sSvc = new SchemaService(db,cache);

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
                    Email = "First1@gmail.com",
                    IsAdmin = true
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
                    Email = "First2@gmail.com",
                    IsAdmin = false
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
                    Email = "First3@gmail.com",
                    IsAdmin = false
                    });

                db.SaveChanges();

                //===========================================================================================
        }
    }
}
