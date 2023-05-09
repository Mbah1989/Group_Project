using Group_Project.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Group_Project.Pages
{
    public class CreateMusicModel : PageModel
    {
        private MusicCatalog repo;

        [BindProperty]

        public Music Music { get; set; }

        public CreateMusicModel()
        {
            repo = new MusicCatalog();
        }
        public IActionResult OnGet() 
        {
           return Page();
        }

        public IActionResult OnPost()
        { 
            repo.CreateMusic(Music);
            return RedirectToPage("Index");
        }
    }
}
