using System;

namespace Models
{
    [Serializable] // Indikerar att klassen kan serialiseras
    public class Episode
    {
        // Egenskap för ID, endast läsbar
        private int ID { get; }

        // Egenskaper för episodens titel, publiceringsdatum och beskrivning
        public string? Title { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string? Description { get; set; }

        // Statisk variabel för att hålla nästa tillgängliga ID
        private static int _nextId = 0;

        // Konstruktor för att skapa en ny episod med specifika värden
        public Episode(string title, DateTimeOffset releaseDate, string description)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Description = description;
            ID = _nextId++; // Här återställs raden till den ursprungliga formen
        }

        // Standardkonstruktor utan parametrar
        public Episode()
        {
            // Kan användas för serialisering eller skapande av tom episod
        }

        // Ytterligare metoder och egenskaper kan läggas till här...

        // Exempel på en metod för att få en sammanfattning av episoden
        public string GetSummary()
        {
            return $"Episod: {Title}, Publicerad: {ReleaseDate}, Beskrivning: {Description}";
        }
    }
}
