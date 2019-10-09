using System;
using System.Collections.Generic;
using System.Text;

namespace DRMusic
{
    public class Record
    {
        private string title;
        private string artist;
        private int duration;
        private int yearOfPublication;

        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public int Duration { get => duration; set => duration = value; }
        public int YearOfPublication { get => yearOfPublication; set => yearOfPublication = value; }

        public Record(string title, string artist, int duration, int yearOfPublication)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            YearOfPublication = yearOfPublication;
        }

        public Record()
        {
            
        }

        public override string ToString()
        {
            return $"title: {Title}, artist: {Artist}, duration: {Duration}, yearOfPublication: {YearOfPublication}";
        }
    }
}
