using Okane.Application.Expenses;
using Okane.Domain;

namespace Okane.Storage.InMemory;

public class InMemoryExpensesRepository : InMemoryRepository<Expense>, IExpensesRepository
{
    public Expense Update(int id, UpdateExpenseRequest request, Category category)
    {
        var existing = Enumerable.First<Expense>(Entities, e => e.Id == id);
        
        existing.Amount = request.Amount;
        existing.Category = category;

        return existing;
    }

    public IEnumerable<Expense> ByCategoryName(string categoryName) => 
        Enumerable.Where<Expense>(Entities, e => e.Category.Name == categoryName);
}