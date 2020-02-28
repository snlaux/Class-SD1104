using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Slaux_Lab_10_4
{
    interface IAudioPlayer
    {
        void Play();
    }

    class MediaPlayer
    {
        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
    class Artist : IAudioPlayer
    {
        public string artistName { get; }
        public Dictionary<int, string> playlist;

        public Artist(string artistName)
        {
            this.artistName = artistName;
            playlist = new Dictionary<int, string>();
        }
        public void AddToPlaylist(string songTitle)
        {
            int id = playlist.Count;
            playlist.Add(id, songTitle);
        }
        public void Play()
        {
            Random random = new Random();
            int songId = random.Next(0, playlist.Count);
            StringBuilder sb = new StringBuilder();
            sb.Append("Now playing Artist: ");
            sb.Append(artistName);
            sb.Append(" Song: ");
            sb.Append(playlist[songId]);
            Console.WriteLine(sb.ToString());
        }
    }

    class AudioBook : IAudioPlayer
    {
        public string bookTitle { get; }
        public string author { get; }

        public AudioBook(string bookTitle, string author)
        {
            this.bookTitle = bookTitle;
            this.author = author;
        }
        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now playing: ");
            sb.Append(bookTitle);
            sb.Append(" By: ");
            sb.Append(author);
            Console.WriteLine(sb.ToString());
        }
    }

    class MovieSoundTrack : IAudioPlayer
    {
        public string movieName { get; }
        public string songName { get; private set; }

        public MovieSoundTrack(string movieName)
        {
            this.movieName = movieName;
        }
        public void setTrack(string trackName)
        {
            this.songName = trackName;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now playing: ");
            sb.Append(songName);
            sb.Append(" From the movie: ");
            sb.Append(movieName);
            Console.WriteLine(sb.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Artist blink182 = new Artist("Blink 182");
            blink182.AddToPlaylist("I miss you");
            blink182.AddToPlaylist("All the small things");
            blink182.AddToPlaylist("Whats my age again");
            blink182.AddToPlaylist("Down");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(blink182);

            AudioBook harryPotter = new AudioBook("Harry Potter and the Deathly Hollows","JK Rowling");
            player.PlayMedia(harryPotter);

            MovieSoundTrack jojo = new MovieSoundTrack("JoJo Rabbit");
            jojo.setTrack("Track 1");
            player.PlayMedia(jojo);


        }
    }
}
