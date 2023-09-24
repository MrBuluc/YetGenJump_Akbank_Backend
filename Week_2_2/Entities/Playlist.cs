namespace Week_2_2.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }

        public Playlist(Song song)
        {
            Id = Guid.NewGuid();
            Songs = new List<Song>();
            AddSong(song);
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public string GetSongs() => string.Join("\n", Songs.Select(x => $"{x.Title} - {x.Composer}"));

        public void ShuffleSongs()
        {
            int songCount = Songs.Count;

            Random random = new Random();

            while (songCount > 0)
            {
                songCount--;
                Song song = Songs[songCount];
                int randomIndex = random.Next(songCount);
                Songs[songCount] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }
    }
}
