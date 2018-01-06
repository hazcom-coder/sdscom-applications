using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDSCom.Pages.Author.Chapters
{
    public class ChapterIndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPostOpenChapter0()
        {
            return RedirectToPage("Chapter0");
        }

        public IActionResult OnPostOpenChapter1()
        {
            return RedirectToPage("Chapter1");
        }

        public IActionResult OnPostOpenChapter2()
        {
            return RedirectToPage("Chapter2");
        }
    }
}