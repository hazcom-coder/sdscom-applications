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

namespace MyApp.Namespace
{
    public class RegulationsRelatedToCountryOrRegionModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public RegulationsRelatedToCountryOrRegion RegRelated{ get; set; }

        [HttpPost]
        public IActionResult OnPostSave()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            return RedirectToPage("Chapter0");
        }

          [HttpPost]
        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            return RedirectToPage("Chapter0");
        }


    }
}