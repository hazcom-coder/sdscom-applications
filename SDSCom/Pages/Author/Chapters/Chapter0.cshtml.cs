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
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private TemplateService tSvc;
        private long entityid = 0;
        private int userid = 0;

        public Chapter0Model(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;
        }


        public void OnGet()
        {   
            GetUserProfileViewData();

            userid = UserProfile_UserID;

            tSvc = new TemplateService(db, cache);
            string entityChapter = tSvc.GetEntityChapterData(UserProfile_ProductID, "InformationFromExportingSystem");
            if (entityChapter.Trim().Length > 0)
            {
                SysInfo = JsonConvert.DeserializeObject<InformationFromExportingSystem>(entityChapter);
            }
            else
            {
                SysInfo = new InformationFromExportingSystem
                {
                    RegulationsRelatedToCountryOrRegion = new List<RegulationsRelatedToCountryOrRegion>(),
                    SpecialExtensions = new List<Extension>(),
                    RelatedDocuments = new List<RelatedDocuments>()
                };
            }
        }

        [BindProperty]
        public InformationFromExportingSystem SysInfo{ get; set; }

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