using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDSCom.Pages.Author
{
    public class AuthorIndexModel : BasePage
    {
        public void OnGet()
        {
            GetUserProfileViewData();
        }

        public IActionResult OnPostOpenProductList()
        {
            return RedirectToPage("ProductList");
        }

        public IActionResult OnPostOpenComponentList()
        {
            return RedirectToPage("ComponentList");
        }

        public IActionResult OnPostOpenCreateEntity()
        {
            return RedirectToPage("CreateEntity");
        }

        public IActionResult OnPostOpenDataSheet()
        {
            return RedirectToPage("Chapters/ChapterIndex");
        }

        public IActionResult OnPostOpenPhraseList()
        {
            return RedirectToPage("PhraseList");
        }

        public IActionResult OnPostOpenDocumentList()
        {
            return RedirectToPage("DocumentList");
        }
    }
}