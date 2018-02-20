using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using SDSCom.Models;
using SDSCom.Services;

namespace SDSCom.Pages.Administrator
{
    public class ApplicationSettingListModel : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private ApplicationSettingsService asService;

        public ApplicationSettingListModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;

            asService = new ApplicationSettingsService(db, cache);
        }
        public void OnGet()
        {
            ApplicationSettings = asService.GetAll();
        }

        [BindProperty]
        public List<ApplicationSetting> ApplicationSettings { get; set; }

        public IActionResult OnPostEditSetting(long id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            return RedirectToPage("ApplicationSettingDetail", new { id });
        }


        public IActionResult OnPostAddNew()
        {   
            return RedirectToPage("ApplicationSettingDetail", new ApplicationSetting());
        }
    }
}