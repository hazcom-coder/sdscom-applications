﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using SDSCom.Services;

namespace SDSCom.Pages.Administrator
{
    public class ApplicationSettingDetailModel : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private ApplicationSettingsService aSvc;

        public ApplicationSettingDetailModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;
            aSvc = new ApplicationSettingsService(db, cache);
        }

        public IActionResult OnGet(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationSetting = aSvc.Get(id.GetValueOrDefault());

            return Page();
        }

        [BindProperty]
        public ApplicationSetting ApplicationSetting { get; set; }

        public IActionResult OnPost()
        {
            return Page();
        }       

        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            aSvc.Delete(ApplicationSetting);

            return RedirectToPage("ApplicationSettingList");
        }

        public IActionResult OnPostSave()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            aSvc.Save(ApplicationSetting);

            return RedirectToPage("ApplicationSettingList");
        }
    }
}