using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using SDSCom.Services;

namespace SDSCom.Pages.Administrator
{
    public class ApplicationSettingListModel : PageModel
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private ApplicationSettingsService asService;


        public ApplicationSettingListModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            asService = new ApplicationSettingsService(config, cache);
        }
        public void OnGet()
        {
            ApplicationSettings = asService.GetAll();
        }

        [BindProperty]
        public List<ApplicationSetting> ApplicationSettings { get; set; }



    }
}