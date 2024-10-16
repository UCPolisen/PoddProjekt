#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Models;

namespace BusinessLogicLayer.Controllers
{
    public class CategoryController
    {
        private const int INITIAL_ID = 1;

        IRepository<Category> _repository;

        public CategoryController()
        {
            _repository = new CategoryRepository();
        }

        public void AddCategory(string name)
        {
            // Strängvalidering
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Kategori namn kan inte vara tomt eller null.");
            }

            // Validerar unikheten hos kategorinamn
            List<Category> categoryList = GetAllCategories();
            if (categoryList.Any(k => k.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("En kategori med detta namn finns redan.");
            }

            int id = GetNextAvailableID(categoryList);
            Category newCategory = new Category(id, name);
            _repository.Create(newCategory);
        }

        public List<Category> GetAllCategories()
        {
            return _repository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _repository.GetById(id); // Återger en Kategori-entitet baserad på ID
        }

        public void UpdateCategory(int id, Category updatedCategory)
        {
            // Kontrollera att kategorin med det angivna ID:t finns
            var existingCategory = _repository.GetById(id);
            if (existingCategory == null)
            {
                throw new InvalidOperationException($"Kategori med ID {id} finns inte.");
            }

            // Se till att det inte finns någon annan kategori med samma namn (utom den som uppdateras)
            if (GetAllCategories().Any(k => k.Name.Equals(updatedCategory.Name, StringComparison.OrdinalIgnoreCase) && k.ID != id))
            {
                throw new InvalidOperationException("En kategori med detta namn finns redan.");
            }

            _repository.Update(id, updatedCategory);
        }

        public void DeleteCategory(int id)
        {
            // Kontrollera att kategorin med det angivna ID:t finns
            var existingCategory = _repository.GetById(id);
            if (existingCategory == null)
            {
                throw new InvalidOperationException($"Kategori med ID {id} finns inte.");
            }

            _repository.Delete(id);
        }

        public int GetNextAvailableID(List<Category> allCategories)
        {
            // Hämtar nästa lediga ID
            if (allCategories.Count == 0)
            {
                return INITIAL_ID;
            }

            // Om listan inte är tom, hämtar vi det högsta ID:t och lägger till 1
            int maxID = allCategories.Max(k => k.Id);
            return maxID + 1;
        }

        // ... fler metoder efter behov ...
    }
}
