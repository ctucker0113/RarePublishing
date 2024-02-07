using RarePublishing.Models;
using RarePublishing.Data;

app.MapGet("/api/categories", () =>
{
    return Results.Ok(categories);
});

app.MapGet("/api/categories/{id}", (int id) =>
{
    Category category = categories.FirstOrDefault(c => c.Id == id);
    if (category== null)
    {
        return Results.NotFound();
    }
    return Results.Ok(category);
});

app.MapPost("/api/categories", (Category category) =>
{
    category.Id = categories.Max(c => c.Id) + 1;
    categories.Add(category);
    return category;
});