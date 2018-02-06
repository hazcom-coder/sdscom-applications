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
    public class UserDetailModel : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private UserService uSvc;

        public UserDetailModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            uSvc = new UserService(config, cache);
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SelectedUser = uSvc.GetByID(id.GetValueOrDefault());

            return Page();
        }


        [BindProperty]
        public User SelectedUser { get; set; }

        public IActionResult OnPostDelete()
        {           
            if (!ModelState.IsValid)
            {
                return Page();
            }

            uSvc.Delete(SelectedUser);

            return RedirectToPage("UserList");
        }


        public IActionResult OnPostSave()
        {  

            if (!ModelState.IsValid)
            {
                return Page();
            }

            uSvc.Save(SelectedUser);

            return RedirectToPage("UserList");
        }
    }
}