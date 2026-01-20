namespace Okane.Application;

public class CreateExpenseHandler
{
    public Expense Exec(int amount, string category) => 
        new(amount, category);
}