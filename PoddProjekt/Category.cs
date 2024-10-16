using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Category()
        {
            Name = string.Empty;
            Id = 0;
        }

        public Category(int id, string name)
        {
            Name = name;
            Id = id;
        }

        // Andra relevanta egenskaper...
    }
}
