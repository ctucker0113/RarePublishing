using RarePublishing.Models;
using System;

namespace RarePublishing.Api
{
    public static class CategoryApi
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/api/categories", () =>
            {
                return Results.Ok(CategoryData.categories);
            });

            app.MapGet("/api/categories/{id}", (int id) =>
            {
                Category category = CategoryData.categories.FirstOrDefault(c => c.Id == id);
                if (category== null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(category);
            });

            app.MapPost("/api/categories", (Category category) =>
            {
                category.Id = CategoryData.categories.Max(c => c.Id) + 1;
                CategoryData.categories.Add(category);
                return category;
            });

        }
    }
}