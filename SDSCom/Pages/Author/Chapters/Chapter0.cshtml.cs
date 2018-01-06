using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SDSCom.Models;

namespace SDSCom.Pages.Author.Chapters
{
    public class Chapter0Model : BasePage
    {
        public void OnGet()
        {
            SysInfo = new InformationFromExportingSystem
            {
                RegulationsRelatedToCountryOrRegion = new List<RegulationsRelatedToCountryOrRegion>(),
                SpecialExtensions = new List<Extension>(),
                RelatedDocuments = new List<RelatedDocuments>()
            };



        }

        [BindProperty]
        public InformationFromExportingSystem SysInfo { get; set; }



    }
}