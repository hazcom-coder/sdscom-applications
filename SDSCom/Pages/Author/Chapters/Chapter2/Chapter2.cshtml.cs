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
    public class Chapter2Model : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private TemplateService tSvc;
       // private long entityid = 0;
        private int userid = 0;

        public void OnGet()
        {
            GetUserProfileViewData();
            
            userid = UserProfile_UserID;

            tSvc = new TemplateService(db, cache);
            string entityChapter = tSvc.GetEntityChapterContent(UserProfile_ProductID, "HazardIdentification");
            if (entityChapter.Trim().Length > 0)
            {
                HazIdent = JsonConvert.DeserializeObject<HazardIdentification>(entityChapter);

            }
            else
            {
                HazIdent = new HazardIdentification
                {
                    Classification = new Classification()
                    {
                        ClpClassification = new ClpClassification(),
                        DpdDsdClassification = new ClassificationDpdDsdClassification(),
                        SimpleClassificationDescription = new List<Phrase>(),
                        ClassificationAdditionalInformation = new List<Phrase>()                        
                    },
                    HazardLabelling = new HazardIdentificationHazardLabelling()
                    {
                        ClpLabellingInfo = new ClpLabellingInfo(),
                        DpdDsdHazardLabelling = new DpdDsdHazardLabelling(),
                        AdditionalInformation = new List<Phrase>(),
                        LabellingAccordingToOtherEuLegislation = new LabellingAccordingToOtherEuLegislation()
                        {
                            VocLabelling = new List<LabellingAccordingToOtherEuLegislationVocLabelling>()
                        }
                    },
                    OtherHazardsInfo = new OtherHazardsInfo() 
                    {
                        EnvironmentalEffect = new List<Phrase>(),
                        EffectsOfMisuse = new List<Phrase>(),
                        HazardDescriptionGeneral = new List<Phrase>(),
                        HealthEffect = new List<Phrase>(),
                        OtherHazards = new List<Phrase>(),
                        PhysicochemicalEffect = new List<Phrase>()
                    }                  
                };
            }   
        }
        
         [BindProperty]
        public HazardIdentification HazIdent { get; set; }

        public void OnPost()
        {

        }
    }
}