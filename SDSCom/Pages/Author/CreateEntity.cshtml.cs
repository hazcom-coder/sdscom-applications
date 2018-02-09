using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SDSCom.Models;
using SDSCom.Services;

namespace SDSCom.Pages.Author
{
    public class CreateEntityModel : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private EntityService eService;

        public CreateEntityModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;
            eService = new EntityService(config, cache);
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

            eService.Save(Entity);

            return RedirectToPage("AuthorIndex");
        }
    }
}