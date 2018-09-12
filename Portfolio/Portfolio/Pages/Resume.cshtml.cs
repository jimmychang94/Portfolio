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
            return File("/assets/resume.pdf", "application/pdf", "Jimmy_Chang_Resume.pdf");
        }
    }
}