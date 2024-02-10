
using RarePublishing.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

            app.MapGet("/users/{id}", (int id) =>
            {


                return UserData.users;

            });
           
        }
    }
}
