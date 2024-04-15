using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AppointementEndpoint
{
    public static void MapAppointementEndpoints(this WebApplication app)
    {
        app.MapGet("/appointement", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad request
            // 401 - Unauthorized
            // 403 - Forbidden
            // 404 - Not Found

            var appointements = StaticData._Appointements;
            return Results.Ok(appointements);
        });

        app.MapGet("/animals/{id}/appointements", ([FromRoute] int id) =>
        {
            var appointements = new MockDb().Appointements.Where(a => a.AnimalId == id);
            return Results.Ok(appointements);
        });

        
        
        app.MapPost("/appointements/", (Appointement appointement) =>
        {
            StaticData._Appointements.Add(appointement);
            return Results.Created("", null);
        });
    }
}