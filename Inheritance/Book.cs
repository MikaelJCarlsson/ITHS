using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int pages { get; set; }

    }
    class FactBook : Book
    {
        public string subject { get; set; }
        public string difficulty { get; set; }
        public FactBook(string title, string author, int pages, string subject, string difficulty)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.subject = subject;
            this.difficulty = difficulty;

        }
    }
    class KidsBook : Book
    {
        public string readerGroup { get; set; }
        public bool pictures { get; set; }
        public KidsBook(string title, string author, int pages, string readerGroup, bool pictures)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.readerGroup = readerGroup;
            this.pictures = pictures;
        }
    }
    class Entertainment : Book
    {
        public string genre { get; set; }
        public string standAloneOrseries { get; set; }

        public Entertainment(string title, string author, int pages, string genre, string standAloneOrSeries)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.genre = genre;
            this.standAloneOrseries = standAloneOrSeries;

        }
    }
}
