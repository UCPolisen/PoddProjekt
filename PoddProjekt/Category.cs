using System;

namespace Models
{
    [Serializable] // Indikerar att klassen kan serialiseras
    public class Category
    {
        // Egenskap för kategoriens namn och ID
        public string Name { get; set; }
        public int Id { get; set; }

        // Standardkonstruktor som initierar värden
        public Category()
        {
            Name = string.Empty; // Sätter namnet till en tom sträng
            Id = 0;              // Initierar ID till 0
        }

        // Konstruktor som tillåter initialisering av ID och namn
        public Category(int id, string name)
        {
            Name = name; // Tilldelar det angivna namnet
            Id = id;     // Tilldelar det angivna ID
        }

        // Exempel på en metod för att få en beskrivning av kategorin
        public string GetDescription()
        {
            return $"Kategori: {Name}, ID: {Id}";
        }

        // Andra relevanta metoder och egenskaper kan läggas till här...
    }
}


