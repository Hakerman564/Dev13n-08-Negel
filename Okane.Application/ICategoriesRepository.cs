namespace Okane.Application;

public interface ICategoriesRepository : IRepository<Category>
{
    public Category? ByName(string name);
    void Update(Category category);
}