using Week_2_2.Entities;
using Week_2_2.Services;

Console.WriteLine("Spotify - Music for Noone");

Playlist playlist = new Playlist(new Song("Bodrum", "Yüzyüzeyken Konuşuruz", "Akustik Travma", null));
playlist.AddSong(new Song("Belki Üstümüzden Bir Kuş Geçer", "Yüksek Sadakat", null, null));
playlist.AddSong(new Song("Kupa Kızı Ve Sinek Valesi", "Teoman", null, null));
playlist.AddSong(new Song("Koca Yaşlı Şişko Dünya", "Adamlar", null, null));
playlist.AddSong(new Song("Haydi Gel İçelim", "Yüksek Sadakat", null, null));

Console.WriteLine("Before Shuffle:");
Console.WriteLine(playlist.GetSongs());

playlist.ShuffleSongs();

Console.WriteLine("\n\nAfter Shuffle:");
Console.WriteLine(playlist.GetSongs());

new NotepadService().PlaylistToNotepad(playlist);

