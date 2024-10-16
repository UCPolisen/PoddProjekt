using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    [XmlRoot("Categories")] // Anger att denna klass är rot för XML-dokumentet
    public class CategoryList
    {
        [XmlElement("Category")] // Anger att varje kategori ska serialiseras som ett XML-element
        public List<string> Categories { get; set; }

        // Standardkonstruktor som initierar listan
        public CategoryList()
        {
            Categories = new List<string>(); // Initierar en ny lista för kategorier
        }

        // Metod för att lägga till en ny kategori till listan
        public void AddCategory(string category)
        {
            if (!string.IsNullOrEmpty(category)) // Validerar att kategorin inte är tom
            {
                Categories.Add(category); // Lägger till kategorin i listan
            }
        }

        // Metod för att hämta alla kategorier
        public IEnumerable<string> GetAllCategories()
        {
            return Categories; // Returnerar alla kategorier
        }

        // Metod för att ta bort en kategori
        public bool RemoveCategory(string category)
        {
            return Categories.Remove(category); // Försöker ta bort kategorin och returnerar om det lyckades
        }
    }
}
