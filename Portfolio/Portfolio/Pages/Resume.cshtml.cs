using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class ResumeModel : PageModel
    {

        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            // This is to download the resume
            return File("/assets/resume.pdf", "application/pdf", "Jimmy_Chang_Resume.pdf");
        }
    }
}