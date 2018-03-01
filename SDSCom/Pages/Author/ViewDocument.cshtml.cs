using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using SDSCom.Models;

namespace SDSCom.Pages.Author
{
    public class ViewDocumentModel : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;

        public ViewDocumentModel(SDSComContext _db, IMemoryCache _cache)
        {
            cache = _cache;
            db = _db;
        }

       
        public void OnGet(long id)
        {           
            Document doc = db.Documents.Find(id);
            string header = $@"<h3>Product Name: {doc.EntityName} <br/> ID: {doc.EntityID}</h3><br/>";
            ViewData["Document"] = header + doc.Content;
        }

        public string TransformDOcument()
        {
            string theHTML = string.Empty;
            var xDocType = new XDocumentType("html", null, null, null);
            var xDocument = new XDocument(xDocType);
            var xElem = new XElement("html");
            xDocument.Add(xElem);

            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Indent = true,
                IndentChars = "\t"
            };

            using (var writer = XmlWriter.Create(@"C:\Users\wolf\Desktop\test.html", settings))
            {
                xDocument.WriteTo(writer);
            }

            using (var ms = new MemoryStream())
            {
                using (var docMS = new XmlTextWriter(ms, new UTF8Encoding(false))
                { Formatting = Formatting.Indented })
                {
                    xDocument.WriteTo(docMS);
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

    }
}