using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDSCom.Pages
{
    public class AppMenuModel : BasePage
    {        
        public void OnGet()
        {
            GetUserProfileViewData();
        }



        public IActionResult OnPostOpenAdmin()
        {
           return  RedirectToPage("Administrator/AdminIndex");
        }

        public IActionResult OnPostOpenAuthor()
        {
            return RedirectToPage("Author/AuthorIndex");
        }

        public IActionResult OnPostAppAbout()
        {
            return RedirectToPage("About");
        }
    }
}