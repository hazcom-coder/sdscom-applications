using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using System.Xml;
using System.Xml.Schema;
using System.Reflection;
using Npgsql.PostgresTypes;
using Npgsql;
using System.Collections;
using Microsoft.Extensions.Caching.Memory;
using System.Data;
using System.IO;
using System.Text;
using Serilog;
using System.Xml.Serialization;

namespace SDSCom.Services
{
    public class ImportService : BaseService
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private SchemaService sSvc;
        private TemplateService tSvc;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public ImportService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            config = _config;
            cache = _cache;
            sSvc = new SchemaService(config,cache);
            tSvc = new TemplateService(config, cache);
        }

        public bool Import(string importPath, int userId)
        {
            bool ok = false;

            DataSheetFeedImport imp = new DataSheetFeedImport()
            {
                DateStamp = DateTime.Now,
                UserId = userId,
                FileName = importPath,
                FileContent = ReadFile(importPath)
            };
            
            try
            {
                imp = sSvc.Validate(imp);

                if (imp.IsValid)
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml(imp.FileContent);

                    XmlNode docRoot = xdoc.DocumentElement;

                    XmlNodeList datasheetDocs = docRoot.SelectNodes("Datasheet");

                    foreach (XmlNode datasheetDoc in datasheetDocs)
                    {
                        XmlDocument dsDoc = new XmlDocument();

                        Entity entity = new Entity()
                        {
                            Active = true,
                            DateStamp = DateTime.Now,
                            EntityType = (int) EntityTypeEnum.Product,
                            UserId = userId                            
                        };

                        dsDoc.LoadXml(datasheetDoc.OuterXml);

                        entity.OtherId = GetEntityID(dsDoc);
                        entity.EntityName = GetEntityName(dsDoc);

                        using (var db = new SDSComContext(config))
                        {
                            db.Entities.Add(entity);
                            db.SaveChanges();
                        }

                        SaveChapter(entity, dsDoc, "InformationFromExportingSystem", userId);
                    }

                    using (var db = new SDSComContext(config))
                    {
                        db.Imports.Add(imp);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Import File Name:" + importPath);
            }

            return ok;
        }


        private void SaveChapter(Entity entity, XmlDocument xDoc, string chaptername, int userId )
        {
            EntityChapter ec = new EntityChapter()
            {
                ChapterName = chaptername,
                DateStamp = DateTime.Now,
                EntityId = entity.Id,
                UserId = userId                
            };

            XmlNode node = xDoc.SelectSingleNode("/Datasheet/InformationFromExportingSystem");

            if (node != null)
            {
                ec.Data = node.InnerXml;
            }
            else
            {
                ec.Data = "CHAPTER NOT FOUND";
            }

            using (var db = new SDSComContext(config))
            {
                db.EntityChapters.Add(ec);
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Prefer ProductGTIN number, then ProductNoUser, then ItemNo, then 'UNKNOWN'
        /// </summary>
        /// <param name="dsDoc"></param>
        /// <returns></returns>
        private string GetEntityID(XmlDocument dsDoc)
        {
            string otherId = string.Empty;

            XmlNode node = dsDoc.SelectSingleNode("/Datasheet/IdentificationSubstPrep/ProductIdentity/ProductGtin/No");
            if  (node != null)
            {
                otherId = node.InnerText;
            }
            if (otherId.Trim().Length == 0)
            {
                node = dsDoc.SelectSingleNode("/Datasheet/IdentificationSubstPrep/ProductNo/ProductNoUser");
                if (node != null)
                {
                    otherId = node.InnerText;
                }
                if (otherId.Trim().Length == 0)
                {
                    node = dsDoc.SelectSingleNode("DatasheetFeed/Datasheet/IdentificationSubstPrep/ItemNo");
                    if (node != null)
                    {
                        otherId = node.InnerText;
                    }
                    if (otherId.Trim().Length == 0)
                    {
                        otherId = "UNKNOWN";
                    }
                }
            }

            return otherId;
        }

        /// <summary>
        /// Prefer ProductGtin/Name, then TradeName, then Synonym, then 'UNKNOWN'
        /// </summary>
        /// <param name="dsDoc"></param>
        /// <returns></returns>
        private string GetEntityName(XmlDocument dsDoc)
        {
            string entityName = string.Empty;

            XmlNode node = dsDoc.SelectSingleNode("/Datasheet/IdentificationSubstPrep/ProductIdentity/ProductGtin/Name");
            if (node != null)
            {
                entityName = node.InnerText;
            }
            if (entityName.Trim().Length == 0)
            {
                node = dsDoc.SelectSingleNode("/Datasheet/IdentificationSubstPrep/ProductIdentity/TradeName");
                if (node != null)
                {
                    entityName = node.InnerText;
                }
                if (entityName.Trim().Length == 0)
                {
                    node = dsDoc.SelectSingleNode("/Datasheet/IdentificationSubstPrep/ProductIdentity/Synonym");
                    if (node != null)
                    {
                        entityName = node.InnerText;
                    }
                    if (entityName.Trim().Length == 0)
                    {
                        entityName = "UNKNOWN";
                    }
                }
            }

            return entityName;
        }
       
    }
}
