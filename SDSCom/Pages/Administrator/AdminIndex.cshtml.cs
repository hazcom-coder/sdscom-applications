using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SDSCom.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml;
using System.IO;

namespace SDSCom.Pages.Administrator
{
    public class AdminIndexModel : BasePage
    {
        private AdminService aSvc;
        private readonly SDSComContext db;

        public AdminIndexModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            aSvc = new AdminService(db, _cache);
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
            xslt.Load("files/basic.xsl");

            StringWriter writer = new StringWriter();
            xslt.Transform("files/sdscom.xml", null, writer);
            theHTML = writer.ToString();
            writer.Close();

            var result = System.Text.Encoding.Unicode.GetBytes(theHTML);
            HttpContext.Session.Set("document",result );

            return RedirectToPage("ViewDocument");
        }
    }
}