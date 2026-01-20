namespace Okane.Application;

public class ExpensesService
{
    public Expense Exec(int amount, string category) => 
        new(amount, category);
}