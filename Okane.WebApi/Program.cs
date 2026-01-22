using Okane.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();
    
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/expenses", 
    (CreateExpenseRequest request) =>
    {
        var expenses = new List<Expense>();
        var service = new ExpensesService(expenses);
        var response = service.Create(request);
        return Results.Created("/expenses", response);
    });

app.MapGet("/expenses/{id}", (int id) =>
{
    var expenses = new List<Expense>();
    var service = new ExpensesService(expenses);
    var response = service.Retrieve(id);
    
    if  (response == null)
        return Results.NotFound();
    
    return Results.Created("/expenses", response);
});

app.Run();