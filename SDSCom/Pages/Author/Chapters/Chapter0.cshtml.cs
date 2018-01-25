using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using SDSCom.Services;
using Newtonsoft.Json;

namespace SDSCom.Pages.Author.Chapters
{
    public class Chapter0Model : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private TemplateService tSvc;
        private long entityid = 0;
        private int userid = 0;

        public Chapter0Model(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;
            entityid = UserProfile_ProductID;
            userid = UserProfile_UserID;
        }


        public void OnGet()
        {
            SysInfo = new InformationFromExportingSystem
            {
                RegulationsRelatedToCountryOrRegion = new List<RegulationsRelatedToCountryOrRegion>(),
                SpecialExtensions = new List<Extension>(),
                RelatedDocuments = new List<RelatedDocuments>()                
            };

            tSvc = new TemplateService(config, cache);
            string entityChapter = tSvc.GetEntityChapterData(entityid, "InformationFromExportingSystem");
            
            SysInfo = JsonConvert.DeserializeObject<InformationFromExportingSystem>(entityChapter);
        }

        [BindProperty]
        public InformationFromExportingSystem SysInfo { get; set; }

        [HttpPost]
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string data = JsonConvert.SerializeObject(SysInfo);
            tSvc.SaveEntityChapterData(entityid, "InformationFromExportingSystem", data, userid);
            return RedirectToPage("/ChapterIndex");
        }
    }
}