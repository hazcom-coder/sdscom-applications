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

namespace SDSCom.Pages.Author
{   

    public class ImportModel : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private ImportService iSvc;

        public ImportModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            iSvc = new ImportService(config, cache);

        }

        public void OnGet()
        {
            GetUserProfileViewData();
        }


        public IActionResult OnPostImportDocs()
        {
            iSvc.Import("files/sdscom.xml", UserProfile_UserID);
            return RedirectToPage("AuthorIndex");
        }
    }
}