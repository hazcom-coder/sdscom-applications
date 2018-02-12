using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SDSCom.Models;
using SDSCom.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace SDSCom.Pages
{
    public class AppMenuModel : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private UserService uSvc;
        private User user;

        public AppMenuModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;
            uSvc = new UserService(config, cache);            
        }

        public void OnGet()
        {  
            GetUserProfileViewData();            
        }

        public IActionResult OnPostOpenAdmin()
        {
            user = uSvc.GetByID(UserProfile_UserID);

            if (user.IsAdmin)
            {
                return RedirectToPage("Administrator/AdminIndex");
            }
            else
            {
                return Page();
            }          
        }

        public IActionResult OnPostOpenAuthor()
        {
            return RedirectToPage("Author/AuthorIndex");
        }

        public IActionResult OnPostAppAbout()
        {
            return RedirectToPage("About");
        }

        public IActionResult OnPostPagingTest()
        {
            return RedirectToPage("ComponentTest");
        }
    }
}