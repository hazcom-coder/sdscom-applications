using System;
using Microsoft.AspNetCore.Mvc;
using SDSCom.Services;
using Microsoft.Extensions.Caching.Memory;
using System.Xml.Xsl;
using SDSCom.Models;
using System.IO;

namespace SDSCom.Pages.Administrator
{
    public class AdminIndexModel : BasePage
    {
        private AdminService aSvc;
        private readonly SDSComContext db;
        private DocumentService dSvc;

        public AdminIndexModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            aSvc = new AdminService(db, _cache);
            dSvc = new DocumentService(db, _cache);
        }
        public void OnGet()
        {

        }

        public IActionResult OnPostOpenApplicationSettings()
        {
            return RedirectToPage("ApplicationSettingList");
        }

        public IActionResult OnPostOpenUsers()
        {
            return RedirectToPage("UserList");
        }

        public IActionResult OnPostSelectProduct()
        {
            TempData["selectproductcaller"] = "/AppMenu";
            return RedirectToPage("/Author/SelectProduct");
        }

        public IActionResult OnPostSelectComponent()
        {
            TempData["selectcomponentcaller"] = "/AppMenu";
            return RedirectToPage("/Author/SelectComponent");
        }

        public void OnPostCreateDBObjects()
        {
            aSvc.CreateDBObjects();
        }

        public void OnPostLoadComponents()
        {

            aSvc.LoadComponents();
        }

        public IActionResult OnPostTransform()
        {            
            string theHTML = string.Empty;

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("files/middle.xsl");

            StringWriter writer = new StringWriter();
            xslt.Transform("files/sdscom.xml", null, writer);
            theHTML = writer.ToString();
            writer.Close();

            var result = System.Text.Encoding.Unicode.GetBytes(theHTML);
            HttpContext.Session.Set("document",result );

            string str = Guid.NewGuid().ToString();

            Document document = new Document
            {
                Language = "EN",
                EntityName = $"Test Product {str}" ,
                EntityID = str,
                Active = true,
                Content = theHTML,
                CreatedDate = DateTime.Now,
                CreatedUser = 1,
                Source = "test",
                Status = 1
            };

            document = dSvc.Save(document);

            return RedirectToPage("/Author/ViewDocument", new { document.Id});
        }
    }
}