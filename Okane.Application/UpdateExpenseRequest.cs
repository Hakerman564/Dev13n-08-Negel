namespace Okane.Application;

public record UpdateExpenseRequest(int Id, int Amount, string CategoryName);