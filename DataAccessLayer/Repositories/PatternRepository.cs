using System;
using System.Net.Http;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class PatternRepository
{
    // Asynkron metod för att hämta RSS-flödet
    public async Task<string> GetRssFeedAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }
    }

    // Metod för att parsa RSS-flödet och returnera poddens information
    public PodcastInfo ParseRssFeed(string rssFeed)
    {
        // Ladda RSS-flödet som ett XDocument (LINQ to XML)
        XDocument rssXmlDoc = XDocument.Parse(rssFeed);

        // Skapa ett PodcastInfo-objekt för att lagra poddens information
        var podcastInfo = new PodcastInfo
        {
            // Hämta poddens titel
            PodcastTitle = (string)rssXmlDoc.Descendants("channel").Elements("title").FirstOrDefault(),

            // Hämta poddens beskrivning
            PodcastDescription = (string)rssXmlDoc.Descendants("channel").Elements("description").FirstOrDefault(),

            // Hämta alla avsnitt och lägg till dem i listan
            Episodes = rssXmlDoc.Descendants("item")
                                .Select(episode => new EpisodeInfo
                                {
                                    Title = (string)episode.Element("title") ?? "Ingen titel",
                                    PublicationDate = (string)episode.Element("pubDate") ?? "Inget publiceringsdatum",
                                    Description = (string)episode.Element("description") ?? "Ingen beskrivning",
                                    Duration = (string)episode.Element(XName.Get("duration", "http://www.itunes.com/dtds/podcast-1.0.dtd")) ?? "Ingen längd angiven"
                                })
                                .ToList()
        };

        return podcastInfo;
    }
}

// Klass för att lagra poddinformation
public class PodcastInfo
{
    public string PodcastTitle { get; set; }
    public string PodcastDescription { get; set; }
    public List<EpisodeInfo> Episodes { get; set; }

    public PodcastInfo()
    {
        Episodes = new List<EpisodeInfo>();
    }
}

// Klass för att lagra avsnittsinformation
public class EpisodeInfo
{
    public string Title { get; set; }
    public string PublicationDate { get; set; }
    public string Description { get; set; }
    public string Duration { get; set; }
}
