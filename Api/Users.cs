using RarePublishing.Data;
using System;

namespace RarePublishing.Api
{

    public class RareUserApi
    {
        public readonly UserData users;
       
        public void Map(WebApplication app)
        {
            app.MapGet("/users", () =>
            {
                return Results.Ok(users);
            });
        }
    }
       

}
