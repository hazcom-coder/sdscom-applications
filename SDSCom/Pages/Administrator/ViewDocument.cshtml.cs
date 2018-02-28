using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDSCom.Pages.Administrator
{
    public class ViewDocumentModel : BasePage
    {
        public ViewDocumentModel()
        {


        }

        public void OnGet()
        {
            var sessionDoc = new Byte[1000000];
            HttpContext.Session.TryGetValue("document", out sessionDoc);
            var str = System.Text.Encoding.Unicode.GetString(sessionDoc);
            ViewData["Document"] = str;

        }
    }
}