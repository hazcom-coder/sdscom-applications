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

namespace SDSCom.Pages.Administrator
{
    public class UserListModel : PageModel
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private UserService uService;

        public UserListModel(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            uService = new UserService(config, cache);
        }
        public void OnGet()
        {
            Users = uService.GetAll();
        }

        [BindProperty]
        public List<User> Users { get; set; }
    }
}