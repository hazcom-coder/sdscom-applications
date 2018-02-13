using SDSCom.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Mvc;

namespace SDSCom.Pages
{
    public class ProductListModel : BasePage
    {
        public PaginatedList<Entity> Entity { get; set; }
        public string NameSort { get; set; }
        public string IdSort { get; set; }
        public string CurrentFilterName { get; set; }
        public string CurrentFilterId { get; set; }
        public string CurrentSort { get; set; }

        private IMemoryCache cache;
        private readonly SDSComContext db;

        //https://github.com/aspnet/Docs/tree/master/aspnetcore/data/ef-rp/intro/samples/StageSnapShots/cu-part3-sorting
        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/sort-filter-page

        public ProductListModel(SDSComContext _db, IMemoryCache _cache)
        {
            cache = _cache;
            db = _db;
        }

        public void OnGet(string sortOrder,
                          string currentFilterName,
                          string searchStringName,
                          string currentFilterId,
                          string searchStringId,
                          int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            IdSort = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";

            if (searchStringName != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchStringName = currentFilterName;

                if (searchStringId != null)
                {
                    pageIndex = 1;
                }
                else
                {
                    searchStringId = currentFilterId;
                }
            }

            CurrentFilterName = searchStringName;
            CurrentFilterId = searchStringId;

            IQueryable<Entity> entity = from s in db.Entities
                                        where s.EntityType == 1
                                        && s.Active == true
                                        select s;

            if (!String.IsNullOrEmpty(searchStringName) && !String.IsNullOrEmpty(searchStringId))
            {
                entity = entity.Where(s => s.EntityName.ToUpper().Contains(searchStringName.ToUpper())
                                        && s.OtherId.ToUpper().Contains(searchStringId.ToUpper()));
            }
            else if (!String.IsNullOrEmpty(searchStringName))
            {
                entity = entity.Where(s => s.EntityName.ToUpper().Contains(searchStringName.ToUpper()));
            }
            else if (!String.IsNullOrEmpty(searchStringId))
            {
                entity = entity.Where(s => s.OtherId.ToUpper().Contains(searchStringId.ToUpper()));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    entity = entity.OrderByDescending(s => s.EntityName);
                    break;
                case "id_desc":
                    entity = entity.OrderByDescending(s => s.OtherId);
                    break;
                default:
                    entity = entity.OrderBy(s => s.OtherId);
                    break;
            }

            int pageSize = 10;
            Entity = PaginatedList<Entity>.Create(entity.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}