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
            using (IDbConnection db = DbFactory.Open())
            {
                db.DropTable<Entity>();
                db.CreateTable<Entity>();                              

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

                db.DropTable<EntityType>();
                db.CreateTable<EntityType>();

                db.Save(new EntityType { EntityTypeName = "Product" });
                db.Save(new EntityType { EntityTypeName = "Component" });
                db.Save(new EntityType { EntityTypeName = "Company" });

                //===========================================================================================

                db.DropTable<ApplicationSetting>();
                db.CreateTable<ApplicationSetting>();

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

                db.DropTable<User>();
                db.CreateTable<User>();

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


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public bool MapElements()
        //{
        //    XmlSchemaSet schemaSet = docMgr.GetSchemas();

        //    XmlSchema sdsSchema = null;
        //    foreach (XmlSchema schema in schemaSet.Schemas())
        //    {
        //        sdsSchema = schema;
        //    }

        ////Datasheet theSheet = new Datasheet();

        ////    PrintAllTypes(typeof(Datasheet), "");

        //    return true;
        //}


        //private void RecurseElements(XmlSchema sdsSchema, XmlSchemaElement element2)
        //{
        //    foreach (XmlSchemaElement element in sdsSchema.Elements.Values)
        //    {
        //        Console.WriteLine("Element: {0}", element.Name);

        //        XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;

        //        if (complexType.AttributeUses.Count > 0)
        //        {
        //            IDictionaryEnumerator enumerator = complexType.AttributeUses.GetEnumerator();
        //            while (enumerator.MoveNext())
        //            {
        //                XmlSchemaAttribute attribute = (XmlSchemaAttribute)enumerator.Value;

        //                Console.WriteLine("Attribute: {0}", attribute.Name);
        //            }
        //        }

        //        XmlSchemaSequence sequence = complexType.ContentTypeParticle as XmlSchemaSequence;

        //        foreach (XmlSchemaElement childElement in sequence.Items)
        //        {
        //            Console.WriteLine("Element: {0} {1} {2} {3}", childElement.Name, childElement.Parent.ToString(), childElement.MinOccurs, childElement.MaxOccurs);
                    
        //        }
        //    }
        //}


        //private List<Type> alreadyVisitedTypes = new List<Type>(); // to avoid infinite recursion

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="currentType"></param>
        ///// <param name="prefix"></param>
        //public void PrintAllTypes(Type currentType, string prefix)
        //{
        //    //if (alreadyVisitedTypes.Contains(currentType)) return;
        //    //alreadyVisitedTypes.Add(currentType);
        //    //foreach (PropertyInfo pi in currentType.GetProperties())
        //    //{
        //    //    NpgsqlCommand cmd = new NpgsqlCommand();
        //    //    cmd.CommandText = @"INSERT INTO ATTRIBUTES (
        //    //                        ATTRIBUTE_NAME, ATTRIBUTE_TYPE, DATE_STAMP, USER_ID, MINOCCURS,MAXOCCURS)
        //    //                        VALUES ('" + pi.Name + "','" + pi.PropertyType.Name + "', now(),1,'0','0')  ";
        //    //    dataMgr.Execute(cmd);
        //    //   // Console.WriteLine($"{prefix} {pi.PropertyType.Name} {pi.Name}");
        //    //    if (!pi.PropertyType.IsPrimitive) PrintAllTypes(pi.PropertyType, prefix + "  ");
        //    //}


        //}
    }
}
