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
    public class PhraseDetailModel : BasePage
    {
        private IMemoryCache cache;
        private readonly SDSComContext db;

        public PhraseDetailModel(SDSComContext _db, IMemoryCache _cache)
        {
            cache = _cache;
            db = _db;
        }

        public void OnGet(string id)
        {
            Phrase = db.Phrases.Find(id);
        }


        [BindProperty]
        public EuphracPhrase Phrase { get; set; }

        public IActionResult OnPost()
        {  
            return RedirectToPage("PhraseList");           
        }      
    }
}