﻿using System;
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
    public class UserListModel : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private UserService uService;

        public UserListModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;

            uService = new UserService(db, cache);
        }

        public void OnGet()
        {
            Users = uService.GetAll();
        }

        [BindProperty]
        public List<User> Users { get; set; }

        public IActionResult OnPostAddNew()
        {
            return RedirectToPage("UserDetail",new User());
        }

        public IActionResult OnPostEditUser(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("UserDetail", new { id });
        }
    }
}