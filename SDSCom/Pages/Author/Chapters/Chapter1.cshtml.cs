using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using SDSCom.Models;
using SDSCom.Services;
using Newtonsoft.Json;

namespace SDSCom.Pages.Author.Chapters
{
    public class Chapter1Model : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private TemplateService tSvc;
       // private long entityid = 0;
        private int userid = 0;

        public Chapter1Model(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;
        }

        public void OnGet()
        {
            GetUserProfileViewData();

            userid = UserProfile_UserID;

            tSvc = new TemplateService(db, cache);
            string entityChapter = ""; //tSvc.GetEntityChapterData(UserProfile_ProductID, "IdentificationSubstPrep");
            if (entityChapter.Trim().Length > 0)
            {
                Ident = JsonConvert.DeserializeObject<IdentificationSubstPrep>(entityChapter);
            }
            else
            {
                Ident = new IdentificationSubstPrep
                {
                    ProductIdentity = new List<IdentificationSubstPrepProductIdentity>(),
                    EmergencyPhone = new List<EmergencyPhone>(),
                    IdentificationComments = new List<Phrase>(),
                    ItemNo = new List<string>(),
                    ProductNo = new List<ProductNo>(),
                    SupplierInformation = new List<IdentificationSubstPrepSupplierInformation>(),
                    UseOfChemicalComments = new List<Phrase>(),
                    RelevantIdentifiedUse = new IdentificationSubstPrepRelevantIdentifiedUse()
                    {                        
                        IdentifiedUse = new List<IdentificationSubstPrepRelevantIdentifiedUseIdentifiedUse>(),                                               
                        ProductFunction = new List<RelevantIdentifiedUseProductFunction>(),
                        ProductType = new List<Phrase>(),                        
                    },
                    InformationOnTheSds = new List<InformationOnTheSds>()
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
            //tSvc.SaveEntityChapterData(entityid, "IdentificationSubstPrep", data, userid);
            return RedirectToPage("/ChapterIndex");
        }
    }
}