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
    public class ComponentListModel : PageModel
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private EntityService eService;

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

        public IActionResult OnPostCreateEntity()
        {
            TempData["newentitytype"] = EntityTypeEnum.Component;
            return RedirectToPage("CreateEntity");
        }
    }
}