using Okane.Application;

namespace Okane.Storage.EntityFramework
{
    public class CategoriesRepository(OkaneDbContext db) : ICategoriesRepository
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category? ById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> All()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Category ByName(string name) => 
            db.Categories.First(category => category.Name == name);
    }
}