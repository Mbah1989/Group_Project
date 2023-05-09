using Group_Project.Interfaces;

namespace Group_Project.Model
{
    public class MusicCatalog: IMusicRepository
    {
        private List<Music> musics;

        public MusicCatalog()
        {
                musics= new List<Music>();
            musics.Add(new Music() { Genre = "POP", Name = "Justin Bieber", Year = 2010 });
            musics.Add(new Music() { Genre = "Rock", Name = "Gasoline", Year = 1969 });
            musics.Add(new Music() { Genre = "Hiphop", Name = "L.O.C.", Year = 2010 });
            musics.Add(new Music() { Genre = "Ungdomskultur", Name = "Roskilde Festival", Year = 2010 });
            musics.Add(new Music() { Genre = "Jazz", Name = "Jay Z", Year = 2010 });
        }
        public void CreateMusic( Music music)
        { 
           
            musics.Add(music);
        
        }

        public List<Music> ReadMusic() 

        {
          return musics;
          
        }
        public void UpdateMusic( Music music)
        { 
            foreach (Music m in musics)
            {
                if (m.Name == music.Name) 
                {
                    m.Genre = music.Genre;
                    m.Year = music.Year;    

                }
            }

        }
        public void DeleteMusic(Music music) 
        {
            foreach(var m in musics) 
            {
                if(m.Name == music.Name) 
                {
                    musics.Remove(m);
                }
            }
        }
    }
}
