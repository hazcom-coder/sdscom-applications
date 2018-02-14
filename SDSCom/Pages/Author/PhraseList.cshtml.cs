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
    public class PhraseListModel : BasePage
    {
        public PaginatedList<EuphracPhrase> Phrase { get; set; }
        public string PhraseSort { get; set; }
        public string CodeSort { get; set; }
        public string CurrentFilterPhrase { get; set; }
        public string CurrentFilterCode { get; set; }
        public string CurrentSort { get; set; }

        private IMemoryCache cache;
        private readonly SDSComContext db;

        public PhraseListModel(SDSComContext _db, IMemoryCache _cache)
        {
            cache = _cache;
            db = _db;
        }

        public void OnGet(string sortOrder,
                          string currentFilterPhrase,
                          string searchStringPhrase,
                          string currentFilterCode,
                          string searchStringCode,
                          int? pageIndex)
        {
            CurrentSort = sortOrder;
            PhraseSort = String.IsNullOrEmpty(sortOrder) ? "phrase_desc" : "";
            CodeSort = String.IsNullOrEmpty(sortOrder) ? "code_desc" : "";

            if (searchStringPhrase != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchStringPhrase = currentFilterPhrase;

                if (searchStringCode != null)
                {
                    pageIndex = 1;
                }
                else
                {
                    searchStringCode = currentFilterCode;
                }
            }

            CurrentFilterPhrase = searchStringPhrase;
            CurrentFilterCode = searchStringCode;

            IQueryable<EuphracPhrase> phrase = from s in db.Phrases                                        
                                        select s;

            if (!String.IsNullOrEmpty(searchStringPhrase) && !String.IsNullOrEmpty(searchStringCode))
            {
                phrase = phrase.Where(s => s.English.ToUpper().Contains(searchStringPhrase.ToUpper())
                                        && s.EuPhraCStructureCode.Contains(searchStringCode));
            }
            else if (!String.IsNullOrEmpty(searchStringPhrase))
            {
                phrase = phrase.Where(s => s.English.ToUpper().Contains(searchStringPhrase.ToUpper()));
            }
            else if (!String.IsNullOrEmpty(searchStringCode))
            {
                phrase = phrase.Where(s => s.EuPhraCStructureCode.Contains(searchStringCode));
            }
            switch (sortOrder)
            {
                case "phrase_desc":
                    phrase = phrase.OrderByDescending(s => s.English);
                    break;
                case "code_desc":
                    phrase = phrase.OrderByDescending(s => s.EuPhraCStructureCode);
                    break;
                default:
                    phrase = phrase.OrderBy(s => s.EuPhraCStructureCode);
                    break;
            }

            int pageSize = 10;
            Phrase = PaginatedList<EuphracPhrase>.Create(phrase.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}