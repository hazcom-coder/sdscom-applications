using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;

namespace SDSCom.Pages
{
    public class IndexModel : BasePage
    {

        public void OnGet()
        {

        }

        public IActionResult OnPostAppLogin()
        {
            //TODO: implement login logic here

            UserProfile_ProductID = 1111;
            UserProfile_ComponentID = 2222;
            UserProfile_UserName = "geoff";
            UserProfile_UILanguage = "EN";
            UserProfile_UserID = 3;

            return  RedirectToPage("/AppMenu");
        }
    }
}
