using MeuApp.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddScoped<CalculatorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/calculate/sum", (int a, int b, CalculatorService service) =>
{
    return Results.Ok(service.Sum(a, b));
});

app.MapGet("/calculate/divide", (int a, int b, CalculatorService service) =>
{
    try
    {
        return Results.Ok(service.Divide(a, b));
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);
    }
});

app.MapGet("/calculate/check", (int number, CalculatorService service) =>
{
    return Results.Ok(service.CheckNumber(number));
});

app.Run();

