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
    public class SelectProductModel : BasePage
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private EntityService eService;

        public SelectProductModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            eService = new EntityService(config, cache);
        }

        [BindProperty]
        public List<Entity> EntityList { get; set; }

        public void OnGet()
        {
            EntityList = eService.GetByType(EntityTypeEnum.Product);
        }

        public IActionResult OnPostSelect(long id, string source)
        {
            UserProfile_ProductID = id;

            return RedirectToPage(source);

        }
    }
}