using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Podcast
    {
        public int ID { get; set; }
        public string? Url { get; set; }
        public string Name { get; set; } = string.Empty;  // Standardvärde
        public string? Title { get; set; }
        public Category PodcastCategory { get; set; } = new Category();  // Standardvärde
        public List<Episode> Episodes { get; set; } = new List<Episode>();  // Initialiserar till tom lista
        public string? Description { get; set; }
        public string Author { get; set; } = string.Empty;  // Standardvärde
        public string ImageUrl { get; set; } = string.Empty;  // Standardvärde
        public string CategoryName
        {
            get { return PodcastCategory.Name; }
        }

        public Podcast(string url, string name, string title, string description, string author,
            string imageUrl, Category category, List<Episode> episodeList)
        {
            Url = url;
            Name = name;
            Title = title;
            Description = description;
            Author = author;
            ImageUrl = imageUrl;
            PodcastCategory = category;
            Episodes = episodeList;
        }

        public Podcast()
        {
        }
    }
}
