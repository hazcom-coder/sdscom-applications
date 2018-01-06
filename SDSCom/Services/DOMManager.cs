using SDSComApps.SchemaLoader.Models;
using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace SDSComApps.SchemaLoader.Managers
{
    /// <summary>
    /// 
    /// </summary>
	public class DOMManager
	{
        /// <summary>
        /// 
        /// </summary>
		public DOMManager() { }

		private DOMItem GetDOMItems(DOMItem doc, XmlSchemaSequence theSequence)
		{
			DOMItem theDoc = doc;
			theDoc.SubItems = new List<DOMItem>();
			try
			{
				if (theSequence == null) return theDoc;
				foreach (var childNode in theSequence.Items)
				{
					if (childNode is XmlSchemaElement)
					{
						XmlSchemaElement nodeElement = childNode as XmlSchemaElement;
						DOMItem item = new DOMItem()
						{
							Name = nodeElement.Name,
							MaxOccurs = nodeElement.MaxOccurs,
							MinOccurs = nodeElement.MinOccurs,
							Type = nodeElement.SchemaTypeName.ToString().Replace("http://www.w3.org/2001/XMLSchema:", string.Empty).Replace("http://www.tempuri.org:", string.Empty)
						};
						if (nodeElement.ElementSchemaType is XmlSchemaComplexType)
						{
							item = GetDOMItems(item, GetSequence(nodeElement));
						}
						theDoc.SubItems.Add(item);
					}
					else if (childNode is XmlSchemaChoice)
					{
						DOMChoiceItem choice = new DOMChoiceItem()
						{
							First = "One",
							Second = "Two"
						};

						theDoc.Choice = choice;
					}
				}
			}
			catch(Exception ex)
			{
				Console.Write(ex.Message);
			}
			return theDoc;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public DOMItem LoadSchemas()
		{
			DOMItem doc = new DOMItem();
			XmlSchemaSet schemaSet = new XmlSchemaSet();

            string appdatafolder = ""; // Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data");
			
			schemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallback);
			schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXML.xsd");
			schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXMLCT.xsd");
			schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXMLDT.xsd");
			schemaSet.Compile();

			foreach (XmlSchema schema in schemaSet.Schemas())
			{
				foreach (XmlSchemaElement element in schema.Elements.Values)  //DatasheetFeed
				{
					XmlSchemaSequence theSequence = GetSequence(element);

					foreach (XmlSchemaElement datasheetElem in theSequence.Items)   //Datasheet
					{
						XmlSchemaSequence childSequence = GetSequence(datasheetElem);
						doc.SubItems = new List<DOMItem>();
						doc = GetDOMItems(doc, childSequence); //call recursivley to get full item tree
					}
				}
			}

			return doc;
		}


		private XmlSchemaSequence GetSequence(XmlSchemaElement element)
		{
			if (element.ElementSchemaType is XmlSchemaComplexType)
			{
				XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;
				return complexType.ContentTypeParticle as XmlSchemaSequence;
			}
			else
			{
				return new XmlSchemaSequence();
			}
		}

		private void ValidationCallback(object sender, ValidationEventArgs args)
		{
			if (args.Severity == XmlSeverityType.Warning)
				Console.Write("WARNING: ");
			else if (args.Severity == XmlSeverityType.Error)
				Console.Write("ERROR: ");

			Console.WriteLine(args.Message);
		}
	
	}
}