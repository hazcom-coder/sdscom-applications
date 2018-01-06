using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SDSCom.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }


        [BindProperty]
        public List<string> SessionVariables { get; set; }

        public void OnGet()
        {
            SessionVariables = new List<string>();

            string username = HttpContext.Session.GetString("username");
            string userid = HttpContext.Session.GetString("userid");
            string productid = HttpContext.Session.GetString("productid");

            SessionVariables.Add(username);
            SessionVariables.Add(userid);
            SessionVariables.Add(productid);

            Message = "SDSCom Application about page.";           
        }
    }
}
