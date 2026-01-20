namespace Okane.Tests;

public class CreateExpenseTests
{
    [Fact]
    public void Test()
    {
        var expense = CreateExpense(10, "Food");

        Assert.Equal(10, expense.Amount);
        Assert.Equal("Food", expense.CategoryName);
    }

    private Expense CreateExpense(int amount, string category)
    {
        var handler = new CreateExpenseHandler();
        return handler.Exec(amount, category);
    }
}

internal class CreateExpenseHandler
{
    public Expense Exec(int amount, string category) => 
        new(amount, category);
}

public record Expense(int Amount,  string CategoryName);