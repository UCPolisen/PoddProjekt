using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Episode
    {
        private int ID { get; }
        public string? Title { get; set; }
        public DateTimeOffset PublicationDate { get; set; }
        public string? Description { get; set; }

        private static int nextID = 0;

        public Episode(string title, DateTimeOffset date, string description)
        {
            Title = title;
            PublicationDate = date;
            Description = description;
            ID = nextID++;
        }

        public Episode()
        {
        }

        // Andra relevanta egenskaper...
    }
}
