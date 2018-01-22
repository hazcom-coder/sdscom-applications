using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SDSCom.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace SDSCom.Pages.Administrator
{
    public class AdminIndexModel : PageModel
    {
       // private readonly IConfiguration config;
       // private IMemoryCache cache;
        private AdminService aSvc;

        public AdminIndexModel(IConfiguration _config, IMemoryCache _cache)
        {
            aSvc = new AdminService(_config, _cache);
        }
        public void OnGet()
        {

        }

        public IActionResult OnPostOpenApplicationSettings()
        {
            return RedirectToPage("ApplicationSettingList");
        }

        public IActionResult OnPostOpenUsers()
        {
            return RedirectToPage("UserList");
        }

        public IActionResult OnPostSelectProduct()
        {
            TempData["selectproductcaller"] = "/AppMenu";
            return RedirectToPage("/Author/SelectProduct");
        }

        public IActionResult OnPostSelectComponent()
        {
            TempData["selectcomponentcaller"] = "/AppMenu";
            return RedirectToPage("/Author/SelectComponent");
        }

        public void OnPostCreateDBObjects()
        {
            aSvc.CreateDBObjects();
        }
    }
}