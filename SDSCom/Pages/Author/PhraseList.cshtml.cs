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
    public class PhraseListModel : PageModel
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private PhraseService pService;

        public PhraseListModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            pService = new PhraseService(config, cache);
        }

        [BindProperty]
        public List<EuphracPhrase> PhraseList { get; set; }

        public void OnGet()
        {
            PhraseList = pService.Get(200);
        }
    }
}