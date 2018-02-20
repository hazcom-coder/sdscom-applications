using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using SDSCom.Models;
using SDSCom.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace SDSCom.Pages
{
    public class IndexModel : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private UserService uSvc;
        private User user;

        public IndexModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;
            uSvc = new UserService(db, cache);
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public User LoginUser { get; set; }

        public IActionResult OnPostAppLogin()
        {
            //TODO: implement login logic here

            //UserProfile_ProductID = 1111;
            //UserProfile_ComponentID = 2222;
            //UserProfile_UserName = "geoff";
            //UserProfile_UILanguage = "EN";
            //UserProfile_UserID = 3;

            if (uSvc.Validate(LoginUser.UserName, LoginUser.Password))
            {
                user = uSvc.GetByName(LoginUser.UserName);
                UserProfile_UserName = user.UserName;
                UserProfile_UILanguage = "EN";
                UserProfile_UserID = user.Id;

                return RedirectToPage("/AppMenu");
            }
            else
            {
                return Page();
            }
        }
    }
}
