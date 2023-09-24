using Week_2_2.Entities;

namespace Week_2_2.Services
{
    public class NotepadService
    {
        public void PlaylistToNotepad(Playlist playlist)
        {
            string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";

            if (!File.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(Path.Combine(directory, $"{playlist.Id}.txt"), playlist.GetSongs());

            Console.WriteLine("Data Successfully Saved to NotePad!");
        }
    }
}
