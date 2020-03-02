using System.Collections.Generic;

namespace RecordCompany.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool Lyrics { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public Album Album { get; set; }
    }
}