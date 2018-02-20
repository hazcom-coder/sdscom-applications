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
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private UserService uSvc;

        public UserDetailModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;

            uSvc = new UserService(db, cache);
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