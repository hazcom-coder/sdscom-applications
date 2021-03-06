﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SDSCom.Models;
using SDSCom.Services;

namespace SDSCom.Pages.Author
{
    public class CreateEntityModel : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private EntityService eService;

        public CreateEntityModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;
            eService = new EntityService(db, cache);
        }

        public void OnGet(long id, int type)
        {
            Entity = eService.Get(id);
            if (Entity.EntityType == 0)
            {
                Entity.EntityType = type;
            }
        }

       
        [BindProperty]
        public Entity Entity { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Entity.Id == 0)
            {
                Entity.DateStamp = DateTime.Now;
                Entity.Active = true;
                Entity.UserId = UserProfile_UserID;
                Entity.SchemaType = "SDSCOMXML";
                Entity.Status = 0;
                Entity.VersionNumber = 0;  
                Entity.Content = eService.InitDataSheet();
            }

            eService.Save(Entity);

            if (Entity.EntityType == 1)
            {
                return RedirectToPage("ProductList");
            }
            else 
            {
                return RedirectToPage("ComponentList");
            }
        }

        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Entity.Active = false;
            eService.Save(Entity);

            if (Entity.EntityType == 1)
            {
                return RedirectToPage("ProductList");
            }
            else
            {
                return RedirectToPage("ComponentList");
            }
        }
    }
}