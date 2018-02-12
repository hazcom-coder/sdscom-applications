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

namespace SDSCom.Pages.Author
{
    public class ComponentListModel : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private EntityService eService;
        private int entityType = 2;

        public ComponentListModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            eService = new EntityService(config, cache);
        }



        [BindProperty]
        public List<Entity> EntityList { get; set; }

        public void OnGet()
        {
            EntityList = eService.GetByType(EntityTypeEnum.Component);
        }

        public IActionResult OnPostAddNew()
        {
            return RedirectToPage("CreateEntity", new { id = 0, type = entityType });
        }

        public IActionResult OnPostEdit(int id)
        {
            return RedirectToPage("CreateEntity", new { id, type = entityType });
        }
    }
}