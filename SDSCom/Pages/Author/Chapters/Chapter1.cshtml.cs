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
    public class Chapter1Model : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private TemplateService tSvc;
        private long entityid = 0;
        private int userid = 0;

        public Chapter1Model(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;
        }

        public void OnGet()
        {
            GetUserProfileViewData();

            userid = UserProfile_UserID;

            tSvc = new TemplateService(config, cache);
            string entityChapter = tSvc.GetEntityChapterData(UserProfile_ProductID, "IdentificationSubstPrep");
            if (entityChapter.Trim().Length > 0)
            {
                Ident = JsonConvert.DeserializeObject<IdentificationSubstPrep>(entityChapter);
            }
            else
            {
                Ident = new IdentificationSubstPrep
                {
                    ProductIdentity = new List<IdentificationSubstPrepProductIdentity>(),
                    EmergencyPhone = new List<EmergencyPhone>()
                    
                };
            }
        }

        [BindProperty]
        public IdentificationSubstPrep Ident { get; set; }

        [HttpPost]
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string data = JsonConvert.SerializeObject(Ident);
            tSvc.SaveEntityChapterData(entityid, "IdentificationSubstPrep", data, userid);
            return RedirectToPage("/ChapterIndex");
        }
    }
}