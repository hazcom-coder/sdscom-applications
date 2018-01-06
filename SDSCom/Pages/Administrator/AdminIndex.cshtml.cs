using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDSCom.Pages.Administrator
{
    public class AdminIndexModel : PageModel
    {
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
    }
}