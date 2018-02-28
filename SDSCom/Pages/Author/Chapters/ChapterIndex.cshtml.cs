using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SDSCom.Models;
using SDSCom.Services;

namespace SDSCom.Pages.Author.Chapters
{
    public class ChapterIndexModel : BasePage
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        private EntityService eService;

        public ChapterIndexModel(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;
            eService = new EntityService(db, cache);
        }

        public void OnGet(long id)
        {
            Entity = eService.Get(id);

            ViewData["ProductName"] = Entity.EntityName;
            ViewData["ProductOtherId"] = Entity.OtherId;
        }


        [BindProperty]
        public Entity Entity { get; set; }

        public IActionResult OnPostOpenChapter0(long entityid)
        {
            return RedirectToPage("Chapter0", new { entityid });
        }

        public IActionResult OnPostOpenChapter1(long entityid)
        {
            return RedirectToPage("Chapter1", new { entityid });
        }

        public IActionResult OnPostOpenChapter2(long entityid)
        {
            return RedirectToPage("Chapter2", new { entityid });
        }
    }
}