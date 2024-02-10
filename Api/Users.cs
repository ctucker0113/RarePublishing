
using RarePublishing.Data;
using RarePublishing.Models;

namespace RarePublishing.Api
{
    public static class RareUserApi
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/api/users", () =>
            {
                return UserData.users;
            });

            app.MapGet("api/users/{id}", (int id) =>
            {
                Users user = UserData.users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(user);

            });

            app.MapPost("api/users/{id}", (Users user) =>
            {
                user.Id = UserData.users.Max(u => u.Id) + 1;
                UserData.users.Add(user);
                return user;
            });

            app.MapDelete("/api/users/{id}", (int id) =>
            {
                Users usersToDelete = UserData.users.FirstOrDefault(u => u.Id == id);
                if (usersToDelete == null)
                {
                    return Results.NotFound();
                }
                UserData.users.Remove(usersToDelete);

                return Results.NoContent();
            });

            app.MapPut("/api/users/{id}", (int id, Users user) =>
            {
                Users usersToUpdate = UserData.users.FirstOrDefault(u => u.Id == id);
                int userIndex = UserData.users.IndexOf(usersToUpdate);
                if (usersToUpdate == null)
                {
                    return Results.NotFound();
                }
                if (id != user.Id)
                {
                    return Results.BadRequest();
                }
                UserData.users[userIndex] = user;
                return Results.Ok();
            });
        }
    }
}
