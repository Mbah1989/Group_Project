using Group_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 


namespace Group_Project.Interfaces
{
    public interface IMusicRepository
    {
         List<Music> ReadMusic();
        void CreateMusic(Music music);
        
        void UpdateMusic(Music music);
        void DeleteMusic(Music music);
    }
}
