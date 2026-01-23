using System.Collections.Generic;
using System.Linq;

namespace Okane.Application;

public class ExpensesService(List<Expense> expenses)
{
    private static int _lastId = 1;

    public Expense Create(CreateExpenseRequest request)
    {
        var (amount, categoryName) = request;
        var id = _lastId++;
        var expense = new Expense(id, amount, categoryName);
        expenses.Add(expense);
        return expense;
    }

    public Expense? Retrieve(int expenseId)
    {
        var expense = expenses.FirstOrDefault(e => e.Id == expenseId);
        return expense;
    }

    public IEnumerable<Expense> All() => expenses;

    public Expense? Update(int id, UpdateExpenseRequest request)
    {
        var existing = expenses.FirstOrDefault(e => e.Id == id);
        
        if (existing is null)
            return null;
        
        expenses.Remove(existing);
        
        var newExpense = new Expense(
            id, 
            request.Amount, 
            request.CategoryName);
        
        expenses.Add(newExpense);
        
        return newExpense;
    }

    public bool Delete(int id)
    {
        var expense = expenses.FirstOrDefault(expense => expense.Id == id);
        
        if (expense is null)
            return false;
        
        return expenses.Remove(expense);
    }
}