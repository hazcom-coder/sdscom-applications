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
    public class DocumentListModel : BasePage
    {
        private IMemoryCache cache;
        private readonly SDSComContext db;
        private DocumentService dSvc;

        public PaginatedList<Document> Documents { get; set; }
        public string CurrentFilterLanguage { get; set; }
        public string CurrentFilterEntity { get; set; }
        public string CurrentSort { get; set; }
        public string LanguageSort { get; set; }
        public string EntitySort { get; set; }

        public DocumentListModel(SDSComContext _db, IMemoryCache _cache)
        {
            cache = _cache;
            db = _db;
            dSvc = new DocumentService(db, cache);
        }   

        public void OnGet(string sortOrder,
                          string currentFilterLanguage,
                          string searchStringLanguage,
                          string currentFilterEntity,
                          string searchStringEntity,
                          int? pageIndex)
        {
            CurrentSort = sortOrder;
            LanguageSort = String.IsNullOrEmpty(sortOrder) ? "language_desc" : "";
            EntitySort = String.IsNullOrEmpty(sortOrder) ? "entity_desc" : "";

            if (searchStringLanguage != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchStringLanguage = currentFilterLanguage;

                if (searchStringEntity != null)
                {
                    pageIndex = 1;
                }
                else
                {
                    searchStringEntity = currentFilterEntity;
                }
            }

            CurrentFilterLanguage = searchStringLanguage;
            CurrentFilterEntity = searchStringEntity;

            IQueryable<Document> doc = from s in db.Documents
                                        where s.Active == true
                                        select s;

            if (!String.IsNullOrEmpty(searchStringLanguage) && !String.IsNullOrEmpty(searchStringEntity))
            {
                doc = doc.Where(s => s.Language.ToUpper().Contains(searchStringLanguage.ToUpper()));
            }
            else if (!String.IsNullOrEmpty(searchStringLanguage))
            {
                doc = doc.Where(s => s.Language.ToUpper().Contains(searchStringLanguage.ToUpper()));
            }
            else if (!String.IsNullOrEmpty(searchStringEntity))
            {
                doc = doc.Where(s => s.EntityName.Contains(searchStringEntity.ToUpper()));
            }
            switch (sortOrder)
            {
                case "langauge_desc":
                    doc = doc.OrderByDescending(s => s.EntityName);
                    break;
                case "entity_desc":
                    doc = doc.OrderByDescending(s => s.EntityName);
                    break;
                default:
                    doc = doc.OrderBy(s => s.EntityID);
                    break;
            }

            int pageSize = 10;
            Documents = PaginatedList<Document>.Create(doc, pageIndex ?? 1, pageSize);
        }
    }
}