using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections;
using System.Data;
using ServiceStack.OrmLite.PostgreSQL;
using ServiceStack.OrmLite;
using SDSCom.Models;


namespace SDSCom.Services
{

    /// <summary>
    /// 
    /// </summary>
	public class SchemaService
    {
        private string appdatafolder = @"schemas";
        private int facetid = 1;

        private string versionNumer = "4.2.3";

        /// <summary>
        /// 
        /// </summary>
        public SchemaService()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Facet> GetSchemas()
        {
            List<Facet> facetList = new List<Facet>();
            string schemaFileName = "SDSComXML.xsd";

            XmlTextReader textReader = new XmlTextReader(appdatafolder + "/" + schemaFileName);

            XmlDocument xdcc = new XmlDocument();

            xdcc.Load(textReader);

            XmlNode root = xdcc.DocumentElement;
            List<string> nodeNames = new List<string>();

            XmlNode datasheetNode;
            XmlNode chapterNode;

            foreach (XmlNode node in root.ChildNodes)
            {
                nodeNames.Add(node.Name);

                if (node.Name == "xs:element")
                {
                    datasheetNode = node.ChildNodes[1].ChildNodes[0].ChildNodes[1];

                    Facet facet = BuildFacet(0, "", "DataSheet", "1", "1", schemaFileName, "root", -1);
                    facetList.Add(facet);

                    for (int x = 1; x <= datasheetNode.ChildNodes[1].ChildNodes[0].ChildNodes.Count - 1; x++)
                    {
                        chapterNode = datasheetNode.ChildNodes[1].ChildNodes[0].ChildNodes[x];

                        AddElementAsFacet(chapterNode, "datasheet", schemaFileName, facetList);

                        BuildChapter(chapterNode, "datasheet", schemaFileName, facetList);
                    }
                    break;
                }
            }

            //update parent ids
            foreach (Facet facet in facetList)
            {
                facetList.Where(w => w.ParentPath == facet.Name).ToList()
                    .ForEach(f => f.ParentId = facet.Id);
            }

            facetList.Where(w => w.ParentId == 0).ToList().ForEach(f => f.ParentId = 1);

            return facetList;
        }

        private string AddElementAsFacet(XmlNode theNode, string parentName, string schemafileName, List<Facet> facetList)
        {
            string minOccurs = "0";
            string maxOccurs = "0";
            string facetName = string.Empty;
            string dataType = string.Empty;
            string retValue = parentName;
            int maxSize = -1;

            if (theNode.Attributes != null)
            {

                if (theNode.Attributes["name"] != null)
                {
                    facetName = theNode.Attributes["name"].Value;
                }

                if (theNode.Attributes["minOccurs"] != null)
                {
                    minOccurs = theNode.Attributes["minOccurs"].Value;
                }

                if (theNode.Attributes["maxOccurs"] != null)
                {
                    maxOccurs = theNode.Attributes["maxOccurs"].Value;
                }

                if (theNode.Attributes["type"] != null)
                {
                    string tmpType = theNode.Attributes["type"].Value;

                    if (tmpType.StartsWith("xs:"))
                    {
                        tmpType = tmpType.Replace("xs:", string.Empty);
                    }

                    dataType = tmpType;

                    if (dataType.ToLower().Contains("string"))
                    {
                        string tmpSize = dataType.Replace("string", string.Empty);
                        bool ok = int.TryParse(tmpSize, out maxSize);
                    }

                    if (dataType.ToLower().Contains("int"))
                    {
                        string tmpSize = dataType.Replace("int", string.Empty);
                        bool ok = int.TryParse(tmpSize, out maxSize);
                    }
                }

                Facet facet = BuildFacet(0, parentName, facetName, minOccurs, maxOccurs, schemafileName, dataType, maxSize);
                facetList.Add(facet);
                retValue = facetName;
            }

            return retValue;
        }

        private void BuildChapter(XmlNode chapterNode, string facetName, string schemafileName, List<Facet> facetList)
        {
            XmlNode nextNode = RecurseChildNodes(chapterNode, facetName, schemafileName, facetList);
        }

        private XmlNode RecurseChildNodes(XmlNode theNode, string parentName, string schemafileName, List<Facet> facetList)
        {
            XmlNode node = null;

            if (theNode.Name == "xs:element")
            {
                if (theNode.Attributes["name"] != null)
                {
                    parentName = theNode.Attributes["name"].Value;
                }
            }

            foreach (XmlNode childNode in theNode.ChildNodes)
            {
                if (childNode.Name == "xs:element")
                {
                    AddElementAsFacet(childNode, parentName, schemafileName, facetList);
                }

                RecurseChildNodes(childNode, parentName, schemafileName, facetList);
            }

            return node;
        }

        private Facet BuildFacet(int parentid, string parentPath,
                            string facetName, string minOccurs, string maxOccurs,
                            string fileName, string dataType, int maxSize)
        {
            Facet facet = new Facet
            {
                DateStamp = DateTime.Now,
                Id = facetid,
                MaxOccurs = maxOccurs,
                MinOccurs = minOccurs,
                Name = facetName,
                ParentId = parentid,
                ParentPath = parentPath,
                SchemaFileName = fileName,
                SDSComVersion = versionNumer,
                DataType = dataType,
                MaxSize = maxSize
            };
            facetid++;

            return facet;
        }


        public List<FacetRestriction> GetDataTypes(List<Facet> facetList, string fileName)
        {
            List<FacetRestriction> restrictions = new List<FacetRestriction>();

            XmlTextReader textReader = new XmlTextReader(appdatafolder + "/" + fileName);

            XmlDocument xdcc = new XmlDocument();

            xdcc.Load(textReader);

            XmlNode root = xdcc.DocumentElement;
            List<string> nodeNames = new List<string>();

            foreach (XmlNode node in root.ChildNodes)
            {
                nodeNames.Add(node.Name);

                if (node.Attributes != null)
                {
                    if (node.Attributes["name"] != null)
                    {
                        string enumName = node.Attributes["name"].Value;
                        Facet facet = facetList.Where(c => c.DataType == enumName).FirstOrDefault();
                        string facetDescription = string.Empty;

                        if (node.ChildNodes[0] != null)
                        {
                            facetDescription = node.ChildNodes[0].InnerText;
                        }

                        if (facet != null)
                        {
                            if (!enumName.StartsWith("string") && !enumName.StartsWith("int") && !(enumName == "Phrase"))
                            {
                                FacetRestriction restr = new FacetRestriction
                                {
                                    Id = 0, //will be done later
                                    FacetId = facet.Id
                                };

                                string facetName = facet.Name;
                                string facetDataType = facet.DataType;

                                restr.Name = facetDataType;

                                if (node.ChildNodes[1].ChildNodes[0].Name == "xs:enumeration")
                                {
                                    restr.IsList = true;

                                    foreach (XmlNode enumValueNode in node.ChildNodes[1].ChildNodes)
                                    {
                                        if (enumValueNode.Attributes != null)
                                        {
                                            string enumValue = enumValueNode.Attributes[0].Value;
                                            restr.Enumerations.Add(enumValue);
                                        }
                                    }
                                }
                                else if (node.ChildNodes[1].ChildNodes[0].Name == "xs:pattern")
                                {
                                    restr.IsList = false;
                                    string patternValue = node.ChildNodes[1].ChildNodes[0].Attributes[0].Value;
                                    restr.RegularExpressionPattern = patternValue;
                                }
                                restrictions.Add(restr);
                            }
                        }
                    }
                }
            }
            return restrictions;
        }

        public List<Facet> GetExtensions()
        {
            List<Facet> facetList = new List<Facet>();
            string schemafileName = "SDSComXMLNE_DE.xsd";
            XmlTextReader textReader = new XmlTextReader(url: appdatafolder + "/" + schemafileName);

            XmlDocument xdcc = new XmlDocument();

            xdcc.Load(textReader);

            XmlNode root = xdcc.DocumentElement;
            List<string> nodeNames = new List<string>();

            foreach (XmlNode node in root.ChildNodes)
            {
                RecurseChildNodes(node, node.Name, schemafileName, facetList);
            }
            return facetList;
        }


        private string connstring = @"Server=sdscom.c5o9b1nqgmsb.us-east-1.rds.amazonaws.com;
										Port=5432;Database=sdscom;
										User Id=sdscom;Password=Gollum17;";       

        public void CreateFacets(List<Facet> facetList)
        {
            var dbFactory = new OrmLiteConnectionFactory(connstring, PostgreSqlDialect.Provider);

            using (IDbConnection db = dbFactory.Open())
            {
                db.InsertAll(facetList);
            }
        }

        public void CreateFacetRestrictionss(List<FacetRestriction> facetRestList)
        {
            var dbFactory = new OrmLiteConnectionFactory(connstring, PostgreSqlDialect.Provider);

            using (IDbConnection db = dbFactory.Open())
            {
                db.InsertAll(facetRestList);
            }
        }
    }
}
