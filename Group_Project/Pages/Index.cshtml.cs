using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Group_Project.Interfaces;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Group_Project.Model;

namespace Group_Project.Pages
{
    public class IndexModel : PageModel
    {
        private MusicCatalog repo;

        public List<Music> Musics { get; set; }

        public IndexModel()
        {
            repo = new MusicCatalog();        
        }

        public void OnGet()
        {
            Musics = repo.ReadMusic();
        }
    }
}