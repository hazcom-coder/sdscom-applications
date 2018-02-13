using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SDSCom.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace SDSCom.Pages.ViewComponenets.Grid
{
    [ViewComponent(Name ="Grid")]
    public class DefaultModel : ViewComponent
    {
        public class ComponentTestModel : ViewComponent
        {
            public PaginatedList<Entity> Entity { get; set; }
            public string NameSort { get; set; }
            public string CASSort { get; set; }
            public string CurrentFilter { get; set; }
            public string CurrentFilter2 { get; set; }
            public string CurrentSort { get; set; }

            private IMemoryCache cache;
            private readonly SDSComContext db;

            //https://github.com/aspnet/Docs/tree/master/aspnetcore/data/ef-rp/intro/samples/StageSnapShots/cu-part3-sorting
            //https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/sort-filter-page

            public ComponentTestModel(SDSComContext _db, IMemoryCache _cache)
            {
                cache = _cache;
                db = _db;
            }

            public async Task<IViewComponentResult> InvokeAsync(string sortOrder,
                              string currentFilter,
                              string searchString,
                              string currentFilter2,
                              string searchString2,
                              int? pageIndex)
            {
                var items = await GetItemsAsync(sortOrder,
                              currentFilter,
                              searchString,
                              currentFilter2,
                              searchString2,
                              pageIndex);
                return View(items);
            }


            public Task<ComponentTestModel> GetItemsAsync(string sortOrder,
                              string currentFilter,
                              string searchString,
                              string currentFilter2,
                              string searchString2,
                              int? pageIndex)
            {
                CurrentSort = sortOrder;
                NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                CASSort = String.IsNullOrEmpty(sortOrder) ? "cas_desc" : "";

                if (searchString != null)
                {
                    pageIndex = 1;
                }
                else
                {
                    searchString = currentFilter;

                    if (searchString2 != null)
                    {
                        pageIndex = 1;
                    }
                    else
                    {
                        searchString2 = currentFilter2;
                    }
                }

                CurrentFilter = searchString;
                CurrentFilter2 = searchString2;

                IQueryable<Entity> entity = from s in db.Entities
                                            where s.EntityType == 2
                                            select s;

                if (!String.IsNullOrEmpty(searchString) && !String.IsNullOrEmpty(searchString2))
                {
                    entity = entity.Where(s => s.EntityName.ToUpper().Contains(searchString.ToUpper())
                                            && s.OtherId.ToUpper().Contains(searchString2.ToUpper()));
                }
                else if (!String.IsNullOrEmpty(searchString))
                {
                    entity = entity.Where(s => s.EntityName.ToUpper().Contains(searchString.ToUpper()));
                }
                else if (!String.IsNullOrEmpty(searchString2))
                {
                    entity = entity.Where(s => s.OtherId.ToUpper().Contains(searchString2.ToUpper()));
                }
                switch (sortOrder)
                {
                    case "name_desc":
                        entity = entity.OrderByDescending(s => s.EntityName);
                        break;
                    case "cas_desc":
                        entity = entity.OrderByDescending(s => s.OtherId);
                        break;
                    default:
                        entity = entity.OrderBy(s => s.OtherId);
                        break;
                }

                int pageSize = 10;
                Entity = PaginatedList<Entity>.Create(entity.AsNoTracking(), pageIndex ?? 1, pageSize);
            }

            return Task.Run(() => ) ;
        }


    }
}